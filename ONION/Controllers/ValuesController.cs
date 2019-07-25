using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ONION.Models;
using Domain.Services;
using Models;
namespace ONION.Controllers
{
    [RoutePrefix("students")]
    public class ValuesController : ApiController
    {
        public readonly IStudentService students;
        public ValuesController(IStudentService service)
        {
            students = service;
        }
        
        [HttpGet,Route("")]
        public IEnumerable<Student> Get()
        {
            return students.GetStudents();
        }              

        [HttpGet,Route("{id}")]
        public Student Get(int id)
        {
            return students.Getstudent(id);
        }

        [HttpGet, Route("{id}/group")]
        public Student_Info Get_Info(int id)
        {
            return students.Getstudent_Info(id);
        } 

        [HttpPost, Route("{id}")]
        public IHttpActionResult Post(int id,[FromBody]Student_Info value)
        {
            students.Create(value);
            return Ok();
        }

        [HttpPut, Route("{id}")]
        public HttpResponseMessage Put(int id, [FromBody]Student_Info value)
        {
            bool result = students.Update(id,value);
            if (result)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
                return new HttpResponseMessage(HttpStatusCode.NotFound);
        }

        [HttpPut, Route("{id}/group")]
        public HttpResponseMessage Put_Info(int id, [FromBody]int value)
        {
            bool result = students.Update_Info(id, value);
            if (result)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
                return new HttpResponseMessage(HttpStatusCode.NotFound);
        }

        [HttpDelete, Route("{id}")]
        public HttpResponseMessage Delete(int id)
        {
            bool result=students.Delete(id);
            if(result)
            {
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            }
            else
                return new HttpResponseMessage(HttpStatusCode.NotFound);
        }
    }
}
