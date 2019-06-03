namespace CodeFirst
{
    using CodeFirst.Entity;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentDb : DbContext
    {
        // Your context has been configured to use a 'StudentDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirst.StudentDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentDb' 
        // connection string in the application configuration file.
        public StudentDb()
            : base("name=StudentDb")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Student> Students { get; set; } 
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}