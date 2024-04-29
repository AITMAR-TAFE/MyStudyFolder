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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        PersonManager manager = new PersonManager(20);

        public static int counter = 2;
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 150; i <= 210; i++)
            {
                Combo_Height.Items.Add(i);
            }

        }

        private void Button_Add_Person_Click(object sender, RoutedEventArgs e)
        {
            
            double height = 0;
            double.TryParse(Combo_Height.Text, out height);

            DateTime dateTime = DateTime.Parse(Datepicker_DateOfBirth.Text);

            if (counter != 20)  
            {
                Person newPerson = new Person(counter, Textbox_FirstName.Text, Textbox_LastName.Text, dateTime, height);
                ++counter;
                manager.Add(newPerson);
            }

            else MessageBox.Show("Maximum amount of persons added.");

            Listbox_People.Items.Clear();
            Button_Load_People_Click(sender, e);

        }

        private void Button_Remove_Person_Click(Object sender, RoutedEventArgs e)
        {
            string selecteditem = Listbox_People.SelectedItem.ToString();
            MessageBox.Show("You have removed " +selecteditem+" from the list.");


            Person newPerson = (Person)Listbox_People.SelectedItem;

            manager.Remove(newPerson);
            

            Listbox_People.Items.Clear();
            Button_Load_People_Click(sender, e);

        }

        public void Button_Load_People_Click(object sender, RoutedEventArgs e)
        {
            Listbox_People.Items.Clear();
            foreach (Person person in manager.GetPeople())
            {
                Listbox_People.Items.Add(person);
            }
     
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            manager.StoreData();
        }
    }
}
