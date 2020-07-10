using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace Museum_Admin
{
    /// <summary>
    /// Interaction logic for VetAdditionalInfo.xaml
    /// </summary>
    public partial class VetAdditionalInfo : UserControl
    {
        private MainWindow mainWin;
        private VeteranDBInfo Veteran;
        private int currentId;


        // File paths for photos - Used for EnlargedPhoto
        private string AddInfoPhoto1PicFile = "";
        private string AddInfoPhoto2PicFile = "";
        private string AddInfoPhoto3PicFile = "";
        private string AddInfoPhoto4PicFile = "";

        public VetAdditionalInfo(MainWindow main, VeteranDBInfo record)
        {
            InitializeComponent();

            Veteran = record;

            mainWin = main;

            DataContext = this;
        }

        // Sets dialog settings and loads data.
        public void BuildAndShowDialog(int recordId)
        {
            currentId = recordId;
            Veteran = new VeteranDBInfo(currentId);

            LoadAdditionalInfo1Pic();
            LoadAdditionalInfo2Pic();
            LoadAdditionalInfo3Pic();
            LoadAdditionalInfo4Pic();
        }

        public void LoadAdditionalInfo1Pic()
        {
            AddInfoPhoto1PicFile = ConfigurationManager.AppSettings["InstallDirectory"];
            AddInfoPhoto1PicFile += ConfigurationManager.AppSettings["AddInfoDirectory"];
            AddInfoPhoto1PicFile += Veteran.AddInfo1PicLoc;
            try
            {
                Img_AdditionalPhoto1.Source = Tools.LoadBitmap(AddInfoPhoto1PicFile);
            }
            catch (FileNotFoundException)
            {
                // Don't load missing files.
            }
            catch (DirectoryNotFoundException)
            {
                // Don't load missing files.
            }
        }

        public void LoadAdditionalInfo2Pic()
        {
            AddInfoPhoto2PicFile = ConfigurationManager.AppSettings["InstallDirectory"];
            AddInfoPhoto2PicFile += ConfigurationManager.AppSettings["AddInfoDirectory"];
            AddInfoPhoto2PicFile += Veteran.AddInfo2PicLoc;
            try
            {
                Img_AdditionalPhoto2.Source = Tools.LoadBitmap(AddInfoPhoto2PicFile);
            }
            catch (FileNotFoundException)
            {
                // Don't load missing files.
            }
            catch (DirectoryNotFoundException)
            {
                // Don't load missing files.
            }
        }

        public void LoadAdditionalInfo3Pic()
        {
            AddInfoPhoto3PicFile = ConfigurationManager.AppSettings["InstallDirectory"];
            AddInfoPhoto3PicFile += ConfigurationManager.AppSettings["AddInfoDirectory"];
            AddInfoPhoto3PicFile += Veteran.AddInfo3PicLoc;
            try
            {
                Img_AdditionalPhoto3.Source = Tools.LoadBitmap(AddInfoPhoto3PicFile);
            }
            catch (FileNotFoundException)
            {
                // Don't load missing files.
            }
            catch (DirectoryNotFoundException)
            {
                // Don't load missing files.
            }
        }
        public void LoadAdditionalInfo4Pic()
        {
            AddInfoPhoto4PicFile = ConfigurationManager.AppSettings["InstallDirectory"];
            AddInfoPhoto4PicFile += ConfigurationManager.AppSettings["AddInfoDirectory"];
            AddInfoPhoto4PicFile += Veteran.AddInfo4PicLoc;
            try
            {
                Img_AdditionalPhoto4.Source = Tools.LoadBitmap(AddInfoPhoto4PicFile);
            }
            catch (FileNotFoundException)
            {
                // Don't load missing files.
            }
            catch (DirectoryNotFoundException)
            {
                // Don't load missing files.
            }
        }
        private string SetPhoto(Image viewImage)
        {
            string newPicPath = "";
            bool? result;       // Nullable boolean
            bool isPicLoaded = false;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)" +
                "|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif";

            result = dlg.ShowDialog();

            if (result == true)
            {
                newPicPath = dlg.FileName;

                try
                {
                    viewImage.Source = Tools.LoadBitmap(newPicPath);
                    isPicLoaded = true;
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show(Tools.fileMissingMessage, Tools.fileMissingTitle);
                    isPicLoaded = false;
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show(Tools.directoryMissingMessage, Tools.directoryMissingTitle);
                    isPicLoaded = false;
                }
            }

            if (!isPicLoaded)
            {
                newPicPath = "";
            }

            return newPicPath;
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            VeteranRecord veteranRecord = new VeteranRecord(mainWin, Veteran);
            veteranRecord.BuildAndShowDialog();

            mainWin.DataContext = null;
            mainWin.MainWindowContent = veteranRecord;
            mainWin.DataContext = mainWin;
        }

        private void Img_AdditionalPhoto1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            EnlargedPhoto EnlargedWin = new EnlargedPhoto(AddInfoPhoto1PicFile);
            EnlargedWin.ShowDialog();
        }

        private void Btn_SetImg_AdditionalPhoto1_Click(object sender, RoutedEventArgs e)
        {
            string newPic;
            newPic = SetPhoto(Img_AdditionalPhoto1);

            if (!string.IsNullOrEmpty(newPic))
            {
                Veteran.AddInfo1PicLoc = newPic;
            }
        }

        private void Btn_DeleteImg_AdditionalPhoto1_Click(object sender, RoutedEventArgs e)
        {
            Img_AdditionalPhoto1.Source = null;
            Veteran.AddInfo1PicLoc = "";
        }

        private void Img_AdditionalPhoto2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            EnlargedPhoto EnlargedWin = new EnlargedPhoto(AddInfoPhoto2PicFile);
            EnlargedWin.ShowDialog();
        }

        private void Btn_SetImg_AdditionalPhoto2_Click(object sender, RoutedEventArgs e)
        {
            string newPic;
            newPic = SetPhoto(Img_AdditionalPhoto2);

            if (!string.IsNullOrEmpty(newPic))
            {
                Veteran.AddInfo2PicLoc = newPic;
            }
        }

        private void Btn_DeleteImg_AdditionalPhoto2_Click(object sender, RoutedEventArgs e)
        {
            Img_AdditionalPhoto2.Source = null;
            Veteran.AddInfo2PicLoc = "";
        }

        private void Img_AdditionalPhoto3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            EnlargedPhoto EnlargedWin = new EnlargedPhoto(AddInfoPhoto3PicFile);
            EnlargedWin.ShowDialog();
        }

        private void Btn_SetImg_AdditionalPhoto3_Click(object sender, RoutedEventArgs e)
        {
            string newPic;
            newPic = SetPhoto(Img_AdditionalPhoto3);

            if (!string.IsNullOrEmpty(newPic))
            {
                Veteran.AddInfo3PicLoc = newPic;
            }
        }

       
        private void Btn_DeleteImg_AdditionalPhoto3_Click(object sender, RoutedEventArgs e)
        {
            Img_AdditionalPhoto3.Source = null;
            Veteran.AddInfo3PicLoc = "";
        }

        private void Img_AdditionalPhoto4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            EnlargedPhoto EnlargedWin = new EnlargedPhoto(AddInfoPhoto4PicFile);
            EnlargedWin.ShowDialog();
        }

        private void Btn_SetImg_AdditionalPhoto4_Click(object sender, RoutedEventArgs e)
        {
            string newPic;
            newPic = SetPhoto(Img_AdditionalPhoto4);

            if (!string.IsNullOrEmpty(newPic))
            {
                Veteran.AddInfo4PicLoc = newPic;
            }
        }

        private void Btn_DeleteImg_AdditionalPhoto4_Click(object sender, RoutedEventArgs e)
        {
            Img_AdditionalPhoto4.Source = null;
            Veteran.AddInfo4PicLoc = "";
        }
    }
}
