using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WEB_APP.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public HttpResponseMessage Get()
        {
            string Query = @"select Department_id,Department_name from dbo.Department";

            DataTable dataTable = new DataTable();
        }
    }
}