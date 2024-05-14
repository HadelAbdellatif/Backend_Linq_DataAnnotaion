using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationTask.Model
{
    internal class Department
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; }
    }
}
