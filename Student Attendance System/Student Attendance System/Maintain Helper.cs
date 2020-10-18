using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System
{
    public class Maintain_Helper
    {
        public static string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SAS_DB.mdf;Integrated Security=True";
        public string id = "";
        SqlConnection conn = null;

        public string ConnectionString   
        {
            get { return connstr; }
            set { connstr = value; } 
        }

        private void Connect()
        {
            if(conn == null)
                conn = new SqlConnection(ConnectionString);

            conn.Close();
        }

        public bool CheckEmail(string email)
        {
            try
            {
                var eaddr = new System.Net.Mail.MailAddress(email);

                return eaddr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool CheckID(string id)
        {
            int i;

            return int.TryParse(id,out i);
        }

        public bool CheckPrivilege(string id)
        {
            SqlDataReader dreader;
            SqlCommand comm;

            string sql = "SELECT Admin FROM LECTURERS WHERE Lecturer_ID = " + id;
            bool admin = false;

            try
            {
                Connect();
                conn.Open();

                comm = new SqlCommand(sql, conn);
                dreader = comm.ExecuteReader();

                while (dreader.Read())
                {
                    admin = Convert.ToBoolean(dreader.GetInt32(0));
                }

                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            return admin;
        }

        public bool Insert(string id, string fname, string lname, string email, string password)
        {
            int result = 0;

            Connect();

            string table = "", fields = "";

            table = "STUDENTS ";
            fields = "(Student_ID, Name, Last_Name, Email, Password)";

            try
            {
                string sql = "INSERT INTO " + table + fields + " VALUES (@id, @fname, @lname, @email, @password)";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@fname", fname);
                comm.Parameters.AddWithValue("@lname", lname);
                comm.Parameters.AddWithValue("@email", email);
                comm.Parameters.AddWithValue("@password", password);

                conn.Open();
                result = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            if (result < 0)
                return false;
            else
                return true;

        }

        public bool Insert(string id, string fname, string lname, string email, string password, int admin)
        {
            int result = 0;

            Connect();

            string table = "", fields = "";

            table = "LECTURERS ";
            fields = "(Lecturer_ID, Name, Last_Name, Email, Password)";

            try
            {
                string sql = "INSERT INTO " + table + fields + " VALUES (@id, @fname, @lname, @email, @password)";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@fname", fname);
                comm.Parameters.AddWithValue("@lname", lname);
                comm.Parameters.AddWithValue("@email", email);
                comm.Parameters.AddWithValue("@password", password);

                conn.Open();
                result = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            if (result < 0)
                return false;
            else
                return true;

        }

        public bool Insert(string modID, string modDes)
        {

            int result = 0;

            Connect();

            string table = "", fields = "";

            table = "MODULES ";
            fields = "(Module_ID, Description)";


            try 
            {
                string sql = "INSERT INTO " + table + fields + " VALUES (@modID, @modDes)";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@modID", modID);
                comm.Parameters.AddWithValue("@modDes", modDes);
                
                conn.Open();
                result = comm.ExecuteNonQuery();
                conn.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            if (result < 0)
                return false;
            else
                return true;
        }

        public bool Update(string id, string fname, string lname, string email, string password)
        {
            int result = 0;
            string table = "", field = "";

            table = "STUDENTS ";
            field = "Student_ID";

            string pw = "";

            if (password != "")
                pw = ", Password = '@password'";

            string sql = "UPDATE " + table + " SET Name = @fname, Last_Name = @lname, Email = @email" + pw + " WHERE " + field + " = @id";

            Connect();

            try
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@fname", fname);
                comm.Parameters.AddWithValue("@lname", lname);
                comm.Parameters.AddWithValue("@email", email);

                if (password != "")
                    comm.Parameters.AddWithValue("@password", password);

                conn.Open();
                result = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            if (result < 0)
                return false;
            else
                return true;
        }

        public bool Update(string id, string fname, string lname, string email, string password, int admin)
        {
            int result = 0;
            string table = "", field = "";

            table = "LECTURERS ";
            field = "Lecturer_ID";

            string pw = "";

            if (password != "")
                pw = ", Password = '@password'";

            string sql = "UPDATE " + table + " SET Name = @fname, Last_Name = @lname, Email = @email, Admin = @admin" + pw + " WHERE " + field + " = @id";

            Connect();

            try
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@fname", fname);
                comm.Parameters.AddWithValue("@lname", lname);
                comm.Parameters.AddWithValue("@email", email);
                comm.Parameters.AddWithValue("@admin", admin);

                if (password != "")
                    comm.Parameters.AddWithValue("@password", password);

                conn.Open();
                result = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            if (result < 0)
                return false;
            else
                return true;
        }

        public bool Update(string modID, string modDes)
        {
            int result = 0;
            string sql = "UPDATE MODULES SET Description = @modDes WHERE Module_ID = @id";

            Connect();
            try
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@modDes", modDes);

                conn.Open();
                result = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            if (result < 0)
                return false;
            else
                return true;
        }

        public bool Delete(char type, string id)
        {
            int result = 0;
            string table = "", field = "";

            if (type == 'S')
            {
                table = "STUDENTS ";
                field = "Student_ID";
            }
            else if (type == 'L')
            {
                table = "LECTURERS ";
                field = "Lecturer_ID";
            }
            else
                table = null;

            if (table != null)
            {
                string sql = "DELETE FROM " + table +  "WHERE " + field + " = @id";

                Connect();

                try 
                {
                    SqlCommand comm = new SqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@id", id);
                
                    conn.Open();
                    result = comm.ExecuteNonQuery();
                    conn.Close();
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
            }

            if (result < 0)
                return false;
            else
                return true;
        }

        public bool Delete(string id)
        {
            int result = 0; 
            string sql = "DELETE FROM MODULES WHERE Module_ID = @id";

            Connect();

            try
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@id", id);

                conn.Open();
                result = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            if (result < 0)
                return false;
            else
                return true;
        }
    }
}
