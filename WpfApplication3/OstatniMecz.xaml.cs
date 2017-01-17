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
using System.IO;
using System.Collections.ObjectModel;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for OstatniMecz.xaml
    /// </summary>
    public partial class OstatniMecz : Window
    {
        ListaZawodnikow z;
        ObservableCollection<zawodnik> sklad;
        public OstatniMecz()
        {
            InitializeComponent();
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\Debug\skladj.txt");
            ListaZawodnikow ostatni = new ListaZawodnikow();
            List<List<string>> punkty = new List<List<string>>();
            string[] linie = File.ReadAllLines(path);

            zawodnik[] zw = new zawodnik[linie.Length];
            for (int i = 0; i < linie.Length; ++i)
            {
                punkty.Add(new List<string>());
                foreach (string slowo in linie[i].Split(' '))
                {
                    punkty[i].Add(slowo);
                }
            }
            textBoximie1.Text = punkty[0][0];
            textBoxnazwisko1.Text = punkty[0][1];
            textBoximie2.Text = punkty[1][0];
            textBoxnazwisko2.Text = punkty[1][1];
            textBoximie3.Text = punkty[2][0];
            textBoxnazwisko3.Text = punkty[2][1];
            textBoximie4.Text = punkty[3][0];
            textBoxnazwisko4.Text = punkty[3][1];
            textBoximie5.Text = punkty[4][0];
            textBoxnazwisko5.Text = punkty[4][1];
            textBoximie6.Text = punkty[5][0];
            textBoxnazwisko6.Text = punkty[5][1];
            textBoximie7.Text = punkty[6][0];
            textBoxnazwisko7.Text = punkty[6][1];
            textBoximie8.Text = punkty[7][0];
            textBoxnazwisko8.Text = punkty[7][1];
            textBoximie9.Text = punkty[8][0];
            textBoxnazwisko9.Text = punkty[8][1];
            textBoximie10.Text = punkty[9][0];
            textBoxnazwisko10.Text = punkty[9][1];
            textBoximie11.Text = punkty[10][0];
            textBoxnazwisko11.Text = punkty[10][1];
            textBoximie12.Text = punkty[11][0];
            textBoxnazwisko12.Text = punkty[11][1];
            textBoximie13.Text = punkty[12][0];
            textBoxnazwisko13.Text = punkty[12][1];
            textBoximie14.Text = punkty[13][0];
            textBoxnazwisko14.Text = punkty[13][1];
            textBoximie15.Text = punkty[14][0];
            textBoxnazwisko15.Text = punkty[14][1];
            textBoximie16.Text = punkty[15][0];
            textBoxnazwisko16.Text = punkty[15][1];
            textBoximie17.Text = punkty[16][0];
            textBoxnazwisko17.Text = punkty[16][1];
        }



        private void buttonZaiwterdz_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            z = ListaZawodnikow1.OdczytajTXT();
            sklad = new ObservableCollection<zawodnik>(z.lista);
            foreach (zawodnik k in sklad)
            {
                if(k.Imie == textBoximie1.Text & k.Nazwisko == textBoxnazwisko1.Text)
                {
                   k.Minuty = k.Minuty + Convert.ToInt32(textBoxCzas1.Text);
                   k.Gole += Convert.ToInt32(textBoxGole1.Text);
                   k.Asysty += Convert.ToInt32(textBoxAsysty1.Text);
                }
                if (k.Imie == textBoximie2.Text & k.Nazwisko == textBoxnazwisko2.Text)
                {
                    k.Minuty = k.Minuty + Convert.ToInt32(textBoxCzas2.Text);
                    k.Gole += Convert.ToInt32(textBoxGole2.Text);
                    k.Asysty += Convert.ToInt32(textBoxAsysty2.Text);
                }
                if (k.Imie == textBoximie3.Text & k.Nazwisko == textBoxnazwisko3.Text)
                {
                    k.Minuty = k.Minuty + Convert.ToInt32(textBoxCzas3.Text);
                    k.Gole += Convert.ToInt32(textBoxGole3.Text);
                    k.Asysty += Convert.ToInt32(textBoxAsysty3.Text);
                }
                if (k.Imie == textBoximie4.Text & k.Nazwisko == textBoxnazwisko4.Text)
                {
                    k.Minuty = k.Minuty + Convert.ToInt32(textBoxCzas4.Text);
                    k.Gole += Convert.ToInt32(textBoxGole4.Text);
                    k.Asysty += Convert.ToInt32(textBoxAsysty4.Text);
                }
                if (k.Imie == textBoximie5.Text & k.Nazwisko == textBoxnazwisko5.Text)
                {
                    k.Minuty = k.Minuty + Convert.ToInt32(textBoxCzas5.Text);
                    k.Gole += Convert.ToInt32(textBoxGole5.Text);
                    k.Asysty += Convert.ToInt32(textBoxAsysty5.Text);
                }
                if (k.Imie == textBoximie6.Text & k.Nazwisko == textBoxnazwisko6.Text)
                {
                    k.Minuty = k.Minuty + Convert.ToInt32(textBoxCzas6.Text);
                    k.Gole += Convert.ToInt32(textBoxGole6.Text);
                    k.Asysty += Convert.ToInt32(textBoxAsysty6.Text);
                }
                if (k.Imie == textBoximie7.Text & k.Nazwisko == textBoxnazwisko7.Text)
                {
                    k.Minuty = k.Minuty + Convert.ToInt32(textBoxCzas7.Text);
                    k.Gole += Convert.ToInt32(textBoxGole7.Text);
                    k.Asysty += Convert.ToInt32(textBoxAsysty7.Text);
                }
                if (k.Imie == textBoximie8.Text & k.Nazwisko == textBoxnazwisko8.Text)
                {
                    k.Minuty = k.Minuty + Convert.ToInt32(textBoxCzas8.Text);
                    k.Gole += Convert.ToInt32(textBoxGole8.Text);
                    k.Asysty += Convert.ToInt32(textBoxAsysty8.Text);
                }
                if (k.Imie == textBoximie9.Text & k.Nazwisko == textBoxnazwisko9.Text)
                {
                    k.Minuty = k.Minuty + Convert.ToInt32(textBoxCzas9.Text);
                    k.Gole += Convert.ToInt32(textBoxGole9.Text);
                    k.Asysty += Convert.ToInt32(textBoxAsysty9.Text);
                }
                if (k.Imie == textBoximie10.Text & k.Nazwisko == textBoxnazwisko10.Text)
                {
                    k.Minuty = k.Minuty + Convert.ToInt32(textBoxCzas10.Text);
                    k.Gole += Convert.ToInt32(textBoxGole10.Text);
                    k.Asysty += Convert.ToInt32(textBoxAsysty10.Text);
                }
                if (k.Imie == textBoximie11.Text & k.Nazwisko == textBoxnazwisko11.Text)
                {
                    k.Minuty = k.Minuty + Convert.ToInt32(textBoxCzas11.Text);
                    k.Gole += Convert.ToInt32(textBoxGole11.Text);
                    k.Asysty += Convert.ToInt32(textBoxAsysty11.Text);
                }
            }

            FileStream plik = new FileStream(@"..\Debug\zawodnicyj.txt", FileMode.Create);
            StreamWriter SW = new StreamWriter(plik);

            foreach (zawodnik zaw in z.lista)
            {
                SW.WriteLine(zaw.Imie + " " + zaw.Nazwisko + " " + zaw.Pozycja + " " + zaw.Minuty + " " + zaw.Gole + " " + zaw.Asysty + " " + zaw.Odbiory + " " + zaw.Obrony);
            }
            SW.Close();

            this.Close();
        }
    }
}
