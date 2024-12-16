using DataBinding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Xml.Linq;

namespace DataGrid
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private string plik1 = @"..\..\data\Produkty.xml";
        // Plik źródłowy
        private string plik2 = @"..\..\data\Produkty2.xml"; // Plik wynikowy
        private XElement wykazProduktow;

        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }
        private void PrzygotujWiazanie()
        {
            if (File.Exists(plik1))
                wykazProduktow = XElement.Load(plik1); //Załadowanie danych z pliku

            gridProdukty.DataContext = wykazProduktow;

            ObservableCollection<string> ListaMagazynow = new ObservableCollection<string>() { "Katowice 1", "Katowice 2", "Gliwice 1" };
            nazwaMagazynu.ItemsSource = ListaMagazynow;
        }
        private void btnZapisz_Click(object sender, RoutedEventArgs e)
        {
            wykazProduktow.Save(plik2); //Zapisanie danych do pliku wynikowego MessageBox.Show("Pomyślnie zapisano dane do pliku");
        }
    }
}
