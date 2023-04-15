namespace QLsanpham.Models
{
    public class SanPham
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int TamTinh { get; set; }

        public SanPham() { }

        public SanPham(string tensanpham, int soluong, int dongia)
        {
            TenSanPham = tensanpham;
            SoLuong = soluong;
            DonGia = dongia;
            TamTinh = soluong * dongia;
        }

    }
}
