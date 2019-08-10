using System.Windows;

namespace Tool6
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

            ComplaintsReportingSettings complaintsReportingSettings;

            if (DoNotIncludeCustomerComplaintsRadioButton.IsChecked == true)
            {
                complaintsReportingSettings = new ComplaintsReportingSettings.DoNotGenerate();
            }
            else if (IncludeCustomerComplaintsRadioButton.IsChecked == true)
            {
                complaintsReportingSettings = new ComplaintsReportingSettings.Generate(
                    IncludeOnlyOpenComplaintsCheckBox.IsChecked == true);
            }
            else// if (IncludeOnlyASummaryOfCustomerComplaintsRadioButton.IsChecked == true)
            {
                complaintsReportingSettings = new ComplaintsReportingSettings.GenerateOnlySummary(
                    IncludeOnlyOpenComplaintsForSummaryCheckBox.IsChecked == true);
            }

            GenerateReport(
                customerId,
                outputFilename,
                complaintsReportingSettings);
        }

        private bool ValidateInputs()
        {
            //TODO: validate inputs
            return true;
        }

        void GenerateReport(
            int customerId,
            string outputFilename,
            ComplaintsReportingSettings complaintsReportingSettings)
        {
            //TODO: generate report
        }
    }
}
