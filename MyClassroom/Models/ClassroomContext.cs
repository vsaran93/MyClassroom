using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyClassroom.Models
{
    public class ClassroomContext: DbContext
    {
        public ClassroomContext (DbContextOptions options)
            :base(options) 
        { 
        }

        public DbSet<User> Users { get; set; }
    }
}
