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
        public RedirectResult Insert(User u)
        {
            
            
            string query = "insert into tbluser(email,name,psw) values(@email,@name,@psw)";
            //string sql = $"insert into tbluser(email,name,psw) values('{u.Email}','{u.Name}','{u.Password}')";
            SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("DefaultConnection"));
            int row = con.Execute(query, u);
            return Redirect("/");

        }

        public RedirectResult Delete(int id)
        {
            Console.WriteLine(id);
            string query = "delete from tbluser where u_id=@u_id";
            SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("DefaultConnection"));
            con.Execute(query, new { U_id = id });
            return Redirect("/Home/AllData");
        }

        public IActionResult EditProcess(int id)
        {
            Console.WriteLine(id);
            string query = "select * from tbluser where u_id=@u_id";
            SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("DefaultConnection"));
            User u = (User)con.Query<User>(query, new { U_id = id });//Error
            return View(u);
        }

        [HttpPost]
        public RedirectResult Update(User u)
        {

            string query = "update tbluser set email=@email, name=@name, psw=@psw where u_id = @u_id";
            SqlConnection con = new SqlConnection(this.Configuration.GetConnectionString("DefaultConnection"));
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@name", u.Name);
            cmd.Parameters.AddWithValue("@psw", u.Psw);
            cmd.Parameters.AddWithValue("@u_id", (int)u.U_id);
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("Row affected " + u.Name);
            con.Close();
            return Redirect("/Home/AllData");
        }



    }
}
