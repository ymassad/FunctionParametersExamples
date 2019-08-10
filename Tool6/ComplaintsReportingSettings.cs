namespace Tool6
{
    public abstract class ComplaintsReportingSettings
    {
        private ComplaintsReportingSettings()
        {
        }

        public sealed class DoNotGenerate : ComplaintsReportingSettings
        {

        }

        public sealed class Generate : ComplaintsReportingSettings
        {
            public Generate(bool includeOnlyOpenCustomerComplaints)
            {
                IncludeOnlyOpenCustomerComplaints = includeOnlyOpenCustomerComplaints;
            }

            public bool IncludeOnlyOpenCustomerComplaints { get; }
        }

        public sealed class GenerateOnlySummary : ComplaintsReportingSettings
        {
            public GenerateOnlySummary(bool includeOnlyOpenCustomerComplaintsForSummary)
            {
                IncludeOnlyOpenCustomerComplaintsForSummary = includeOnlyOpenCustomerComplaintsForSummary;
            }

            public bool IncludeOnlyOpenCustomerComplaintsForSummary { get; }
        }
    }
}