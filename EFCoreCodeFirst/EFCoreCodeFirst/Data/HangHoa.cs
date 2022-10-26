using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirst.Data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public int MaHh { get; set; }
        [MaxLength(150)]
        public string TenHH { get; set; }
        [MaxLength(150)]
        public string? Hinh { get; set; }
        public double DonGia { get; set; }
        public int MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public Loai Loai { get; set; }
    }
}
