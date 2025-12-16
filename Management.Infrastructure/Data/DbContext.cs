using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management.Domain.Models;

namespace Management.Infrastructure.Data
{
    public class DbContext
    {
        public Student[] Students { get; set; }
    }
}
