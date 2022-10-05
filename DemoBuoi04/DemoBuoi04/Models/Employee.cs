using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DemoBuoi04.Models
{
    public enum Gender
    {
        Nam, Nữ
    }

    public class Employee
    {
        public Guid? Id { get; set; }

        [Display(Name ="Mã nhân viên")]
        [MinLength(4, ErrorMessage ="Tối thiểu 4 kí tự")]
        [Remote(controller:"Employee", action:"KiemTraMaNVTrung")]
        public string EmployeeNo { get; set; }

        [MinLength(4, ErrorMessage = "Tối thiểu 4 kí tự")]
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [EmailAddress]
        [Compare("Email", ErrorMessage ="Email không khớp")]
        public string ConfirmEmail { get; set; }

        [Url]
        public string? Website { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        [BirthDateCheck]
        [CheckOverDate(ErrorMessage ="Quá tuổi làm việc")]
        public DateTime BirthDate { get; set; }

        [Display(Name ="Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Thông tin thêm")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

        [Display(Name = "Giới tính")]
        public Gender Gender { get; set; }

        [Display(Name = "Lương")]
        [Range(0, 10000000)]
        public double Salary { get; set; }

        [Display(Name = "Bán thời gian")]
        public bool IsPartTime { get; set; }

        [Display(Name = "Địa chỉ")]
        [RegularExpression("[a-zA-Z 0-9]*")]
        public string Address { get; set; }

        [Display(Name = "Điện thoại")]
        [RegularExpression("0[35789][0-9]{8}")]
        public string? Phone { get; set; }

        [Display(Name = "Số tài khoản")]
        [CreditCard]
        [DataType(DataType.CreditCard)]
        public string CreditCard { get; set; }
    }
}
