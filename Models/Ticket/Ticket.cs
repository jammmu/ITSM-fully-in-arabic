using System;
using System.ComponentModel.DataAnnotations;

namespace ITDashboard.Models.Ticket
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "عنوان التذكرة مطلوب")]
        [Display(Name = "عنوان التذكرة")]
        public string Title { get; set; }

        [Display(Name = "الوصف")]
        public string Description { get; set; }

        [Required(ErrorMessage = "الأولوية مطلوبة")]
        [Display(Name = "الأولوية")]
        public string Priority { get; set; } // e.g., High, Medium, Low

        [Required(ErrorMessage = "الحالة مطلوبة")]
        [Display(Name = "الحالة")]
        public string Status { get; set; } // e.g., Open, In Progress, Resolved, Closed

        [Display(Name = "تاريخ الإنشاء")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "تاريخ الإغلاق")]
        [DataType(DataType.DateTime)]
        public DateTime? ClosedDate { get; set; }

        [Display(Name = "الموظف المسؤول")]
        public string AssignedTo { get; set; }

        [Display(Name = "المستخدم")]
        public string ReportedBy { get; set; }

        [Display(Name = "المرفقات")]
        public string? Attachments { get; set; } // You might use a different approach for file uploads

        [Display(Name = "ملاحظات")]
        public string? Notes { get; set; }
    }
}