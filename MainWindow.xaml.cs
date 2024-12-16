using DataBinding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataGrid
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private ObservableCollection<Produkt> ListaProduktow = null;
        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();

        }
        private void PrzygotujWiazanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("01-11", "ołówek", 8, "Katowice 1", new Uri(@"pack://application:,,,/Zdjecia/olowek.jpg"), "Opis 1"));
            ListaProduktow.Add(new Produkt("PW-20", "pióro wieczne", 75, "Katowice 2", new Uri(@"pack://application:,,,/Zdjecia/pioro.jpg"), "Opis 2"));
            ListaProduktow.Add(new Produkt("DZ-10", "długopis żelowy", 1121, "Katowice 1", new Uri(@"pack://application:,,,/Zdjecia/dlugopis.jpg"), "Opis 3"));
            ListaProduktow.Add(new Produkt("DZ-12", "długopis kulkowy", 280, "Katowice 2", new Uri(@"pack://application:,,,/Zdjecia/dlugopis.jpg"), "Opis 4"));
            gridProdukty.ItemsSource = ListaProduktow;


            ObservableCollection<string> ListaMagazynow = new ObservableCollection<string>() { "Katowice 1", "Katowice 2", "Gliwice 1" };
            nazwaMagazynu.ItemsSource = ListaMagazynow;
        }


        private void btnZdjecie_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Title = "Wybierz zdjęcie";
            dialog.Filter = "Image files (*.jpg,*.png;*.jpeg)|*.jpg;*.png;*.jpeg|A11 files (*.*)|*.*";
            dialog.InitialDirectory = @"C:\temp\";
            if (dialog.ShowDialog() == true)
            {
                (gridProdukty.SelectedItem as Produkt).Zdjecie = new Uri(dialog.FileName);
                gridProdukty.CommitEdit(DataGridEditingUnit.Cell, true);
                gridProdukty.CommitEdit();
                CollectionViewSource.GetDefaultView(gridProdukty.
                ItemsSource).Refresh();
            }
        }
    }
}
