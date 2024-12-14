using Manager.Services;
using static Models.Model;

namespace Manager.Managers
{
    public class Manager : IReportService
    {
        // Temp Data
        private readonly List<Report> _reports = new List<Report>
        {
            new Report { reportId = 1, userId = 1, reportTitle = "Lorem Ipsum", reportDescription = "Dolor", priority = "High", status = "Open", notes = "Testing"}
        };

        // Function to display the list of reports
        public IEnumerable<Report> GetAllReports()
        {
            return _reports;
        }

        // Function to display the details of the report if there is a matching id
        public Report GetReportsById(int id)
        {
            return _reports.FirstOrDefault(r => r.reportId == id);
        }

        // Function that adds a report to the list
        public void AddReport(Report report)
        {
            report.reportId = _reports.Max(r => r.reportId) + 1;
            _reports.Add(report);
        }

        // Function that updates a report's information if it exists
        public void UpdateReport(int id, Report report)
        {
            var existingReport = _reports.FirstOrDefault(r => r.reportId == id);
            if (existingReport != null)
            {
                existingReport.reportTitle = report.reportTitle;
                existingReport.reportDescription = report.reportDescription;
                existingReport.priority = report.priority;
                existingReport.status = report.status;
                existingReport.notes = report.notes;
            }
        }

        // Function that deletes a report from the list
        public void DeleteReport(int id)
        {
            var report = _reports.FirstOrDefault(s => s.reportId == id);
            if (report != null)
            {
                _reports.Remove(report);
            }
        }
    }
}