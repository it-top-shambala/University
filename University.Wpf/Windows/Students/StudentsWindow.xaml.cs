using System.Windows;
using University.DataBase;
using University.Wpf.Components.StudentCard;

namespace University.Wpf.Windows.Students;

public partial class StudentsWindow : Window
{
    public StudentsWindow()
    {
        InitializeComponent();
        InitStudentsPanel();
    }

    private void InitStudentsPanel()
    {
        var students = DB.GetAllStudents();
        foreach (var student in students)
        {
            StudentsPanel.Children.Add(new StudentCard(student));
        }
    }
}