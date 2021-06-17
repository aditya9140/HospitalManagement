using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using HospitalManagement.Models;

namespace HospitalManagement.Controllers
{
    public class HospitalController : Controller
    {
        // GET: Hospital
        public ActionResult Hospital()
        {
            string connectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True";
            DataTable dtblProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Hospitaldetail", sqlCon);
                sqlDa.Fill(dtblProduct);


            }
            return View(dtblProduct);
        }
    

     

        // GET: Hospital/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hospital/Create
        [HttpPost]
        public ActionResult Create(Hospitaldetail hospitaldetail)
        {
            string connectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Hospitaldetail",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Hospitalname", hospitaldetail.HospitalName);
                cmd.Parameters.AddWithValue("@Address", hospitaldetail.Address);
                cmd.Parameters.AddWithValue("@Email", hospitaldetail.Email);
                cmd.Parameters.AddWithValue("@Phoneno", hospitaldetail.Phoneno);
                cmd.Parameters.AddWithValue("@Mobileno", hospitaldetail.Mobileno);
                cmd.Parameters.AddWithValue("@Website", hospitaldetail.Website);
                cmd.Parameters.AddWithValue("@Query", 1);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Hospital");
        }

        [HttpGet]
       
        public ActionResult Edit(int id)
        {
            string connectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True";
            Hospitaldetail hospitalDetail = new Hospitaldetail();
            DataTable dtblProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "Select * from Hospitaldetail where HospitalId=@HospitalId";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.SelectCommand.Parameters.AddWithValue("@HospitalId", id);
                sqlDa.Fill(dtblProduct);
            }
            if (dtblProduct.Rows.Count == 1)
            {
                hospitalDetail.HospitalId = Convert.ToInt32(dtblProduct.Rows[0][0].ToString());
                hospitalDetail.HospitalName = dtblProduct.Rows[0][1].ToString();
                hospitalDetail.Address = dtblProduct.Rows[0][2].ToString();
                hospitalDetail.Email = dtblProduct.Rows[0][3].ToString();
                hospitalDetail.Phoneno = dtblProduct.Rows[0][4].ToString();
                hospitalDetail.Mobileno = dtblProduct.Rows[0][5].ToString();
                hospitalDetail.Website = dtblProduct.Rows[0][6].ToString();
                return View(hospitalDetail);
            }
            else
                return RedirectToAction("Hospital");

        }
        // POST: Hospital/Edit/5
        [HttpPost]
        public ActionResult Edit(Hospitaldetail hospitalDetail)
        {
            string connectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True";

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "Update Hospitaldetail set HospitalName=@HospitalName, Address=@Address, Email=@Email,Phoneno=@Phoneno,Mobileno=@Mobileno,Website=@Website where HospitalId=@HospitalId";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@HospitalId", hospitalDetail.HospitalId);
                cmd.Parameters.AddWithValue("@HospitalName", hospitalDetail.HospitalName);
                cmd.Parameters.AddWithValue("@Address", hospitalDetail.Address);
                cmd.Parameters.AddWithValue("@Email", hospitalDetail.Email);
                cmd.Parameters.AddWithValue("@Phoneno", hospitalDetail.Phoneno);
                cmd.Parameters.AddWithValue("@Mobileno", hospitalDetail.Mobileno);
                cmd.Parameters.AddWithValue("@Website", hospitalDetail.Website);
               
                cmd.ExecuteNonQuery();

            }
            return RedirectToAction("Hospital");
        }

        // GET: Hospital/Delete/5
        public ActionResult Delete(int id)
        {
            string connectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True";

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Hospitaldetail", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HospitalId", id);
                cmd.Parameters.AddWithValue("@Query", 3);
                sqlCon.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Hospital");
        }


    }
}
