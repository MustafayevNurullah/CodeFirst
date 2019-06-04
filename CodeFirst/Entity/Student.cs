using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{ 
   public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Surname { get; set; }
        public int Mark { get; set; }
        public int GroupId { get; set; }
    }
}
