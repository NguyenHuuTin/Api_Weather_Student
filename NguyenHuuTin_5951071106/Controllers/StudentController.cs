using NguyenHuuTin_5951071106.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenHuuTin_5951071106.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var StudentInfo = new StudentInfo
            {
                NameSchool = "Trường đại học giao thông vận tải phân hiệu tại thành phố Hồ Chí Minh",
                FullName = "Nguyễn Hữu Tin",
                MSSV = "5951071106",
                Class = "CQ.59.CNTT"
            };
            yield return StudentInfo;

        }

        // GET: api/Student/5
        public StudentInfo Get(string id)
        {
            return new StudentInfo
            {
                NameSchool = "Trường đại học giao thông vận tải phân hiệu tại thành phố Hồ Chí Minh",
                FullName = "Nguyễn Hữu Tin",
                MSSV = id,
                Class = "CQ.59.CNTT"
            };

        }


        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
