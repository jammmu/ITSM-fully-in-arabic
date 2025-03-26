using System;
using System.ComponentModel.DataAnnotations;

namespace ITDashboard.Models.Analytics
{
    public class Report
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "اسم التقرير مطلوب")]
        [Display(Name = "اسم التقرير")]
        public string Name { get; set; }

        [Display(Name = "الوصف")]
        public string Description { get; set; }

        [Display(Name = "تاريخ الإنشاء")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "نوع التقرير")]
        public string ReportType { get; set; } // e.g., Inventory, Asset, Ticket

        [Display(Name = "بيانات التقرير")]
        public string ReportData { get; set; } // You might use a different approach for storing report data

        [Display(Name = "ملاحظات")]
        public string? Notes { get; set; }
    }
}