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

namespace Museum_Admin
{
    /// <summary>
    /// Interaction logic for VetAdditionalInfo.xaml
    /// </summary>
    public partial class VetAdditionalInfo : UserControl
    {
        private VetAdditionalInfo vetAdditionalInfoWin;
        private MainWindow parentWin;


        // File paths for photos - Used for EnlargedPhoto
        private string AddInfoPhoto1 = "";
        private string AddInfoPhoto2 = "";
        private string AddInfoPhoto3 = "";
        private string AddInfoPhoto4 = "";

        public VetAdditionalInfo(MainWindow parent, VetServiceDBInfo veteran)
        {
            InitializeComponent();

            parentWin = parent;

            DataContext = this;
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Img_AdditionalPhoto1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn_SetImg_AdditionalPhoto1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_DeleteImg_AdditionalPhoto1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Img_AdditionalPhoto2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn_SetImg_AdditionalPhoto2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_DeleteImg_AdditionalPhoto2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Img_AdditionalPhoto3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn_SetImg_AdditionalPhoto3_Click(object sender, RoutedEventArgs e)
        {

        }

       
        private void Btn_DeleteImg_AdditionalPhoto3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Img_AdditionalPhoto4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn_SetImg_AdditionalPhoto4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_DeleteImg_AdditionalPhoto4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
