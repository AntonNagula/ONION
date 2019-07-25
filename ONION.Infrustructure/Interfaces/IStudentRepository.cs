using System.Collections.Generic;
using Models;
namespace ONION.Infrustructure.Interfaces
{
    public interface IStudentRepository
    {
        IList<Student> GetStudents();
        Student_Info Getstudent_Info(int Id);
        Student Getstudent(int Id);
        void Delete(int id);
        void Create(Student_Info Item);
        void Create_New(Student_Info Item);
        void Update(Student_Info Item);
        void Update_Info(int id, int group);
        bool Exist(int id);
    }
}
