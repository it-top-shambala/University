using System;
using System.Windows;
using System.Windows.Controls;
using University.Models;
using University.Wpf.Windows.Student;

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

    private void ButtonMore_OnClick(object sender, RoutedEventArgs e)
    {
        var id = Convert.ToInt32(LabelId.Content);
        new StudentWindow(id).Show();
    }
}