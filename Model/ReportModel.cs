namespace Model
{
    public class ReportModel
    {
        public class Report
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public string role { get; set; }
            public string reportId { get; set; }
            public string reportTitle { get; set; }
            public string reportDescription { get; set; }
            public string priority { get; set; }
            public string status { get; set; }
            public string notes { get; set; }
            public string attachment { get; set; }
    }
}
