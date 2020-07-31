using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyGoiMon
    {
        QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext();
        public IEnumerable<Ban> getBans()
        {
            var Bans = from b in db.Bans select b;
            return Bans;
        }
        public void setTrangThaiChoBan()
        {
            var bans = from b in db.Bans select b;
            foreach (Ban ban in bans)
            {
                if (kiemtraBanCoTrongGoiMonChua(ban.MaBan))
                {
                    ban.TrangThai = "Đã có khách";
                }
                else
                {
                    ban.TrangThai = "Còn trống";
                }
            }
            db.SubmitChanges();
        }
        public bool kiemtraBanCoTrongGoiMonChua(string maban)
        {
            GoiMon ban = db.GoiMons.Where(a => a.MaBan == maban).FirstOrDefault();
            if (ban != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void themMonAn(string maban, string mathucdon, string tenthucdon, string gia, string soluong)
        {
            if (!kiemTraMonAnTonTai(maban, mathucdon))
            {
                GoiMon newMon = new GoiMon();
                newMon.MaBan = maban;
                newMon.MaThucDon = mathucdon;
                newMon.TenThucDon = tenthucdon;
                newMon.Gia = int.Parse(gia);
                newMon.SoLuong = int.Parse(soluong);
                newMon.ThanhTien = int.Parse(gia) * int.Parse(soluong);
                newMon.ThoiGian = DateTime.Now;
                Ban Ban = db.Bans.Where(a => a.MaBan == maban).FirstOrDefault();
                Ban.TrangThai = "Đã có khách";
                db.GoiMons.InsertOnSubmit(newMon);
                db.SubmitChanges();

                MessageBox.Show("Thêm món '" + tenthucdon + "' cho bàn '" + maban + "' thành công.");

            }
            else
            {
                capnhatMonAn(maban, mathucdon, soluong);

            }

        }
        public void capnhatMonAn(string maban, string mathucdon, string soluong)
        {
            GoiMon g = db.GoiMons.Where(a => a.MaBan == maban && a.MaThucDon == mathucdon).FirstOrDefault();
            if (g != null)
            {
                g.SoLuong = g.SoLuong + int.Parse(soluong);
                g.ThanhTien = g.ThanhTien + Convert.ToDecimal((int.Parse(soluong) * g.Gia));
                db.SubmitChanges();
                MessageBox.Show("Đã cập nhật món ăn.");
            }
        }
        public void xoaMonAn(int magoimon)
        {
            GoiMon delMon = db.GoiMons.Where(m => m.id == magoimon).FirstOrDefault();
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá món '" + delMon.TenThucDon + "' của bàn '" + delMon.MaBan + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (delMon != null)
                {
                    db.GoiMons.DeleteOnSubmit(delMon);
                    MessageBox.Show("Xoá món '" + delMon.TenThucDon + "' thành công.");
                    db.SubmitChanges();

                }
            }


        }

        public bool kiemTraMonAnTonTai(string maban, string mathucdon)
        {
            GoiMon m = db.GoiMons.Where(a => a.MaBan == maban && a.MaThucDon == mathucdon).FirstOrDefault();
            if (m != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<GoiMon> loadGoiMonByBan(string maban)
        {
            var bans = from gm in db.GoiMons
                       where gm.MaBan == maban
                       select gm;
            return bans;

        }
        public void themChiTietHoaDon(string mahoadon, string mathucdon, int soluong, double thanhtien)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.MaHoaDon = mahoadon;
            cthd.MaThucDon = mathucdon;
            cthd.SoLuong = soluong;
            cthd.ThanhTien = thanhtien;
            db.ChiTietHoaDons.InsertOnSubmit(cthd);

        }
        public void thanhToan(string maban, string manhanvien, double thanhtien)
        {
            string mahoadon;
            var hoadons = db.HoaDons.Count();
            if (hoadons == 0)
            {
                mahoadon = "HD1";
            }
            else
            {
                //string flag1;
                //var hoadonss = db.HoaDons.OrderByDescending(x => x.MaHoaDon).FirstOrDefault();
                //flag1 = hoadonss.MaHoaDon;
                //string flag2;
                //flag2 = flag1.Substring(2);
                int sohoadon = db.HoaDons.Count() + 1;
                mahoadon = "HD" + sohoadon;

            }


            HoaDon hd = new HoaDon();
            hd.MaHoaDon = mahoadon;
            hd.NgayTao = DateTime.Now;
            hd.MaBan = maban;
            hd.MaNhanVien = manhanvien;
            hd.ThanhTien = thanhtien;
            
            db.HoaDons.InsertOnSubmit(hd);
            // thêm chi tiết hoá đơn
            var goimon = from gm in db.GoiMons where gm.MaBan == maban select gm;
            foreach (GoiMon gm in goimon)
            {
                string mathucdon = gm.MaThucDon;
                int soluong = Convert.ToInt32(gm.SoLuong);
                double thanhtiencthd = Convert.ToDouble(gm.ThanhTien);
                themChiTietHoaDon(mahoadon, mathucdon, soluong, thanhtiencthd);
            }
            // xoá gọi món của bàn

            if (goimon != null)
            {
                foreach (GoiMon gm in goimon)
                {
                    db.GoiMons.DeleteOnSubmit(gm);
                }
            }
            db.SubmitChanges();
            MessageBox.Show("Tổng số tiền của bàn '" + maban + "' là '" + thanhtien + "'.");
        }



        public bool chuyenBan(string mabancanchuyen, string mabancontrong)
        {
            if (string.IsNullOrEmpty(mabancanchuyen) || string.IsNullOrEmpty(mabancontrong))
            {
                MessageBox.Show("Chuyển bàn không thành công.");
                return false;
            }
            var getGoiMonBanCanChuyen = from gm in db.GoiMons where gm.MaBan == mabancanchuyen select gm;
            foreach (GoiMon gm in getGoiMonBanCanChuyen)
            {
                gm.MaBan = mabancontrong;
            }
            db.SubmitChanges();
            
            MessageBox.Show("Chuyển bàn thành công.");
            return true;
        }

        public IEnumerable<Ban> getBanConTrong()
        {
            var bans = from ban in db.Bans where ban.TrangThai == "Còn trống" select ban;
            return bans;
        }
        public IEnumerable<Ban> getBanCanChuyen()
        {
            var bans = from ban in db.Bans where ban.TrangThai == "Đã có khách" select ban;
            return bans;
        }

        public IEnumerable<LoaiThucDon> loadComboboxLoaiThucDon()
        {
            var ltd = from l in db.LoaiThucDons select l;
            return ltd;
        }
        public IEnumerable<ThucDon> loadComboboxThucDon(string maloai)
        {
            var Td = from td in db.ThucDons where td.MaLoaiThucDon == maloai select td;
            return Td;
        }
    }
}
