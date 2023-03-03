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
using System.IO;

namespace PRGNyelvek
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

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            string neve = txtNev.Text;
            bool forditosE;
            int megjelenesEve = Convert.ToInt32(txtMegjelenes.Text);
            bool alacsaonySzintuE;
            int nepszeruseg2022 = Convert.ToInt32(sliNepszeruseg.Value);
            Nyelvcsaladok nyelvcsalad;

            if (rdoFordito.IsChecked == true)
            {
                forditosE = true;
            }
            else
            {
                forditosE = false;
            }

            if (rdoAlacsonySzintu.IsChecked == true)
            {
                alacsaonySzintuE = true;
            }
            else
            {
                alacsaonySzintuE = false;
            }

           // Nyelv nyelv = new Nyelv(neve, forditosE, megjelenesEve, alacsaonySzintuE, nepszeruseg2022, nyelvcsalad);
            StreamWriter streamWriter = new StreamWriter("nyelvek.txt", append:true);
        }
    }
}
