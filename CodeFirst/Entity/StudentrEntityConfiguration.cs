using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
   public class StudentrEntityConfiguration:EntityTypeConfiguration<Student>
    {

     public StudentrEntityConfiguration()
        {

            this.ToTable("KeleStudent");
        }

    }
}
