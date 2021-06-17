using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class CustomerService
    {

        public static SQLConnConfig _conn;
        public SqlConnection connection;

        public CustomerService(SQLConnConfig conn)
        {
            _conn = conn;
            connection = new SqlConnection(_conn.Value);
        }


        public List<CustomerInfo> GetCustomer()
        {
            List<CustomerInfo> lstCustomer = new List<CustomerInfo>();

            SqlCommand cmd = new SqlCommand("Select * from Customer",connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)

                {
                  
                    CustomerInfo customerInfo = new CustomerInfo();

                    customerInfo.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    customerInfo.Name = dt.Rows[i]["Name"].ToString();
                    customerInfo.Email = dt.Rows[i]["Email"].ToString();
                    customerInfo.Age = Convert.ToInt32(dt.Rows[i]["Age"]);
                    customerInfo.Salary = Convert.ToDecimal(dt.Rows[i]["Salary"]);
                    lstCustomer.Add(customerInfo);
                }
            }
            return lstCustomer;
        }
        //To Add new Customer record    
        public void Create(CustomerInfo Customer)
        {
           
                SqlCommand cmd = new SqlCommand("usp_AddCustomer", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Customer.Name);
                cmd.Parameters.AddWithValue("@Email", Customer.Email);
                cmd.Parameters.AddWithValue("@Age", Customer.Age);
                cmd.Parameters.AddWithValue("@Salary", Customer.Salary);connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            
        }
        //To Update the records of a particluar Customer  
        public void UpdateCustomer(CustomerInfo Customer)
        {
           
                SqlCommand cmd = new SqlCommand("usp_UpdateCustomer", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Customer.Id);
                cmd.Parameters.AddWithValue("@Name", Customer.Name);
                cmd.Parameters.AddWithValue("@Email", Customer.Email);
                cmd.Parameters.AddWithValue("@Age", Customer.Age);
                cmd.Parameters.AddWithValue("@Salary", Customer.Salary);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        //Get the details of a particular Customer  
        public CustomerInfo GetCustomerByID(int? id)
        {
            CustomerInfo Customer = new CustomerInfo();

          

                SqlCommand cmd = new SqlCommand("usp_GetCustomerByID", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Customer.Id = Convert.ToInt32(rdr["Id"]);
                    Customer.Name = rdr["Name"].ToString();
                    Customer.Email = rdr["Email"].ToString();
                    Customer.Age = Convert.ToInt32(rdr["Age"]);
                    Customer.Salary = Convert.ToDecimal(rdr["Salary"]);
            }
            connection.Close();
            return Customer;
        }
        //To Delete the record on a particular Customer  
        public void Delete(int? id)
        {
           
                SqlCommand cmd = new SqlCommand("usp_DeleteCustomer", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            
        }
    }
}
