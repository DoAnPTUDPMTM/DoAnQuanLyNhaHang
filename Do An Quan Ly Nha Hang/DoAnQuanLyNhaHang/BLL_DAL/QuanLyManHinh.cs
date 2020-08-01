using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyManHinh
    {
        QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext();
        public void themMaManHinhVaoPhanQuyen(string mamanhinh)
        {
            var nhomtaikhoan = from ntk in db.NhomTaiKhoans select ntk;
            foreach(NhomTaiKhoan ntk in nhomtaikhoan)
            {
                PhanQuyen pq = new PhanQuyen();
                pq.MaManHinh = mamanhinh;
                pq.MaNhomTaiKhoan = ntk.MaNhomTaiKhoan;
                pq.CoQuyen = false;
                db.PhanQuyens.InsertOnSubmit(pq);

            }
            
        }

        public void xoaManHinhVaXoaTrongPhanQuyen(string mamanhinh)
        {
            var nhomtaikhoan = from ntk in db.NhomTaiKhoans select ntk;
            foreach (NhomTaiKhoan ntk in nhomtaikhoan)
            {
                PhanQuyen pq = db.PhanQuyens.Where(a => a.MaManHinh == mamanhinh && a.MaNhomTaiKhoan == ntk.MaNhomTaiKhoan).FirstOrDefault();

                if(pq!=null)
                {
                    db.PhanQuyens.DeleteOnSubmit(pq);
                }
                else
                {
                    continue;
                }
                

            }
            
        }

        public void xoaManHinh(string mamanhinh)
        {
            if(kiemtraMaManHinh(mamanhinh))
            {
                MessageBox.Show("Mã màn hình không tồn tại.");
                return;
            }
            ManHinh manhinh = db.ManHinhs.Where(a => a.MaManHinh == mamanhinh).FirstOrDefault();
            if(manhinh!=null)
            {
                db.ManHinhs.DeleteOnSubmit(manhinh);
                xoaManHinhVaXoaTrongPhanQuyen(mamanhinh);
                db.SubmitChanges();
                MessageBox.Show("Xoá thành công màn hình '"+mamanhinh+"'");
                return;
            }
            else
            {
                return;
            }
            

            
        }

        public IEnumerable<ManHinh> loadDatagridviewManHinh()
        {
            var manhinhs = from mh in db.ManHinhs select mh;
            return manhinhs;
        }
        public bool kiemtraMaManHinh(string mamh)
        {
            ManHinh mh = db.ManHinhs.Where(a => a.MaManHinh == mamh).FirstOrDefault();
            if(mh!=null)
            {
                return false;
            }
            return true;
        }
        public void themManHinh(string mamanhinh, string tenmanhinh)
        {
            if(!kiemtraMaManHinh(mamanhinh))
            {
                MessageBox.Show("Mã màn hình đã tồn tại.");
                return;
            }
            if(string.IsNullOrEmpty(mamanhinh) || string.IsNullOrEmpty(tenmanhinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.");
                return;
            }
            ManHinh mh = new ManHinh();
            mh.MaManHinh = mamanhinh;
            mh.TenManHinh = tenmanhinh;

            db.ManHinhs.InsertOnSubmit(mh);
            themMaManHinhVaoPhanQuyen(mamanhinh);
            MessageBox.Show("Thêm thành công.");
            db.SubmitChanges();
        }

        public void suaManHinh(string mamanhinh,string tenmanhinh)
        {
            if(kiemtraMaManHinh(mamanhinh))
            {
                MessageBox.Show("Mã màn hình không tồn tại.");
                return;
            }
            ManHinh mh = db.ManHinhs.Where(a => a.MaManHinh == mamanhinh).FirstOrDefault();
            if(mh!=null)
            {
                mh.TenManHinh = tenmanhinh;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công.");
            }

        }
    }
}
