using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Dicti
    {
        public int Id { get; set; }
        public Dicti ParentId { get; set; }
        public string Fullname { get; set; }
        public string Constname { get; set; }
        public DateTime Updated { get; set; } = System.DateTime.Now;
        //public int UpdatedByForeignKey { get; set; }
        //public Subject UpdatedBy { get; set; }
        //public DateTime Created { get; set; }
        //public Subject CreatedBy { get; set; }
    }
}
