
using System.Collections.Generic;
using BOL;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BOL;

namespace DAL
{
    public class TraningRepository
    {
        #region static data
        public static List<Student> GetAll()
        {
           var students = new List<Student>
           {
                //new Student(){StudentId=101,StudentName="bhanu",StudentCity="hyd"},
                //new Student(){StudentId=104,StudentName="kiran",StudentCity="pune"},
                //new Student(){StudentId=111,StudentName="laxmikanth",StudentCity="pune"}

           };
            return students;
        }
        #endregion

        public static string conString = string.Empty;
        static TraningRepository()
        {
            conString = ConfigurationManager.ConnectionStrings["StudentConnection"].ConnectionString;
        }

        public static List<Student> GetAllData()
        {
            List<Student> students = new List<Student>();
            string cmdText = "SELECT * FROM Students";
            SqlConnection con = new SqlConnection();
            // string conString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentData.mdf;Integrated Security=True";
            con.ConnectionString = conString;
           // SqlCommand cmd = new SqlCommand(cmdText, con as SqlConnection);

            SqlCommand cmd = new SqlCommand(cmdText, con as SqlConnection);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(); // Fire  Command
                while (reader.Read())
                {
                    Student s = new Student();
                    s.Id = int.Parse(reader["Id"].ToString());
                    s.Name= reader["Name"].ToString();
                    s.Email = reader["Email"].ToString();
                    s.Password = reader["Password"].ToString();
                    s.City = reader["City"].ToString();

                    students.Add(s);

                }
                reader.Close();

            }
            catch(SqlException exp)
            {
                throw exp;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return students;
        }

        //validating student 
        public static bool ValidateStudent(string email,string password)
        {
            Student s2 = null;

            bool status = false;
            string cmdText="select * from students where Email = @email and Password =  @password";

            IDbConnection con = new SqlConnection();
            con.ConnectionString = conString;
            SqlCommand cmd = new SqlCommand(cmdText, con as SqlConnection);
            cmd.Parameters.AddWithValue("email",email);
            cmd.Parameters.AddWithValue("password", password);

            try
            {
                con.Open();
                IDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    s2 = new Student();
                s2.Name = reader["Name"].ToString();
                    status = true;         
            }
            catch(SqlException e)
            {
                throw e;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return status;
        }

        public static bool DeleteStudent(int id)
        {
            bool status = false;
            string cmdText = "DELETE FROM students WHERE Id=@id";
            IDbConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand cmd = new SqlCommand(cmdText, conn as SqlConnection);
            cmd.Parameters.AddWithValue("id", id);
            try
            {
                //on sucessfull deletion it returns value greater than equals to 1
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i >= 1)
                {
                    return true;
                }
                
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return status;
        }

        public static bool Update(int id,string name,string email,string city)
        {
            bool status = false;
            string cmdText = "UPDATE students SET Name=@name ,Email = @email , City = @city WHERE Id = @id";
            IDbConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand cmd = new SqlCommand(cmdText, conn as SqlConnection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name" ,name);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("city", city);
            try
            {
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i >= 1)
                {
                    return true;
                }

            }
            catch(SqlException e)
            {
                throw e;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return status;
        }

        public static bool Register(int id, string name, string email, string password, string city)
        {
            bool status = false;
            string cmdText = "INSERT INTO students (Id,Name,Email,Password,City) VALUES(@id,@name,@email,@password,@city)";
            IDbConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand cmd = new SqlCommand(cmdText, conn as SqlConnection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("city", city);
            try
            {
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i >= 1)
                {
                    return true;
                }

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return status;
        }

    }
}
