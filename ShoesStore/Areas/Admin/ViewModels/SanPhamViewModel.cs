using ShoesStore.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesStore.Areas.Admin.ViewModels
{
    public class SanPhamViewModel
    {
        public int DongsanphamId { get; set; }
        public string DongsanphamName { get; set; }
        public string TypeName {  get; set; }
        public enum TrangThaiEnum
        {
            [VietnameseName("On Sale")]
            Dangban = 1,
            [VietnameseName("Stop Selling")]
            NgungBan = 2,
            [VietnameseName("Hot")]
            Hot = 3,
            [VietnameseName("Latest")]
            New = 4
        }

        public TrangThaiEnum TrangThai { get; set; }


        [Required(ErrorMessage = "Sản phẩm đã hết màu")]
        public string IdMau {  get; set; }
        public List<string> tenSize {  get; set; }
        public List<int> slton {  get; set; }

        [Required(ErrorMessage ="Vui lòng nộp ảnh đại diện")]
        [Display(Name = "Ảnh đại diện")]
        [NotMapped] //Dont save this image database,save in root
        public IFormFile AvatarImage { get; set; }

        [Required(ErrorMessage = "Vui lòng nộp ảnh mặt trên")]
        [Display(Name = "Ảnh mặt trên giày")]
        [NotMapped]
        public IFormFile TopImage { get; set; }

        [Required(ErrorMessage = "Vui lòng nộp ảnh mặt đế")]
        [Display(Name = "Ảnh mặt đế giày")]
        [NotMapped]
        public IFormFile BottomImage { get; set; }
        public IFormFile VideoFile { get; set; }
    }
}
