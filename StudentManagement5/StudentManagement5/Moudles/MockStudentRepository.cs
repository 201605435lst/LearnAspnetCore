using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement5.Moudles
{
  
    /// <summary>
    /// 模拟类
    /// </summary>
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _studentsList;
        /// <summary>
        /// 创建一个构造函数（ctor）
        /// </summary>
        public MockStudentRepository()
        {
            _studentsList = new List<Student>()
            {
                new Student(){Id=1,Name ="张三",ClassName=ClassNameEnum.FirstGrade,Email="Tony-zhang@52abp.com"},
                new Student(){Id=2,Name ="张四",ClassName=ClassNameEnum.SecondeGrade,Email="Tony-zhang@52abp.com"},
                new Student(){Id=3,Name ="张五",ClassName=ClassNameEnum.ThreeGrade,Email="Tony-zhang@52abp.com"},
            };
        }
        public Student add(Student student)
        {
            student.Id = _studentsList.Max(s => s.Id) + 1;
            _studentsList.Add(student);
            return student;
        }

        public Student Delete(int id)
        {
            Student student = _studentsList.FirstOrDefault(s=>s.Id==id);
            if(student != null)
            {
               _studentsList.Remove(student);
            }
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
           return _studentsList;
        }

        public Student GetStudent(int id)
        {
           return  _studentsList.FirstOrDefault(a => a.Id == id);
        }

        public Student Update(Student updateStudent)
        {
            Student student = _studentsList.FirstOrDefault(s => s.Id == updateStudent.Id);
            if(student != null)
            {
                student.Email = updateStudent.Email;
                student.ClassName = updateStudent.ClassName;
                student.Name = updateStudent.Name;

            }
            return student;
        }
    }
}
