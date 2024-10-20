using Manager.Services;
using static Model.ReportModel;

namespace Manager.Managers
{
    public class ReportManager : IReportService
    {
        // Temp Data
        private readonly List<Report> _reports = new List<Report>
        {
            new Report { userId = 1, userName = "Vault", emai = "mail@mail.cs", password = "123", role = "Developer", reportId = 1, reportTitle = "Lorem Ipsum", reportDescription = "Dolor", priority = "High", status = "Open", notes = "Testing"}
        };

        // Function to display the list of reports
        public IEnumerable<Report> GetAllReports()
        {
            return _reports;
        }

        // Function to display the details of the report if there is a matching id
        public Report GetReportsById(int id)
        {
            return _reports.FirstOrDefault(r => r.id == id);
        }

        // Function that displays adds a reports to the list
        public void AddReport(Report report)
        {
            report.reportId = _reports.Max(r => r.id) + 1;
            _reports.Add(report);
        }

        //Function that update a report's information if it exists
        public void UpdateReport(int id, ReportManager report)
        {
            var existingReport = _reports.FirstOrDefault(r => r.Id == id);
            if (existingReport != null)
            {
                existingReport.reportId = id;
                existingReport.reportTitle = reportTitle;
            }
        }

        // Function that deletes a report from the list
        public void DeleteReport(int id)
        {
            var report = _reports.FirstOrDefault(s => s.Id == id);
            if (report!= null)
            {
                _reports.Remove(report);
            }
        }
    }
}
