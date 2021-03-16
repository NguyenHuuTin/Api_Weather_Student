using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NguyenHuuTin_5951071106.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "nameschool")]
        public string NameSchool { get; set; }
        [DataMember(Name = "fullname")]
        public string FullName { get; set; }
        [DataMember(Name = "mssv")]
        public string MSSV { get; set; }
        [DataMember(Name = "class")]
        public string Class { get; set; }

    }

}