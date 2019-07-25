using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace ONION.InfrastructureServices.Mappers
{
    public static class InfoTostudent
    {
        public static Student ToStudent(this Student_Info @this)
        {
            return new Student
            {
                Id = @this.Id,
                Name = @this.Name,
                Surname = @this.Surname
            };
        }
    }
}
