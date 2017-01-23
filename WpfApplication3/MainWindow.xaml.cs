using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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
//using WpfApplication1;


namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\Debug\wejscie1.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path);
            player.Play();
            string path1 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\Debug\odczytanyj.txt");
            string odczytany = File.ReadAllText(path1);
            if (odczytany == "nie")
            {
                MessageBox.Show("Odczytaj ostatni mecz!");
            }
        }

        private void ButtonLista_Click(object sender, RoutedEventArgs e)
        {
            Lista okno = new Lista();
            okno.ShowDialog();
        }

        private void button_zamknij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonWyjsciowySklad_Click(object sender, RoutedEventArgs e)
        {
            WyborUstawienia okno = new WyborUstawienia();
            okno.ShowDialog();
        }

        private void ButtonWyjsciowySklad_Copy_Click(object sender, RoutedEventArgs e)
        {
            string path1 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\Debug\odczytanyj.txt");
            string odczytany = File.ReadAllText(path1);
            if (odczytany == "tak")
            {
                MessageBox.Show("Ostatni mecz był juz uzupełniony");

            }
            else
            {
                OstatniMecz okno = new OstatniMecz();
                okno.ShowDialog();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //WpfApplication1.MainWindow okno = new WpfApplication1.MainWindow();
            //this.Close();
            //okno.ShowDialog();
        }
    }
}
