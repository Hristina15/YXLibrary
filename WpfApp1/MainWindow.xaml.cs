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
using YXLibrary;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Conus con = new Conus();

                con.H = double.Parse(heightTB.Text);
                con.h = int.Parse(heightMTB.Text);
                con.R = int.Parse(radiusTB.Text);
                con.r = int.Parse(radiusMTB.Text);

               
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
