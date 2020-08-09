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
        /// <summary>
        /// 根据Id查询学生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Student GetStudent(int id);

        /// <summary>
        /// IEnumerable数据在内存中的对象，获取所有学生的信息
        /// </summary>
        IEnumerable<Student> GetAllStudents();
        /// <summary>
        /// 添加一名学生的信息
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        Student add(Student student);
        /// <summary>
        /// 更新一名学生信息
        /// </summary>
        /// <param name="updateStudent"></param>
        /// <returns></returns>
        Student Update(Student updateStudent);
        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Student Delete(int id);
    }
}
