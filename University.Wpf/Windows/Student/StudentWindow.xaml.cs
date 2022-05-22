using System.Windows;
using University.DataBase;
using University.Wpf.Components.InputElement;

namespace University.Wpf.Windows.Student;

public partial class StudentWindow : Window
{
    private Models.Student _student;
    
    public StudentWindow(int id)
    {
        _student = DB.GetStudent(id);

        InitializeComponent();
        
        InitInputElements();
    }

    private void InitInputElements()
    {
        Panel.Children.Add(new Input("Last name", _student.LastName));
        Panel.Children.Add(new Input("First name", _student.FirstName));
        Panel.Children.Add(new Input ("Faculty", _student.Faculty));
    }
}