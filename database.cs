using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace sUPdo
{
    class database
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["sUPdo.Properties.Settings.sUPdoDBConnectionString"].ConnectionString;
        
        public static int id_users = 0;

        
        public static string server = "**********";
        public static string databasee = "**********";
        public static string uid = "**********";
        public static string password = "**********";
        public static string connectionString2 = "SERVER=" + server + ";" + "DATABASE=" +databasee + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        private static int Check_Email_Teachers(string email)
        {
            bool one = true;
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM teachers WHERE Email=@email", connection);
                cmd.Parameters.AddWithValue("@email", email);
                MySqlDataReader reader = null;
                connection.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                    one = false;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (one == false)
                return 0;
            return 1;
        }

        private static int Check_Email_Students(string email)
        {
            bool one = true;
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE Email=@email", connection);
                cmd.Parameters.AddWithValue("@email", email);
                MySqlDataReader reader = null;
                connection.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                    one = false;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (one == false)
                return 0;
            return 1;
        }

        public static int signUPstudent(string name, string email, string pass, string clas, int code_teacher)
        {
            if (Check_Email_Students(email) == 1)
            {
                MySqlConnection connection;
                connection = new MySqlConnection(connectionString2);

                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {

                        MySqlCommand cmd = new MySqlCommand("INSERT INTO students (Name, Email, Password, Class, Code_teacher) VALUES (@name, @email, @pass, @classes, @code)", connection);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@pass", functions.EncryptString(pass)); // criptarea in function
                        cmd.Parameters.AddWithValue("@classes", clas);
                        cmd.Parameters.AddWithValue("@code", code_teacher);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("nu");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
            }
            else
                return 2; // emailul exista

            return 1;//inregistrare facuta
            
        }

        public static int signUPteacher(string name, string email, string pass)
        {
            if (Check_Email_Teachers(email) == 1)
            {
                
                MySqlConnection connection;
                connection = new MySqlConnection(connectionString2);

                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO teachers (Name, Email, Password, Classes) VALUES (@name ,@email, @pass, @classes)", connection);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@pass", functions.EncryptString(pass)); // criptarea in function
                        cmd.Parameters.AddWithValue("@classes", DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("nu");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();

            }
            else
                return 2; //exista emailul asta
            return 1; // inregistrare reusita
        }


        public static int signINt(string email, string pass)
        {
            bool one = false;
            bool adress = false;
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM teachers WHERE Email=@email", connection);
                cmd.Parameters.AddWithValue("@email",email);
                MySqlDataReader reader = null;
                connection.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                    adress = true;
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (adress == false)
                return 2; // adresa nu exista in baza de date
            else
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection(connectionString2);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM teachers WHERE Email=@email AND Password=@pass", connection);
                    cmd.Parameters.AddWithValue("@email",email);
                    cmd.Parameters.AddWithValue("@pass",functions.EncryptString(pass)); // decriptarea in functions
                    MySqlDataReader reader = null;
                    connection.Open();
                    reader = cmd.ExecuteReader();
                    if(reader.Read())
                    {
                        important.id = reader.GetInt32(0);
                        important.nume = reader.GetString(1);
                        one = true;
                    }
                    connection.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (one == true)
                return 1;
            return 0;
        }

        public static int signINs(string email, string pass)
        {
            bool one = false;
            bool adress = false;
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE Email=@email", connection);
                cmd.Parameters.AddWithValue("@email", email);
                MySqlDataReader reader = null;
                connection.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                    adress = true;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (adress == false)
                return 2; // adresa nu exista in baza de date
            else
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection(connectionString2);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE Email=@email AND Password=@pass", connection);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", functions.EncryptString(pass)); // decriptarea in functions
                    MySqlDataReader reader = null;
                    connection.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        important.id= reader.GetInt32(0);
                        important.nume = reader.GetString(1);
                        important.clas = reader.GetString(4);
                        one = true;
                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (one == true)
                return 1;
            return 0;
        }

        public static string recPass(string email)
        {
            // verific la elevi, la profi, daca macar una e 1 returnez parola
            // daca nu returnez .
            int oks = 0, okp = 0;
            string parola="";
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE email=@emailtx", connection);


                cmd.Parameters.AddWithValue("@emailtx", email);


                MySqlDataReader reader = null;
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    oks = 1;
                    parola = reader.GetString(3);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (oks == 1)
                return parola;
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM teachers WHERE Email=@emailtx", connection);


                cmd.Parameters.AddWithValue("@emailtx", email);


                MySqlDataReader reader = null;
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    okp = 1;
                    parola = reader.GetString(3);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (okp == 1)
                return parola;
            return ".";
        }

        public static void getIdTeacher(Int32 id_student)
        {
            
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString2);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE Id=@idstude", connection);


                cmd.Parameters.AddWithValue("@idstude", id_student);


                MySqlDataReader reader = null;
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    important.id_teacher = reader.GetInt32(5);
                    important.clas = reader.GetString(4);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

    }
}
