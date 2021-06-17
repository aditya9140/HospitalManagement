using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace HospitalManagement.Models
{
    public class EmployeeDB
    {

        private SqlConnection con;

        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString;
            con = new SqlConnection(constring);
        }
        //Add New Employee
        public bool Addemployee(Employee employee)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddNewEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", employee.Name);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.Parameters.AddWithValue("@Address", employee.Address);
            cmd.Parameters.AddWithValue("@Phoneno", employee.Phoneno);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)

                return true;
            else
                return false;
        }
        // ********** VIEW Employee DETAILS ********************
        public List<Employee> GetEmployee()
        {
            connection();
            List<Employee> employeelist = new List<Employee>();
            SqlCommand cmd = new SqlCommand("GetEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                employeelist.Add(
                    new Employee
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        Email = Convert.ToString(dr["Email"]),
                        Address = Convert.ToString(dr["Address"]),
                        Phoneno = Convert.ToString(dr["Phoneno"]),
                    });
            }
            return employeelist;
        }
        // ***************** UPDATE STUDENT DETAILS *********************
        public bool UpdateDetails(Employee employee)
        {
            connection();
            SqlCommand cmd = new SqlCommand("UpdateEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", employee.Id);
            cmd.Parameters.AddWithValue("@Name", employee.Name);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.Parameters.AddWithValue("@Address", employee.Address);
            cmd.Parameters.AddWithValue("@Phoneno", employee.Phoneno);


            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // ********************** DELETE Employee DETAILS *******************
        public bool DeleteStudent(int id)
        {
            connection();
            SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

    }
}