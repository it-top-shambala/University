using System.Windows.Controls;
using University.Models;

namespace University.Wpf.Components.StudentCard;

public partial class StudentCard : UserControl
{
    public StudentCard(Student student)
    {
        InitializeComponent();

        LabelId.Content = student.Id.ToString();
        LabelName.Content = $"{student.LastName} {student.FirstName}";
        LabelFaculty.Content = student.Faculty;
    }
}