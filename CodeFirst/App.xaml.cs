using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace CodeFirst
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private App()
        {
            using (StudentDb db=new StudentDb() )
            {
                CodeFirst.Entity.Group group = new Entity.Group()
                {
                    Name = "896A2"

                };
                CodeFirst.Entity.Student student = new Entity.Student()
                {
                    Name = "Nurullah",
                    Surname = "Mustafayev",
                    Mark = 10,
                };
                db.Students.Add(student);
                db.Groups.Add(group);
                db.SaveChanges();
            }
        }
    }
}
