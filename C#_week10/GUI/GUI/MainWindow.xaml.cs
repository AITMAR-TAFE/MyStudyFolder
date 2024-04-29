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

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonManager manager = new PersonManager(20);

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

        }

        private void Button_Load_People_Click(object sender, RoutedEventArgs e)
        {

            foreach (Person person in manager.GetPeople())
            {
                Listbox_People.Items.Add(person);
            }
     
        }
    }
}
