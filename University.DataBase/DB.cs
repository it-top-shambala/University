using Dapper;
using MySql.Data.MySqlClient;
using University.Models;

namespace University.DataBase;

public static class DB
{
    private static string _conn = File.ReadAllText("db_config.txt");
    
    public static IEnumerable<Student> GetAllStudents()
    {
        Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        
        using var db = new MySqlConnection(_conn);
        db.Open();
        var sql = "SELECT tab_students.id AS 'id', person_id, first_name, last_name, faculty_id, faculty FROM tab_students JOIN tab_persons ON tab_persons.id = tab_students.person_id JOIN tab_faculties ON tab_faculties.id = tab_students.faculty_id;";
        var students = db.Query<Student>(sql);
        return students;
    }
}