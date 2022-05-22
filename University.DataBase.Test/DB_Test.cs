using System.Collections.Generic;
using System.Linq;
using University.Models;
using Xunit;

namespace University.DataBase.Test;

public class DB_Test
{
    [Fact]
    public void GetAllStudents_Test()
    {
        var expected = new List<Student>()
        {
            new()
            {
                Id = 1,

                PersonId = 1,
                FirstName = "anonim",
                LastName = "anonimus",

                FacultyId = 2,
                Faculty = "SoftDev"
            },
            new()
            {
                Id = 2,

                PersonId = 2,
                FirstName = "Andrey",
                LastName = "Starinin",

                FacultyId = 1,
                Faculty = "Design"
            }
        };
        
        var actual = DB.GetAllStudents().ToList();
        
        Assert.Equal(expected, actual);
    }
}