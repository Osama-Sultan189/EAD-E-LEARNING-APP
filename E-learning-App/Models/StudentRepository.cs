using System.Data;
using System.Data.SqlClient;

namespace E_learning_App.Models
{
    public class StudentRepository
    {
        string conn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void addStudent(Student s)
        {
            //SqlConnection con = new SqlConnection(conn);
            //con.Open();
            //string query = "insert into [Student] values('" + s.Id + "','" + s.Name + "','" + s.Email + "','" + s.Password + "','" + s.Phone + "','" + s.Address + "','" + s.City + "','" + s.State + "','" + s.Zip + "','" + s.Country + "','" + s.Image + "','" + s.Role + "','" + s.Status + "','" + s.CreatedAt + "','" + s.UpdatedAt + "')";
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
            //con.Close();
        }
        public void removeStudent(int id)
        {
            //SqlConnection con = new SqlConnection(conn);
            //con.Open();
            //string query = "delete from [Student] where Id='" + id + "'";
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
            //con.Close();
        }

        public void updateStudent(int id,Student s)
        {
            //SqlConnection con = new SqlConnection(conn);
            //con.Open();
            //string query = "update [Student] set Name='" + s.Name + "',Email='" + s.Email + "',Password='" + s.Password + "',Phone='" + s.Phone + "',Address='" + s.Address + "',City='" + s.City + "',State='" + s.State + "',Zip='" + s.Zip + "',Country='" + s.Country + "',Image='" + s.Image + "',Role='" + s.Role + "',Status='" + s.Status + "',CreatedAt='" + s.CreatedAt + "',UpdatedAt='" + s.UpdatedAt + "' where Id='" + id + "'";
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
            //con.Close();
        }
    }
}
