﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EnrollementApplication.Models
{
    public class EnrollementDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EnrollementDB() : base("name=EnrollementDB")
        {
            //Database.SetInitializer<EnrollementDB>(new DropCreateDatabaseIfModelChanges<EnrollementDB>());
        }

        public System.Data.Entity.DbSet<EnrollementApplication.Models.Enrollment> Enrollments { get; set; }

        public System.Data.Entity.DbSet<EnrollementApplication.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<EnrollementApplication.Models.Student> Students { get; set; }
    }
}
