

namespace ConsoleApp.Entities
{
    public class Student
    {

        public int Id { get; set; } // Primary Key
        public string Name { get; set; } = string.Empty;
        public int EducationId { get; set; } // Foreign Key

        // You put foreign key in the many side of relationship.

        public Education? Education { get; set; } // Navigation Property.

        public override string ToString()
        {
            return $"Id: {Id} | Name: {Name}";
        }

        // string?
        // Question mark means either a string, or null. Relevant for database.
        // For example if ID is primary key, No question mark. If it can have no ID, then sure question mark
    }
}
