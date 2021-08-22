using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Dicti : CommonFields
    {
        public int Id { get; set; }
        public Dicti ParentId { get; set; }
        public string Fullname { get; set; }
        public string Constname { get; set; }
    }
}
