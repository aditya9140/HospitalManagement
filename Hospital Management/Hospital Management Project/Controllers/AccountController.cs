using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hospital_Management_Project.Models;
using System.Data;
using System.Data.SqlClient;

namespace Hospital_Management_Project.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register register)
        {
            string connectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True ";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "Insert into Register values(@Name,@Email,@Password)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", register.Name);
                cmd.Parameters.AddWithValue("@Email", register.Email);
                cmd.Parameters.AddWithValue("@Password", register.Password);
                cmd.ExecuteNonQuery();
            }



            return View("Create");

        }
    }
}