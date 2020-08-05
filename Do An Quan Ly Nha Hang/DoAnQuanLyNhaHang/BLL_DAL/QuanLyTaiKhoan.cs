using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyTaiKhoan
    {
        QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext();
        public int kiemtra_phanquyenTaiKhoan(string tendangnhap)
        {
            TaiKhoanNhomTaiKhoan tk = db.TaiKhoanNhomTaiKhoans.Where(a => a.TenDangNhap == tendangnhap).FirstOrDefault();
            if (tk.MaNhomTaiKhoan.Equals("QL"))
            {
                return 0; // Quản lý
            }
            else
            {
                return 1; // Nhân viên
            }
        }
        public string getMaNhomTaiKhoanByTenDangNhap(string tendangnhap)
        {
            TaiKhoanNhomTaiKhoan tk = db.TaiKhoanNhomTaiKhoans.Where(a => a.TenDangNhap == tendangnhap).FirstOrDefault();
            return tk.MaNhomTaiKhoan;
        }
        public string getTenNhanVienByTenDangNhap(string tendangnhap)
        {
            NhanVien nv = db.NhanViens.Where(a => a.TenDangNhap == tendangnhap).FirstOrDefault();
            return nv.TenNhanVien;
        }
        public IEnumerable<PhanQuyen> getPhanQuyen(string manhomtaikhoan)
        {
            var PhanQuyens = from pq in db.PhanQuyens where pq.MaNhomTaiKhoan == manhomtaikhoan select pq;
            return PhanQuyens;
        }

        public bool kiemtraTaiKhoanTonTaiChua(string tendangnhap)
        {
            TaiKhoan tk = db.TaiKhoans.Where(a => a.TenDangNhap == tendangnhap).FirstOrDefault();
            if (tk != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<TaiKhoan> getTaiKhoans()
        {
            var TaiKhoans = from tk in db.TaiKhoans select tk;
            return TaiKhoans;
        }

        public void themTaiKhoan(string tendangnhap, string matkhau, bool hoatdong)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenDangNhap = tendangnhap;
            tk.MatKhau = matkhau;
            tk.HoatDong = hoatdong;
            db.TaiKhoans.InsertOnSubmit(tk);
            db.SubmitChanges();
            
        }

        public bool xoaTaiKhoan(string tendangnhap)
        {
            
            TaiKhoan tk = db.TaiKhoans.Where(a => a.TenDangNhap == tendangnhap).FirstOrDefault();
            if (tk != null)
            {
                db.TaiKhoans.DeleteOnSubmit(tk);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool suaTaiKhoan(string tendangnhap,string matkhau, bool hoatdong)
        {
            TaiKhoan tk = db.TaiKhoans.Where(a => a.TenDangNhap == tendangnhap).FirstOrDefault();
            if (tk != null)
            {
                tk.TenDangNhap = tendangnhap;
                tk.MatKhau = matkhau;
                tk.HoatDong = hoatdong;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
