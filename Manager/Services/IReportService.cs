using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.ReportModel;

namespace Manager.Services
{
    internal class IReportService
    {
        IEnumerable<Report> GetAllReports();
        Report GetReportsById(int id);
        void AddReport(Report report);
        void UpdateReport(int id, Report report);
        void DeleteReport(int id);
    }
}
