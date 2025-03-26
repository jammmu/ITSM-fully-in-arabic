using System;
using System.ComponentModel.DataAnnotations;

namespace ITDashboard.Models.Inventory
{
    public class Item
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "اسم العنصر مطلوب")]
        [Display(Name = "اسم العنصر")]
        public string Name { get; set; }

        [Display(Name = "الوصف")]
        public string Description { get; set; }

        [Required(ErrorMessage = "الكمية مطلوبة")]
        [Display(Name = "الكمية")]
        [Range(0, int.MaxValue, ErrorMessage = "الكمية يجب أن تكون قيمة غير سالبة")]
        public int Quantity { get; set; }

        [Display(Name = "رقم الباركود")]
        public string Barcode { get; set; }

        [Display(Name = "رقم QR Code")]
        public string QRCode { get; set; }

        [Display(Name = "سعر الشراء")]
        [DataType(DataType.Currency)]
        public decimal? PurchasePrice { get; set; }

        [Display(Name = "تاريخ الشراء")]
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }
        
        [Display(Name = "اسم المورد")]
        public string? VendorName { get; set; }

        [Display(Name = "رقم الموديل")]
        public string? ModelNumber { get; set; }

        [Display(Name = "رقم التسلسل")]
        public string? SerialNumber { get; set; }

        [Display(Name = "ملاحظات")]
        public string? Notes { get; set; }

    
    }
}