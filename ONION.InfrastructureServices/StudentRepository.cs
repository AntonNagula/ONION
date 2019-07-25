using System.Collections.Generic;
using System.Linq;
using ONION.Infrustructure.Interfaces;
using Models;
using ONION.InfrastructureServices.Mappers;
namespace ONION.InfrastructureServices
{
    public class StudentRepository:IStudentRepository
    {
        public List<Student_Info> data = new List<Student_Info>()
        {
            new Student_Info() { Id = 1, Name = "Денис", Surname = "Скриган",Group=772302},
            new Student_Info() { Id = 2, Name = "Александр", Surname = "Скриган",Group=772302},
            new Student_Info() { Id = 3, Name = "Арсений", Surname = "Скриган",Group=772302 },
            new Student_Info() { Id = 4, Name = "Виктория", Surname = "Скриган",Group=772302},
            new Student_Info() { Id = 5, Name = "Виктория", Surname = "Тишковская",Group=772302},
            new Student_Info() { Id = 6, Name = "Егор", Surname = "Семенов",Group=772302},
            new Student_Info() { Id = 7, Name = "Антон", Surname = "Нагула",Group=772302},
        };

        public IList<Student> GetStudents()
        {
            return data.Select(x => x.ToStudent()).ToList();
        }

        public Student_Info Getstudent_Info(int Id)
        {
            return data.FirstOrDefault(_ => _.Id == Id);
        }

        public Student Getstudent(int Id)
        {
            return data.FirstOrDefault(_=>_.Id==Id).ToStudent();
        }     
        
        public void Delete(int id)
        {
            var obj = data.FirstOrDefault(_ => _.Id == id);
            bool res = data.Remove(obj);
        }
        
        public void Create(Student_Info Item)
        {            
            data.Remove(Item);
            data.Add(Item);
        }

        public void Create_New(Student_Info Item)
        {            
            data.Add(Item);
        }

        public void Update(Student_Info Item)
        {
            var res = data.Find(x => x.Id == Item.Id);
            data.Remove(res);
            data.Add(Item);
            
        }

        public void Update_Info(int id,int group)
        {
            Student_Info res = data.Find(x => x.Id == id);
            Student_Info newstudent= new Student_Info() { Id=res.Id,Name=res.Name,Surname=res.Surname,Group=group};
            data.Remove(res);                   
            data.Add(newstudent);
        }

        public bool Exist(int id)
        {
            var res = data.Find(x => x.Id == id);
            if (res == null)
            {
                return false;
            }
            else
                return true;
        }
    }
}
