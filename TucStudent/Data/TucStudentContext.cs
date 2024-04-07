using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TucStudent;

namespace TucStudent.Data
{
    public class TucStudentContext : DbContext
    {
        public TucStudentContext (DbContextOptions<TucStudentContext> options)
            : base(options)
        {
        }

        public DbSet<TucStudent.StudentsApply> StudentsApply { get; set; } = default!;
    }
}
