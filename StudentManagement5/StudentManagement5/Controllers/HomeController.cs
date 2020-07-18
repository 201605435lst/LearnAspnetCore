using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagement5.Moudles;
using StudentManagement5.ViewModel;

namespace StudentManagement5.Controllers
{
    /// <summary>
    /// 这是标记语法
    /// </summary>
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        // 使用构造函数注入的方式注入ISIStudentRepository
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        //[Route("")]
        //[Route("~/")]
        //[Route("~/home")]
        public IActionResult Index()
        {

            IEnumerable<Student> students = _studentRepository.GetAllStudents();
            // 返回学生的名字
            return View(students);
            //return Json(new { id="1" ,name="张三"});
        }
        //public JsonResult Details()
        //{
        //    Student model = _studentRepository.GetStudent(1);
        //    // 返回学生的名字
        //    return Json(model);
        //    //return _studentRepository.GetStudent(1).Name;
        //    //return Json(new { id="1" ,name="张三"});
        //}
        //[Route("{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Student = _studentRepository.GetStudent(id ?? 1),
                PageTitle = "学生详情信息"
            };
            return View(homeDetailsViewModel);


            //Student model = _studentRepository.GetStudent(1);
            //将PageTitle和Student模型对象存储在VIewBag
            //我们正在使用动态属性PageTitle和Student
            //ViewBag.PageTitle = "学生详情信息";
            //ViewBag.Student = model;
            //return View(model);
            // 返回学生的名字
            //return View(model);
            //return View("Test");
            // ViewData的使用
            //ViewData["PageTitle"] = "学生详情";
            //ViewData["Student"] = model;
            //return View();
            //ViewBag的使用


        }
        // 创建添加学生的视图
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                Student newStudent = _studentRepository.add(student);
             //   return RedirectToAction("Details", new { id = newStudent.Id });
            //
            }
            return View();

        }
    }
}
