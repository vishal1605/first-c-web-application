using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using myfirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace myfirstMVC.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration Configuration;

        public HomeController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult AllData()
        {
            string connString = this.Configuration.GetConnectionString("DefaultConnection");
            List<User> users = new List<User>();
            string sql = "select * from TBLUSER";

            SqlConnection con = new SqlConnection(connString);
            users = con.Query<User>(sql).ToList();
            return View(users);
        }

        [HttpPost]
        public JsonResult Insert([FromBody] User u)
        {


            string query = "insert into tbluser(email,name,psw) values(@email,@name,@psw)";
            //string sql = $"insert into tbluser(email,name,psw) values('{u.Email}','{u.Name}','{u.Password}')";
            SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("DefaultConnection"));
            int row = con.Execute(query, u);

            string getId = "select u_id from tbluser where email=@email and name=@name and psw=@psw";
            int id = con.QueryFirstOrDefault<int>(getId, u);
            return Json(id);

        }

        public JsonResult Delete(int id)
        {
            Console.WriteLine(id);
            string query = "delete from tbluser where u_id=@u_id";
            SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("DefaultConnection"));
            con.Execute(query, new { U_id = id });
            return Json("Deleted");
        }

        //public IActionResult EditProcess(int id)
        //{
        //    Console.WriteLine(id);
        //    string query = "select * from tbluser where u_id=@u_id";
        //    SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("DefaultConnection"));
        //    dynamic u=con.QuerySingleOrDefault<User>(query, new { U_id = id });//Error
        //    Console.WriteLine(u+" Variable");
        //    return View(u);
        //}

        [HttpPost]
        public JsonResult Update(User u)
        {

            string query = "update tbluser set email=@email, name=@name, psw=@psw where u_id = @u_id";
            SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("DefaultConnection"));
            con.Execute(query, u);


            return Json("Success");
        }



    }
}
