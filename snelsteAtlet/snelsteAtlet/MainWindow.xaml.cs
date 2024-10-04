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

namespace snelsteAtlet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nameFastest;
        int secondsFastest = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Text = string.Empty;
            secondsTextBox.Clear();
            resultTextBox.Text = "";
            nameTextBox.Focus();
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {

            //int secondsCurrent;
            bool isValidnummer = int.TryParse(secondsTextBox.Text, out int secondsCurrent);

            if (isValidnummer == true)
            {
                if (secondsFastest == 0 || secondsCurrent < secondsFastest) 
                {
                    secondsFastest = secondsCurrent;
                    nameFastest = nameTextBox.Text;
                }
            }

        }

        private void fastestButton__Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = $"De snelste atleet is {nameFastest} met en tijd van{secondsFastest} seconden";
        }
    }
}