using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace StudentManagement5.Moudles
{
 /// <summary>
 /// 学生模型信息
 /// </summary>
    public class Student
    {
      
        public int Id { get; set; }
        [Display(Name = "姓名")]
        [Required(ErrorMessage ="请输入名字"),MaxLength(50,ErrorMessage ="名字的长度不能超过50个字符")]
        public String Name { get; set; }
        [Display(Name = "班级名称")]
        [Required]
        public ClassNameEnum? ClassName { get; set; }
        [Display(Name = "邮箱地址")]
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$",ErrorMessage ="输入的邮箱格式不正确")]
        public String Email { get; set; }


    }
  
}
