using System.Collections.Generic;
using Models;
namespace Domain.Services
{
    public interface IStudentService
    {
        IList<Student> GetStudents();
        Student_Info Getstudent_Info(int Id);
        Student Getstudent(int Id);
        bool Delete(int id);
        void Create(Student_Info Item);
        bool Update(int id,Student_Info Item);
        bool Update_Info(int id, int group);
    }
}
