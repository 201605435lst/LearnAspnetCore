using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagement5.Controllers
{
    public class DepartmentController : Controller
    {
        public string List()
        {
            return "DepartmentsController中的List()方法";
        }
           public string Details()
        {
            return "DepartmentsController中的Details()方法";
        }
    }
}
