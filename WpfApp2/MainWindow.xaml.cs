using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime datum = Datum.SelectedDate.Value.Date;
            DateTime dnes = DateTime.Today;
            TimeSpan cau = dnes - datum ;
            int ano = cau.Days / 365;
            if (Meno.Text == " ")
            {
                MessageBox.Show("Zadajte meno");

            }
            else if (Priezvisko.Text == " ")
            {
                MessageBox.Show("Zadajte priezvisko");
            }
            else if (Datum.Text == " ")
            {
                MessageBox.Show("Zadajte vek");
            }
            else
            {
                MessageBox.Show("Ahoj" + " " + Meno.Text +" " +  Priezvisko.Text + " " + "máš" + " " + ano + "rokov");
            }
           
        }

        private void Priezvisko_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }   }