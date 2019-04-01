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

namespace Assignment_2_Time
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

        private void BtnCheckTime_Click(object sender, RoutedEventArgs e)
        {
            int ottawaTime = 0;
            int victoriaTime = 0;
            int edmontonTime = 2259;
            int winnipegTime = 2359;
            int torontoTime = 0;
            int halifaxTime = 100;
            int StJohnsTime = 130;
            
            int.TryParse(Imputtime.Text, out ottawaTime);
           
            {
                lblOutput.Content = victoriaTime = ottawaTime - 300;


            }

        }
    }
}
