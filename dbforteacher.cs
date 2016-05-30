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
    class dbforteacher
    {


        public static string server = "**********";
        public static string databasee = "**********";
        public static string uid = "**********";
        public static string password = "**********";
        public static string connectionString2 = "SERVER=" + server + ";" + "DATABASE=" + databasee + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

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

        public static void makefisier(string path, int varID) // unde si care sa'l faca
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString2))
            using (var sqlQuery = new MySqlCommand(@"SELECT File FROM fileToTeacher WHERE Id=@varID", connection))
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

        public static void extractFiles()
        {
            
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM fileToTeacher WHERE Id_Teacher=@id", connection);  ///////////////////// where
                cmd.Parameters.AddWithValue("@id", important.id);


                MySqlDataReader reader = null;
                connection.Open();
                reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    /*string path = @"C:\Users\treiS\Desktop\daca merge\" + reader.GetString(6) + reader.GetString(5);
                    
                    if (File.Exists(path) == false) ///////////////////////////////////////////////aici
                    {
                        //long fileLength = new System.IO.FileInfo(path).Length; pun inca o coloana in baza de date in care pun marimea

                        makefisier(path, reader.GetInt32(0));
                    }*/
                    important.files[i].id = reader.GetInt32(0);
                    important.files[i].nameS = reader.GetString(2);
                    important.files[i].classS = reader.GetString(3);
                    important.files[i].datime = reader.GetDateTime(4);
                    important.files[i].extension = reader.GetString(5);
                    important.files[i].namefile = reader.GetString(6);
                    if (reader.IsDBNull(8))
                        important.files[i].message = "";
                    else
                        important.files[i].message = reader.GetString(8);
                    i++;
                }
                important.lungime=i;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public static void insertFiles(string path, string message, string classes)
        {
           
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("INSERT INTO fileToStudent (Id_Teacher, Name_Teacher, Classes, DateTime, Extension, File_Name, File, Message) VALUES (@idteacher, @teachername, @classes, @datime, @extension, @filename, @file, @message)", connection);
                cmd.Parameters.AddWithValue("@idteacher", important.id_teacher);
                cmd.Parameters.AddWithValue("@teachername", important.nume);
                cmd.Parameters.AddWithValue("@classes", classes); 
                cmd.Parameters.AddWithValue("@datime", DateTime.Now);
                cmd.Parameters.AddWithValue("@extension", Path.GetExtension(path));
                cmd.Parameters.AddWithValue("@filename", Path.GetFileNameWithoutExtension(path));
                cmd.Parameters.AddWithValue("@file", databaseFilePut(path));
                cmd.Parameters.AddWithValue("@message", message);
                connection.Open();
                cmd.ExecuteScalar();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static string getClasses()
        {
            string classesString = "";
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE Code_teacher=@idprof", connection);
                cmd.Parameters.AddWithValue("@idprof", important.id);
                MySqlDataReader reader = null;
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string s = reader.GetString(4);
                    if (classesString.IndexOf(s) == -1)
                    {
                        classesString = classesString + " " + s;
                    }

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return classesString;
        }



    }
}
