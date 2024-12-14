using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.Model;
using Manager;

namespace Manager.Services
{
    public class IReportService
    {
        IEnumerable<Report> GetAllReports();
        private Report GetReportsById(int id);
        void AddReport(Report report);
        void UpdateReport(int id, Report report);
        void DeleteReport(int id);
    }
}
