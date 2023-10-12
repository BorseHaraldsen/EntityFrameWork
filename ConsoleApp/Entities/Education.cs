using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Entities
{
    public class Education
    {
        // Need to be single entity, since each class should only handle one instance. Aka. one student, not students4
        public int Id { get; set; } // Primary Key.
        public string Name { get; set; } = string.Empty;

        public ICollection<Student>? Students { get; set; } // Navigation Property. 

        public override string ToString()
        {
            return $"Id: {Id} | Name: {Name}";
        }
    }
}
