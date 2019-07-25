using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Services;
using ONION.Infrustructure.Interfaces;
using Models;
namespace ONION.Domain.Services
{
    public class StudentService: IStudentService
    {
        public readonly IStudentRepository _studentRepository;        

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        
        public IList<Student> GetStudents()
        {
            return _studentRepository.GetStudents();
        }

        public Student_Info Getstudent_Info(int Id)
        {
            return _studentRepository.Getstudent_Info(Id);
        }

        public Student Getstudent(int Id)
        {
            return _studentRepository.Getstudent(Id);
        }

        public bool Delete(int id)
        {            
            bool res = _studentRepository.Exist(id);
            if (res == false)
            {
                return res;
            }
            else
            {
                _studentRepository.Delete(id);
            }
            return res;
        }

        public void Create(Student_Info Item)
        {
            bool res = _studentRepository.Exist(Item.Id);
            if(res==true)
            {
                _studentRepository.Create(Item);
            }
            else
            {
                _studentRepository.Create_New(Item);
            }
        }

        public bool Update(int id,Student_Info Item)
        {
            bool res = _studentRepository.Exist(id);
            if (res == true)
            {
                _studentRepository.Update(Item);
                return res;
            }
            else
            {
                return res;
            }

        }

        public bool Update_Info(int id, int group)
        {
            bool res = _studentRepository.Exist(id);
            if (res == true)
            {
                _studentRepository.Update_Info(id,group);
                return res;
            }
            else
            {
                return res;
            }
        }        
    }
}
