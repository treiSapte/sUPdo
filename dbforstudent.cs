using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using MySql.Data.MySqlClient;
using System.Data;


namespace sUPdo
{
    class dbforstudent
    {


        public static string server = "**********";
        public static string databasee = "**********";
        public static string uid = "**********";
        public static string password = "**********";
        public static string connectionString2 = "SERVER=" + server + ";" + "DATABASE=" + databasee + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        public static void getTeacherName()
        {
            try
            {
                
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("SELECT Name FROM teachers WHERE Id=@ID",connection);
                cmd.Parameters.AddWithValue("@ID",important.id_teacher);
                MySqlDataReader reader = null;
                connection.Open();
                reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    important.name_teacher = reader.GetString(1);
                }
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static byte[] compress(byte[] buffer)
        {
            MemoryStream ms = new MemoryStream();
            GZipStream zip = new GZipStream(ms, CompressionMode.Compress, true);
            zip.Write(buffer, 0, buffer.Length);
            zip.Close();
            ms.Position = 0;

            byte[] compressed = new byte[ms.Length];
            ms.Read(compressed, 0, compressed.Length);

            byte[] gzBuffer = new byte[compressed.Length + 4];
            Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
            return gzBuffer;
        }

        private static byte[] decompress(byte[] gzBuffer)
        {
            MemoryStream ms = new MemoryStream();
            int msgLength = BitConverter.ToInt32(gzBuffer, 0);
            ms.Write(gzBuffer, 4, gzBuffer.Length - 4);

            byte[] buffer = new byte[msgLength];

            ms.Position = 0;
            GZipStream zip = new GZipStream(ms, CompressionMode.Decompress);
            zip.Read(buffer, 0, buffer.Length);

            return buffer;
        }

        private static byte[] databaseFilePut(string varFilePath)
        {

            byte[] file;
            using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }

            file = compress(file);

            return file;

        }

        public static void makefisier(string path, int varID) 
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString2))
            using (var sqlQuery = new MySqlCommand(@"SELECT File FROM fileToStudent WHERE Id=@varID", connection))
            {
                connection.Open();
                sqlQuery.Parameters.AddWithValue("@varID", varID);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                    if (sqlQueryResult != null)
                    {

                        sqlQueryResult.Read();

                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];

                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        blob = decompress(blob);
                        using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                            fs.Write(blob, 0, blob.Length);
                    }
            }

        }

        public static void insertFiles(string path, string message)
        {
            important.trimis = 1;
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("INSERT INTO fileToTeacher (Id_Teacher, Name_Student, Class_Student, DateTime, Extension, File_Name, File, Message) VALUES (@idteacher, @studentname, @studentclass, @datime, @extension, @filename, @file, @message)",connection);
                cmd.Parameters.AddWithValue("@idteacher", important.id_teacher);
                cmd.Parameters.AddWithValue("@studentname", important.nume);
                cmd.Parameters.AddWithValue("@studentclass", important.clas);
                cmd.Parameters.AddWithValue("@datime", DateTime.Now);
                cmd.Parameters.AddWithValue("@extension", Path.GetExtension(path));
                cmd.Parameters.AddWithValue("@filename", Path.GetFileNameWithoutExtension(path));
                cmd.Parameters.AddWithValue("@file", databaseFilePut(path));
                cmd.Parameters.AddWithValue("@message", message);
                connection.Open();
                cmd.ExecuteScalar();
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void extractFiles()
        {

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM fileToStudent WHERE Id_Teacher=@id AND Classes LIKE @classes", connection);  ///////////////////// where
                cmd.Parameters.AddWithValue("@id", important.id_teacher);
                cmd.Parameters.AddWithValue("@classes", '%'+important.clas+'%');

                MySqlDataReader reader = null;
                connection.Open();
                reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    important.filesS[i].id = reader.GetInt32(0);
                    important.filesS[i].nameS = reader.GetString(2);
                    important.filesS[i].classS = reader.GetString(3);
                    important.filesS[i].datime = reader.GetDateTime(4);
                    important.filesS[i].extension = reader.GetString(5);
                    important.filesS[i].namefile = reader.GetString(6);
                    if (reader.IsDBNull(8))
                        important.filesS[i].message = "";
                    else
                        important.filesS[i].message = reader.GetString(8);
                    i++;
                }
                important.lungime = i;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
