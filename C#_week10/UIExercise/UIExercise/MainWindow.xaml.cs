using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UIExercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataService service = new DataService();
        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
            comboEnrolment.ItemsSource = Enum.GetValues(typeof(EnrolmentStatus));
        }

        /// <summary>
        /// This is called when the get students button is pressed.
        /// TODO: Update this button to load the students from the service and update the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetStudents_Click(object sender, RoutedEventArgs e) { updateList(); }
        private void updateList() {
            listStudents.Items.Clear();
            List<Student> students = service.GetStudents();
            students.ForEach(student => {
                listStudents.Items.Add(student);
            });
        }

        private void newStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student()
            {
                ID = counter++,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Enrolment = EnrolmentStatus.Pending
            };
//            listStudents.Items.Add(student);
            service.AddStudent(student);
            updateList();
        }

        /// <summary>
        /// This event is triggered when the user selects a student from the list.
        /// TODO: Update the controls to show the properties of the selected student.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student student = listStudents.SelectedItem as Student;
            if (student != null) {
                textBoxFirstName.Text = student.FirstName;
                textBoxLastName.Text = student.LastName;
                comboEnrolment.SelectedItem = student.Enrolment;
            }
        }

        /// <summary>
        /// This event triggers when the combo box selection is changed.
        /// TODO: It should update the selected students enrolment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboEnrolment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EnrolmentStatus? status = comboEnrolment.SelectedItem as EnrolmentStatus?;
            Student student = listStudents.SelectedItem as Student;
            if (student != null && status != null) {
                switch (status) {
                    case EnrolmentStatus.Enrolled:
                        student.EnrolStudent();
                        break;
                    case EnrolmentStatus.Withdrawn:
                        student.Withdraw();
                        break;
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            service.StoreData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateList();
        }
    }
}
