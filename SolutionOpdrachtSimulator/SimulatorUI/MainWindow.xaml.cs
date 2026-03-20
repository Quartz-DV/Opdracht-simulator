using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.ComponentModel;

namespace SimulatorUI
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TitleCard_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DescriptionCard_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ManCheck_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Mannen toegestaan of niet.
        }

        private void VrouwCheck_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Vrouwen toegestaan of niet.
        }

        private void SelectFolderButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFolderDialog();
        }

        /*Not yet implemented:
        private void OpenFolderDialog()
        {
            var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Title = "Kies een folder"
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string folderPath = dialog.FileName;
            }
        }
        */

    }
}