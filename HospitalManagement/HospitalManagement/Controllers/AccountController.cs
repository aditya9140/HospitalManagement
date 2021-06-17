using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Mvc;
using HospitalManagement.Models;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;
using PagedList;

namespace HospitalManagement.Controllers
{
    public class AccountController : Controller
    {
        DbModelss db = new DbModelss();
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True;";
        }
        [HttpPost]
        public ActionResult Verify(Account account)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select Username,Password from Login where Username=@Username and Password=@Password";
            com.Parameters.AddWithValue("@Username", account.Username);
            com.Parameters.AddWithValue("@Password", account.Password);
            dr = com.ExecuteReader();
            if (dr.Read())
            {

                return View("Create");
            }
            else
            {
                con.Close();
                return View("Error");
            }


        }
        // 1. *************RETRIEVE ALL Employee DETAILS ******************
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeDB dbhandle = new EmployeeDB();
            ModelState.Clear();
            return View(dbhandle.GetEmployee());
        }

        // 2. *************ADD NEW Employee ******************
        // GET: Employee/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeDB sdb = new EmployeeDB();
                    if (sdb.Addemployee(employee))
                    {
                        ViewBag.Message = "Employee Details Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // 3. ************* EDIT Employee DETAILS ******************
        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            EmployeeDB sdb = new EmployeeDB();
            return View(sdb.GetEmployee().Find(smodel => smodel.Id == id));
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {
                EmployeeDB sdb = new EmployeeDB();
                sdb.UpdateDetails(employee);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // 4. ************* DELETE STUDENT DETAILS ******************
        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                EmployeeDB sdb = new EmployeeDB();
                if (sdb.DeleteStudent(id))
                {
                    ViewBag.AlertMsg = "Employee Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Employee()
        {
            string connectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True";
            DataTable dtblProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Employee", sqlCon);
                sqlDa.Fill(dtblProduct);


            }
            return View(dtblProduct);
        }

        [HttpGet]
        public ActionResult AddEmp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmp(Employee employee)
        {
            string connectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddNewEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                cmd.Parameters.AddWithValue("@Phoneno", employee.Phoneno);
                con.Open();
                cmd.ExecuteNonQuery();

            }
            return RedirectToAction("Employee");
        }

        [HttpGet]
        public ActionResult EditEmp(int id)
        {
            string connectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True";
            Employee employee = new Employee();
            DataTable dtblProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("GetEmployeeDetails", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                sd.Fill(dtblProduct);
            }
            if (dtblProduct.Rows.Count == 1)
            {
                employee.Id = Convert.ToInt32(dtblProduct.Rows[0][0].ToString());
                employee.Name = dtblProduct.Rows[0][1].ToString();
                employee.Email = dtblProduct.Rows[0][2].ToString();
                employee.Address = dtblProduct.Rows[0][3].ToString();
                employee.Phoneno = dtblProduct.Rows[0][4].ToString();
                return View(employee);
            }
            else
            {
                return RedirectToAction("Employee");
            }

        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult EditEmp(Employee employee)
        {
            string connectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True";

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("UpdateEmployeeDetails",sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", employee.Id);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                cmd.Parameters.AddWithValue("@Phoneno", employee.Phoneno);
                cmd.ExecuteNonQuery();

            }
            return RedirectToAction("Employee");
        }

       
        public ActionResult DeleteEmp(int id)
        {

            string connectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True";

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteEmployee", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                sqlCon.Open();
                cmd.ExecuteNonQuery();
            }  
                return RedirectToAction("Employee");
        }
        public ActionResult List(string Sorting_Order, string Filter_Value, string Search_Data, int? Page_No)

        {
            ViewBag.SortingName = String.IsNullOrEmpty(Sorting_Order) ? "Name" : "";
            ViewBag.SortingDate = Sorting_Order == "Name" ? "Email" : "Salary";

           if (Search_Data != null)
            {
                Page_No = 1;
            }
            else
            {
                Search_Data = Filter_Value;
            }

            ViewBag.Filter_Value = Search_Data;

           var employees = from Detail in db.Details select Detail;
            if (!String.IsNullOrEmpty(Search_Data))
            {

                employees = employees.Where(Detail => Detail.Name.ToUpper().Contains(Search_Data.ToUpper())
                        || Detail.Email.ToUpper().Contains(Search_Data.ToUpper()));
            }

            switch (Sorting_Order)
            {
                case "Name":
                    employees = employees.OrderByDescending(stu => stu.Name);
                    break;
                case "Email":
                    employees = employees.OrderBy(stu => stu.Email);
                    break;
                case "Salary":
                    employees = employees.OrderByDescending(stu => stu.Salary);
                    break;
                default:
                    employees = employees.OrderBy(stu => stu.Name);
                    break;
            }
            int Size_Of_Page = 4;
            int No_Of_Page = (Page_No ?? 1);
            return View(employees.ToPagedList(No_Of_Page, Size_Of_Page));
        }


        // GET: Home/Details/5
        public ActionResult Details(int id)
        {

            using (DbModelss db = new DbModelss())
            {
                return View(db.Details.Where(x => x.Id == id).FirstOrDefault());

            }
        }


        // GET: Home/Create
        public ActionResult AddList()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult AddList(Detail detail)
        {
            try
            {
                using (DbModelss db = new DbModelss())
                {
                    db.Details.Add(detail);
                    db.SaveChanges();
                }

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult EditList(int id)
        {
            using (DbModelss db = new DbModelss())
            {
                return View(db.Details.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult EditList(int id, Detail detail)
        {
            try
            {
                using (DbModelss db = new DbModelss())
                {
                    db.Entry(detail).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult DeleteList(int id)
        {
            using (DbModelss db = new DbModelss())
            {
                return View(db.Details.Where(x => x.Id == id).FirstOrDefault());
            }

        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult DeleteList(int id, FormCollection collection)
        {
            try
            {
                using (DbModelss db = new DbModelss())
                {
                    Detail detail = db.Details.Where(x => x.Id == id).FirstOrDefault();
                    db.Details.Remove(detail);
                    db.SaveChanges();
                }
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }









    }
}