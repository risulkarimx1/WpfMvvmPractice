using System.Collections.Generic;
using System.Windows;

namespace WpfDempTimCorey
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> _people;
        public MainWindow()
        {
            InitializeComponent();
            _people = new List<Person>()
            {
                new Person {FirstName = "Risul", LastName = "Karim"},
                new Person {FirstName = "Rafia", LastName = "Anjum"}
            };

            MyComboBox.ItemsSource = _people;
        }

        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {FirstNameText.Text}");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
