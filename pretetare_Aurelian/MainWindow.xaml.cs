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
using pretetare_Aurelian.Models;
using System.IO;



namespace pretetare_Aurelian
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Pasager> Pasageri { get; set; }
        public List<Ruta> Ruta { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            using (AppContext dbContext = new AppContext())
            {
                dbContext.DataBase.EnsureDeleted();
                dbContext.Database.EnsureCreated();
                dbContext.Ruta.AddRange(
                    new Ruta
                    {
                        Pasager = dbContext.Pasager.ToList()[0],
                        IDRuta = Guid.NewGuid().ToString(),
                        Destinatia = "Monaco",
                        Pret = 500,
                    });
                dbContext.SaveChanges();
                dbContext.Pasageri.AddRange(
                    new Pasager
                    {
                        ID = Guid.NewGuid().ToString(),
                        Nume = "Stanislav",
                        Prenume = "Oancea",
                        Telefon = "09878765"
                    });
                dbContext.SaveChanges();
                

            }
        }

        private void AddPasager_Click(object sender, RoutedEventArgs e)
        {

        }
        private void RemovePasager_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AddRuta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveRuta_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
