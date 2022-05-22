using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models;

public record Student
{
    public int Id { get; set; }
    
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public int FacultyId { get; set; }
    public string Faculty { get; set; }
}