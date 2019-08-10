using System.Windows;

namespace Tool3
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

            var includeCustomerComplaints = IncludeCustomerComplaintsCheckBox.IsChecked == true;

            var includeOnlyOpenCustomerComplaints = IncludeOnlyOpenComplaintsCheckBox.IsChecked == true;

            GenerateReport(customerId, outputFilename, includeCustomerComplaints, includeOnlyOpenCustomerComplaints);
        }

        private bool ValidateInputs()
        {
            //TODO: validate inputs
            return true;
        }

        public static void GenerateReport(int customerId, string outputFilename, bool includeCustomerComplaints, bool includeOnlyOpenCustomerComplaints)
        {
            //TODO: generate report
        }
    }
}
