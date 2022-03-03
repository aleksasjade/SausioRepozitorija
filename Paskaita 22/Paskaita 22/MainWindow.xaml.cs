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

namespace Paskaita_22
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

        private void Skaiciuoti(object sender, RoutedEventArgs e)
        {
            double plotis = Convert.ToDouble(KambarioPlotis.Text);
            double ilgis = Convert.ToDouble(KambarioIlgis.Text);

            Kambarys kambarys = new Kambarys(plotis, ilgis);
            double plotas = kambarys.GautiPloti();
            Plotas.Text = plotas.ToString();
        }
    }
}
