using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement5.Moudles
{
    /// <summary>
    /// 创建一个服务类的接口IStudentRepository
    /// </summary>
    public interface IStudentRepository
    {
        Student GetStudent(int id);
        /// <summary>
        /// IEnumerable数据在内存中的对象
        /// </summary>
        IEnumerable<Student> GetAllStudents();
        Student add(Student student);
    }
}
