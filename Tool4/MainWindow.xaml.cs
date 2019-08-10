using System.Windows;

namespace Tool4
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

            var includeCustomerComplaints = IncludeCustomerComplaintsRadioButton.IsChecked == true;

            var includeOnlyOpenCustomerComplaints = IncludeOnlyOpenComplaintsCheckBox.IsChecked == true;

            var includeOnlyASummaryOfCustomerComplaints = IncludeOnlyASummaryOfCustomerComplaintsRadioButton.IsChecked == true;

            GenerateReport(customerId, outputFilename, includeCustomerComplaints, includeOnlyOpenCustomerComplaints, includeOnlyASummaryOfCustomerComplaints);
        }

        private bool ValidateInputs()
        {
            //TODO: validate inputs
            return true;
        }

        void GenerateReport(
            int customerId,
            string outputFilename,
            bool includeCustomerComplaints,
            bool includeOnlyOpenCustomerComplaints,
            bool includeOnlyASummaryOfCustomerComplaints)
        {
            //TODO: generate report
        }
    }
}
