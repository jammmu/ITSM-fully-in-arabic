using System;
using System.ComponentModel.DataAnnotations;

namespace ITDashboard.Models.Asset
{
    public class Asset
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "اسم الأصل مطلوب")]
        [Display(Name = "اسم الأصل")]
        public string Name { get; set; }

        [Display(Name = "الوصف")]
        public string Description { get; set; }

        [Required(ErrorMessage = "رقم الأصل مطلوب")]
        [Display(Name = "رقم الأصل")]
        public string AssetTag { get; set; }

        [Display(Name = "رقم التسلسل")]
        public string SerialNumber { get; set; }

        [Display(Name = "رقم الموديل")]
        public string ModelNumber { get; set; }

        [Display(Name = "المورد")]
        public string Vendor { get; set; }

        [Display(Name = "تاريخ الشراء")]
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }

        [Display(Name = "سعر الشراء")]
        [DataType(DataType.Currency)]
        public decimal? PurchasePrice { get; set; }

        [Display(Name = "تاريخ البدء")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "تاريخ الانتهاء")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Display(Name = "الموقع")]
        public string Location { get; set; }

        [Display(Name = "الحالة")]
        public string Status { get; set; } // e.g., In Use, Available, In Repair, Disposed

        [Display(Name = "الموظف")]
        public string? AssignedTo { get; set; }

        [Display(Name = "ملاحظات")]
        public string? Notes { get; set; }
    }
}