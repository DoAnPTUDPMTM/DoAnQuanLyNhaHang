using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyNhanVien
    {
        QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext();
        public IEnumerable<NhanVien> getNhanViens()
        {
            var NhanViens = from nv in db.NhanViens select nv;
            return NhanViens;
        }

        public bool kiemtraNhanVienTonTaiChua(string manhanvien)
        {
            NhanVien nv = db.NhanViens.Where(a => a.MaNhanVien == manhanvien).FirstOrDefault();
            if (nv != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void themNhanVien(string manhanvien, string tennhanvien, string ngaysinh, string gioitinh, string dienthoai, string email, string diachi,string tendangnhap)
        {
            if (kiemtraNhanVienTonTaiChua(manhanvien))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại.");
                return;
            }
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = manhanvien;
            nv.TenNhanVien = tennhanvien;
            nv.NgaySinh = Convert.ToDateTime(ngaysinh);
            nv.GioiTinh = gioitinh;
            nv.DienThoai = dienthoai;
            nv.Email = email;
            nv.DiaChi = diachi;
            nv.TenDangNhap = tendangnhap;

            db.NhanViens.InsertOnSubmit(nv);
            db.SubmitChanges();
            MessageBox.Show("Thêm nhân viên '"+tennhanvien+"' thành công.");
        }

        private bool kiemtraEmail(string email)
        {
            string regexemail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (!Regex.IsMatch(email, regexemail))
            {
                return false;
            }
            return true;
        }
        public static bool hasSpecialChar2(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }
        private bool kiemtraSDT(string sdt)
        {
            if (sdt.Length != 10)
            {
                return false; // không đủ 10 kí tự
            }
            if (hasSpecialChar2(sdt))
            {
                return false;
            }
            // kiem tra chuoi co toan la chu so khong
            string[] so = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int flag = 0;
            for (int i = 0; i < sdt.Length; i++)
            {

                string a = sdt.Substring(i, 1);
                for (int j = 0; j < so.Count(); j++)
                {
                    if (a.Equals(so[j].ToString()))
                    {
                        flag++;
                        break;
                    }

                }
            }
            if (flag != 10)
            {
                return false;
            }
            // --------
            string dauso = "086,096,097,098,032,033,034,035,036,037,038,039,089,090,093,070,079,077,076,078,088,091,094,083,084,085,081,082,092,056,058,099,059";
            string[] arrDauSo = dauso.Split(',');

            string dausoInput = sdt.Substring(0, 3);

            for (int i = 0; i < arrDauSo.Count(); i++)
            {
                if (dausoInput.Equals(arrDauSo[i].ToString()))
                {
                    return true; // đúng đầu số
                }
            }

            return false; // sai
        }
        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,1234567890";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        public bool kiemtraDuLieuNhap(string manhanvien, string tennhanvien, string ngaysinh, string dienthoai, string email, string diachi)
        {
            if (manhanvien.Length == 0 || tennhanvien.Length == 0 || ngaysinh.Length == 0 || dienthoai.Length == 0 || email.Length == 0 || diachi.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.");
                return false;
            }
            if (manhanvien.Length > 10)
            {
                MessageBox.Show("Mã nhân viên không được quá 10 ký tự.");
                return false;
            }
            if(hasSpecialChar(tennhanvien))
            {
                MessageBox.Show("Tên nhân viên không hợp lệ.");
                return false;
            }
            if (!kiemtraEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.");
                return false;
            }
            if (!kiemtraSDT(dienthoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return false;
            }
            if (hasSpecialChar2(manhanvien))
            {
                MessageBox.Show("Mã nhân viên tồn tại ký tự đặc biệt.");
                return false;
            }
            return true;
        }

        public bool xoaNhanVien(string manhanvien)
        {
            NhanVien nv = db.NhanViens.Where(a => a.MaNhanVien == manhanvien).FirstOrDefault();
            if (nv != null)
            {
                db.NhanViens.DeleteOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool kiemtraKhoaNgoai(string manhanvien)
        {
            HoaDon hd = db.HoaDons.Where(a=>a.MaNhanVien == manhanvien).FirstOrDefault();
            if (hd != null)
            {
                return false;
            }
            return true;
        }

        public string getMaNhanVienByTenDangNhap(string tendangnhap)
        {
            NhanVien nv = db.NhanViens.Where(a => a.TenDangNhap == tendangnhap).FirstOrDefault();
            return nv.MaNhanVien;
        }
        public IEnumerable<TaiKhoan> getTaiKhoanChuaCoDung()
        {
            var taikhoans = from tk in db.TaiKhoans select tk;
            var taikhoantrongnhanvien = from taikhoan in db.TaiKhoans
                                        join nv in db.NhanViens on taikhoan.TenDangNhap equals nv.TenDangNhap
                                        select taikhoan;
            return taikhoans.Except(taikhoantrongnhanvien);
        }

        public bool suaNhanVien(string manv, string tennv, string ngaysinh, string gioitinh, string dienthoai, string email, string diachi, string tendangnhap)      
        {
            NhanVien nv = db.NhanViens.Where(a => a.MaNhanVien == manv).FirstOrDefault();
            if (nv != null)
            {                
                nv.TenNhanVien = tennv;
                nv.NgaySinh = Convert.ToDateTime(ngaysinh);
                nv.GioiTinh = gioitinh;
                nv.DienThoai = dienthoai;
                nv.Email = email;
                nv.DiaChi = diachi;
                nv.TenDangNhap = tendangnhap;
                db.SubmitChanges();
                MessageBox.Show("Lưu thành công");
                return true;
            }
            MessageBox.Show("Lưu thất bại.");
            return false;
        }
    }
}
