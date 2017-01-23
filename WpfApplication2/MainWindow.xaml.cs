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
using WpfApplication1;
using WpfApplication3;

namespace WpfApplication2
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            WpfApplication1.MainWindow okno = new WpfApplication1.MainWindow();
            this.Close();
            okno.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\Debug\wejscie1.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path);
            player.Play();
            WpfApplication3.MainWindow okno = new WpfApplication3.MainWindow();
            this.Close();
            okno.ShowDialog();
        }
    }
}
