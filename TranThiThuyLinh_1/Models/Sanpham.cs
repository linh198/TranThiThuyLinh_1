namespace TranThiThuyLinh_1.Models
{
    public class Products
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int TamTinh { get; set; }
        public double Khuyenmai { get; set; }
        public double Tongcong { get; set; }
        public Products() { }
        public Products(string tenSanPham, int soLuong, int gia, double giamgia)
        {
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            DonGia = gia;
            TamTinh = soLuong * gia;
            Khuyenmai = SoLuong * gia * (giamgia / 100);
            Tongcong = TamTinh - Khuyenmai;
        }
    }
}

