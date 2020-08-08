using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyPhieuNhap
    {
        QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext();
        public IQueryable loadDatagridviewPhieuNhap()
        {
            var pns = from pn in db.PhieuNhaps select new { pn.MaPhieuNhap,pn.NgayNhap,pn.MaNhanVien,pn.MaNhaCungCap };
            return pns;
        }

        public IQueryable loadDatagridviewCTPhieuNhap()
        {
            var ctpns = from pn in db.ChiTietPhieuNhaps select new { pn.MaChiTietPhieuNhap, pn.MaPhieuNhap, pn.MaNguyenLieu, pn.SoLuong };
            return ctpns;
        }
        public string xulyMaPhieuNhap()
        {
            int count = db.PhieuNhaps.Count();
            string maphieunhap = "";
            if (count == 0)
            {
                maphieunhap = "PN_1";
            }
            else
            {
                int stt = 1;
                string flag = "";
                do
                {
                    maphieunhap = "PN_" + (stt++);
                    PhieuNhap pn = db.PhieuNhaps.Where(a => a.MaPhieuNhap == maphieunhap).FirstOrDefault();
                    if (pn == null)
                    {
                        break;
                    }
                    else
                    {
                        flag = pn.MaPhieuNhap;
                    }
                } while (flag == maphieunhap);

            }
            return maphieunhap;
        }

       

        public void themPhieuNhap(string ngaynhap, string manhanvien, string mancc)
        {
            if (string.IsNullOrEmpty(ngaynhap) || string.IsNullOrEmpty(manhanvien) || string.IsNullOrEmpty(mancc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.");
                return;
            }
            string maphieunhap = xulyMaPhieuNhap();
            PhieuNhap pn = new PhieuNhap();
            pn.MaPhieuNhap = maphieunhap;
            pn.NgayNhap = Convert.ToDateTime(ngaynhap);
            pn.MaNhanVien = manhanvien;
            pn.MaNhaCungCap = mancc;

            db.PhieuNhaps.InsertOnSubmit(pn);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công phiếu '"+maphieunhap+"'.");
            
        }

        public IEnumerable<NhaCungCap> loadComboboxMaNhaCungCap()
        {
            var nccs = from ncc in db.NhaCungCaps select ncc;
            return nccs;
        }

        public IEnumerable<NhanVien> loadComboboxMaNhanVien()
        {
            var nvs = from nv in db.NhanViens select nv;
            return nvs;
        }

        public void xoaPhieuNhap(string maphieunhap)
        {
            if(MessageBox.Show("Bạn có chắc chắn xoá không?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            PhieuNhap pn = db.PhieuNhaps.Where(a => a.MaPhieuNhap == maphieunhap).FirstOrDefault();
            var ctpns = from ctpn in db.ChiTietPhieuNhaps where ctpn.MaPhieuNhap == maphieunhap select ctpn;

            if(pn!=null)
            {
                foreach (ChiTietPhieuNhap item in ctpns)
                {
                    db.ChiTietPhieuNhaps.DeleteOnSubmit(item);
                }
                db.PhieuNhaps.DeleteOnSubmit(pn);
                db.SubmitChanges();

                

                MessageBox.Show("Xoá thành công phiếu nhập '"+maphieunhap+"'");
            }
            else
            {
                MessageBox.Show("Mã phiếu nhập không tồn tại.");
                return;
            }
            
        }

        public void suaPhieuNhap(string maphieunhap, string ngaynhap, string manhanvien, string manhacungcap)
        {
            PhieuNhap pn = db.PhieuNhaps.Where(a => a.MaPhieuNhap == maphieunhap).FirstOrDefault();
            if (pn != null)
            {
                pn.NgayNhap = Convert.ToDateTime(ngaynhap);
                pn.MaNhanVien = manhanvien;
                pn.MaNhaCungCap = manhacungcap;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công phiếu nhập '" + maphieunhap + "'");
            }
            else
            {
                MessageBox.Show("Mã phiếu nhập không tồn tại.");
                return;
            }
        }

        public void themChiTietPhieuNhap(string mapn, string manguyenlieu, string soluong)
        {
            if(string.IsNullOrEmpty(mapn) || string.IsNullOrEmpty(manguyenlieu) || string.IsNullOrEmpty(soluong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.");
                return;
            }
            ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
            ctpn.MaPhieuNhap = mapn;
            ctpn.MaNguyenLieu = manguyenlieu;
            ctpn.SoLuong = int.Parse(soluong);

            db.ChiTietPhieuNhaps.InsertOnSubmit(ctpn);

            NguyenLieu nl = db.NguyenLieus.Where(a => a.MaNguyenLieu == manguyenlieu).FirstOrDefault();
            nl.SoLuong += int.Parse(soluong);

            db.SubmitChanges();
            MessageBox.Show("Thêm thành công.");
        }

        public IEnumerable<NguyenLieu> loadComboboxMaNguyenLieu()
        {
            var nls = from nl in db.NguyenLieus select nl;
            return nls;

        }

        public IQueryable loadDatagridviewChiTietPhieuNhapByMaPhieuNhap(string mapn)
        {
            var pns = from pn in db.ChiTietPhieuNhaps where pn.MaPhieuNhap == mapn select new { pn.MaChiTietPhieuNhap,pn.MaPhieuNhap,pn.MaNguyenLieu,pn.SoLuong };
            
            return pns;
        }

        public void xoaChiTietPhieuNhap(int mactpn)
        {
            if (MessageBox.Show("Bạn có chắc chắn xoá không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            ChiTietPhieuNhap ctpn = db.ChiTietPhieuNhaps.Where(a => a.MaChiTietPhieuNhap == mactpn).FirstOrDefault();
            if(ctpn != null)
            {
                db.ChiTietPhieuNhaps.DeleteOnSubmit(ctpn);
                db.SubmitChanges();
                MessageBox.Show("Xoá thành công.");
            }
            else
            {
                MessageBox.Show("Mã chi tiết phiếu nhập không tồn tại.");
                return;
            }
        }

        public void suaChiTietPhieuNhap(int mactpn,string manl,string sl)
        {
            ChiTietPhieuNhap ctpn = db.ChiTietPhieuNhaps.Where(a => a.MaChiTietPhieuNhap == mactpn).FirstOrDefault();
            if (ctpn != null)
            {
                ctpn.MaNguyenLieu = manl;
                ctpn.SoLuong = int.Parse(sl);
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công.");
            }
            else
            {
                MessageBox.Show("Mã chi tiết phiếu nhập không tồn tại.");
                return;
            }
        }
    }
}
