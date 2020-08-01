using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyHoaDon
    {
        QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext();


        public IEnumerable<HoaDon> getHoaDons()
        {
            var HoaDons = from hd in db.HoaDons select hd;
            return HoaDons;
        }

        public IEnumerable<ChiTietHoaDon> getChiTietHoaDons(string mahoadon)
        {
            var ChiTietHoaDons = from cthd in db.ChiTietHoaDons where cthd.MaHoaDon == mahoadon select cthd;
            return ChiTietHoaDons;
        }
        public bool kiemtraMaNhanVien(string manv)
        {
            NhanVien nv = db.NhanViens.Where(a => a.MaNhanVien == manv).FirstOrDefault();
            if (nv == null)
            {
                return false;
            }
            return true;
        }
        public bool kiemtraMaBan(string maban)
        {
            Ban nv = db.Bans.Where(a => a.MaBan == maban).FirstOrDefault();
            if (nv == null)
            {
                return false;
            }
            return true;
        }
        public bool kiemtraMaHoaDon(string mahd)
        {
            HoaDon hd = db.HoaDons.Where(a => a.MaHoaDon == mahd).FirstOrDefault();
            if(hd!=null)
            {
                return false;
            }
            return true;
        }
        public void themHoaDon(string mahd, string maban, string manhanvien, string makhachhang, string thanhtien)
        {
            if(string.IsNullOrEmpty(maban) || string.IsNullOrEmpty(manhanvien) || string.IsNullOrEmpty(thanhtien) || string.IsNullOrEmpty(mahd))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu");
                return;
            }
            if(!kiemtraMaHoaDon(mahd))
            {
                MessageBox.Show("Mã hoá đơn đã tồn tại.");
                return;
            }
            if(!kiemtraMaNhanVien(manhanvien))
            {
                MessageBox.Show("Mã nhân viên không tồn tại.");
                return;
            }
            if (!kiemtraMaBan(maban))
            {
                MessageBox.Show("Mã bàn không tồn tại.");
                return;
            }

            HoaDon hd = new HoaDon();
            
            hd.MaHoaDon = mahd;
            hd.NgayTao = DateTime.Now;
            hd.MaBan = maban;
            hd.MaNhanVien = manhanvien;
            if(makhachhang.Length == 0)
            {
                makhachhang = null;
            }
            hd.MaKhachHang = makhachhang;
            hd.ThanhTien = double.Parse(thanhtien);

            db.HoaDons.InsertOnSubmit(hd);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công hoá đơn " + mahd);
        }
        public bool xoaHoaDon(string mahoadon)
        {
            HoaDon hd = db.HoaDons.Where(a => a.MaHoaDon == mahoadon).FirstOrDefault();
            if(hd != null)
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn xoá hoá đơn '"+mahoadon+"' không?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
                {
                    var chitiethoadon = from cthd in db.ChiTietHoaDons where cthd.MaHoaDon == mahoadon select cthd;
                    foreach(ChiTietHoaDon cthd in chitiethoadon)
                    {
                        db.ChiTietHoaDons.DeleteOnSubmit(cthd);
                    }
                    
                    db.HoaDons.DeleteOnSubmit(hd);
                    db.SubmitChanges();
                    MessageBox.Show("Xoá thành công hoá đơn '" + mahoadon + "'");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void luuHoaDon(string mahoadon, string ngaytao, string maban, string manv, string makh,string thanhtien)
        {
            HoaDon hd = db.HoaDons.Where(a => a.MaHoaDon == mahoadon).FirstOrDefault();
            if (string.IsNullOrEmpty(maban) || string.IsNullOrEmpty(manv) || string.IsNullOrEmpty(thanhtien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu");
                return;
            }
            if (!kiemtraMaNhanVien(manv))
            {
                MessageBox.Show("Mã nhân viên không tồn tại.");
                return;
            }
            if (!kiemtraMaBan(maban))
            {
                MessageBox.Show("Mã bàn không tồn tại.");
                return;
            }
            if (hd!=null)
            {
                hd.NgayTao = Convert.ToDateTime(ngaytao);
                hd.MaBan = maban;
                hd.MaNhanVien = manv;
                if(makh.Length==0)
                {
                    makh = null;
                }
                hd.MaKhachHang = makh;
                hd.ThanhTien = double.Parse(thanhtien);

                db.SubmitChanges();

                MessageBox.Show("Sửa thành công.");
            }
        }
    }
}
