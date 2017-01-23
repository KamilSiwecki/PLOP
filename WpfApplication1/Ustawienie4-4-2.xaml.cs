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
using System.Windows.Shapes;
using baza;
using System.Collections.ObjectModel;
using System.IO;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Ustawienie4_4_2.xaml
    /// </summary>
    public partial class Ustawienie4_4_2 : Window
    {
        ListaZawodnikow z;
        ObservableCollection<zawodnik> sklad;
        public Ustawienie4_4_2()
        {
            InitializeComponent();
            z = ListaZawodnikow.OdczytajTXT();
            sklad = new ObservableCollection<zawodnik>(z.lista);
            foreach (zawodnik i in sklad)
            {
                if(i.Pozycja=="Napastnik")
                {
                    comboBox0.Items.Add(i);
                    comboBox1.Items.Add(i);
                }
                if(i.Pozycja=="Pomocnik")
                {
                    comboBox2.Items.Add(i);
                    comboBox3.Items.Add(i);
                    comboBox4.Items.Add(i);
                    comboBox5.Items.Add(i);
                }
                if(i.Pozycja=="Obronca")
                {
                    comboBox6.Items.Add(i);
                    comboBox7.Items.Add(i);
                    comboBox8.Items.Add(i);
                    comboBox9.Items.Add(i);
                }
                if(i.Pozycja=="Bramkarz")
                {
                    comboBox10.Items.Add(i);
                }
                comboBox11.Items.Add(i);
                comboBox12.Items.Add(i);
                comboBox13.Items.Add(i);
                comboBox14.Items.Add(i);
                comboBox15.Items.Add(i);
                comboBox16.Items.Add(i);

            }
            
        }

        private void buttonZatwierdz_Click(object sender, RoutedEventArgs e)
        {
            if(comboBox0.Text != comboBox1.Text & comboBox2.Text != comboBox3.Text & comboBox2.Text != comboBox4.Text & comboBox2.Text != comboBox5.Text & comboBox3.Text != comboBox4.Text & comboBox3.Text != comboBox5.Text & comboBox4.Text != comboBox5.Text
                & comboBox6.Text != comboBox7.Text & comboBox6.Text != comboBox8.Text & comboBox6.Text != comboBox9.Text & comboBox7.Text != comboBox8.Text & comboBox7.Text != comboBox9.Text & comboBox8.Text != comboBox9.Text
                & comboBox11.Text != comboBox0.Text & comboBox11.Text != comboBox1.Text & comboBox11.Text != comboBox2.Text & comboBox11.Text != comboBox3.Text & comboBox11.Text != comboBox4.Text & comboBox11.Text != comboBox5.Text
                & comboBox11.Text != comboBox6.Text & comboBox11.Text != comboBox7.Text & comboBox11.Text != comboBox8.Text & comboBox11.Text != comboBox9.Text & comboBox11.Text != comboBox10.Text & comboBox11.Text != comboBox12.Text
                & comboBox11.Text != comboBox13.Text & comboBox11.Text != comboBox14.Text & comboBox11.Text != comboBox15.Text & comboBox11.Text != comboBox16.Text & comboBox12.Text != comboBox1.Text & comboBox12.Text != comboBox2.Text
                & comboBox12.Text != comboBox3.Text & comboBox12.Text != comboBox4.Text & comboBox12.Text != comboBox5.Text & comboBox12.Text != comboBox6.Text & comboBox12.Text != comboBox7.Text & comboBox12.Text != comboBox8.Text
                & comboBox12.Text != comboBox9.Text & comboBox12.Text != comboBox10.Text & comboBox12.Text != comboBox13.Text & comboBox12.Text != comboBox14.Text & comboBox12.Text != comboBox15.Text & comboBox12.Text != comboBox16.Text
                & comboBox13.Text != comboBox1.Text & comboBox13.Text != comboBox2.Text & comboBox13.Text != comboBox3.Text & comboBox13.Text != comboBox4.Text & comboBox13.Text != comboBox5.Text & comboBox13.Text != comboBox6.Text
                & comboBox13.Text != comboBox7.Text & comboBox13.Text != comboBox8.Text & comboBox13.Text != comboBox8.Text & comboBox13.Text != comboBox10.Text & comboBox13.Text != comboBox14.Text & comboBox13.Text != comboBox15.Text
                & comboBox13.Text != comboBox16.Text & comboBox14.Text != comboBox1.Text & comboBox14.Text != comboBox2.Text & comboBox14.Text != comboBox3.Text & comboBox14.Text != comboBox4.Text & comboBox14.Text != comboBox5.Text
                & comboBox14.Text != comboBox6.Text & comboBox14.Text != comboBox7.Text & comboBox14.Text != comboBox8.Text & comboBox14.Text != comboBox9.Text & comboBox14.Text != comboBox10.Text & comboBox14.Text != comboBox15.Text
                & comboBox14.Text != comboBox16.Text & comboBox15.Text != comboBox1.Text & comboBox15.Text != comboBox2.Text & comboBox15.Text != comboBox3.Text & comboBox15.Text != comboBox4.Text & comboBox15.Text != comboBox5.Text
                & comboBox15.Text != comboBox6.Text & comboBox15.Text != comboBox7.Text & comboBox15.Text != comboBox8.Text & comboBox15.Text != comboBox9.Text & comboBox15.Text != comboBox10.Text & comboBox15.Text != comboBox16.Text
                & comboBox16.Text != comboBox1.Text & comboBox16.Text != comboBox2.Text & comboBox16.Text != comboBox3.Text & comboBox16.Text != comboBox4.Text & comboBox16.Text != comboBox5.Text & comboBox16.Text != comboBox6.Text
                & comboBox16.Text != comboBox7.Text & comboBox16.Text != comboBox8.Text & comboBox16.Text != comboBox9.Text & comboBox16.Text != comboBox10.Text & comboBox1.Text != null & comboBox2.Text != null & comboBox3.Text != null
                & comboBox4.Text != null & comboBox5.Text != null & comboBox6.Text != null & comboBox7.Text != null & comboBox8.Text != null & comboBox9.Text != null & comboBox10.Text != null & comboBox11.Text != null & comboBox12.Text != null
                & comboBox13.Text != null & comboBox14.Text != null & comboBox15.Text != null & comboBox16.Text != null & comboBox0.Text != comboBox11.Text & comboBox0.Text != comboBox12.Text & comboBox0.Text != comboBox13.Text
                & comboBox0.Text != comboBox14.Text & comboBox0.Text != comboBox15.Text & comboBox0.Text != comboBox16.Text)
                {
                    string[] tekst = new string[17];
                    tekst[0] = comboBox0.Text;
                    tekst[1] = comboBox1.Text;
                    tekst[2] = comboBox2.Text;
                    tekst[3] = comboBox3.Text;
                    tekst[4] = comboBox4.Text;
                    tekst[5] = comboBox5.Text;
                    tekst[6] = comboBox6.Text;
                    tekst[7] = comboBox7.Text;
                    tekst[8] = comboBox8.Text;
                    tekst[9] = comboBox9.Text;
                    tekst[10] = comboBox10.Text;
                    tekst[11] = comboBox11.Text;
                    tekst[12] = comboBox12.Text;
                    tekst[13] = comboBox13.Text;
                    tekst[14] = comboBox14.Text;
                    tekst[15] = comboBox15.Text;
                    tekst[16] = comboBox16.Text;
                    System.IO.File.WriteAllLines(@"..\Debug\sklad.txt", tekst);
                    string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\Debug\odczytany.txt");
                    FileStream plik = new FileStream(path, FileMode.Create);
                    StreamWriter SW = new StreamWriter(plik);
                    SW.WriteLine("nie");
                    SW.Close();
                this.Close();
                }
                else
                {
                    MessageBox.Show("Nie wybrales zawodnikow lub wybrales takich samych!\nWybierz sklad ponownie");
                    this.Close();
                }
            
            
        }
    }
}
