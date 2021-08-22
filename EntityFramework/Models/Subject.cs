using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Subject : CommonFields
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Parentname { get; set; }
        public Dicti ClassType { get; set; }

    }
}
