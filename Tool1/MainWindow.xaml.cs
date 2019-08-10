using System.Windows;

namespace Tool1
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

        private void GenerateReportButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInputs())
                return;

            var customerId = int.Parse(CustomerIdTextBox.Text);

            var outputFilename = OutputFilenameTextBox.Text;

            GenerateReport(customerId, outputFilename);
        }

        private bool ValidateInputs()
        {
            //TODO: validate inputs
            return true;
        }

        public static void GenerateReport(int customerId, string outputFilename)
        {
            //TODO: generate report
        }
    }
}
