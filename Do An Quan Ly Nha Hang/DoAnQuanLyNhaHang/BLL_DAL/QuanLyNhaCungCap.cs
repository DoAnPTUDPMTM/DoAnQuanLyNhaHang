using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyNhaCungCap
    {
        QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext();
        public IEnumerable<NhaCungCap> loadDatagridviewNhaCungCap()
        {
            var nccs = from ncc in db.NhaCungCaps select ncc;
            return nccs;

        }
        public bool kiemtraMaNCC(string mancc)
        {
            NhaCungCap ncc = db.NhaCungCaps.Where(a => a.MaNhaCungCap == mancc).FirstOrDefault();
            if(ncc!=null)
            {
                return true;
            }
            return false;
        }
        public void themNhaCungCap(string mancc, string tenncc, string sdt, string diachi)
        {
            if(kiemtraMaNCC(mancc))
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại.");
                return;
            }
            if(string.IsNullOrEmpty(mancc) || string.IsNullOrEmpty(tenncc) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu");
                return;
            }
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNhaCungCap = mancc;
            ncc.TenNhaCungCap = tenncc;
            ncc.SoDienThoai = sdt;
            ncc.DiaChi = diachi;

            db.NhaCungCaps.InsertOnSubmit(ncc);
            db.SubmitChanges();
            MessageBox.Show("Thêm nhà cung cấp '"+tenncc+"' thành công.");
        }

        public void xoaNhaCungCap(string mancc)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xoá?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            if(!kiemtraMaNCC(mancc))
            {
                MessageBox.Show("Mã nhà cung cấp cần xoá không tồn tại.");
                return;
            }
            NhaCungCap ncc = db.NhaCungCaps.Where(a => a.MaNhaCungCap == mancc).FirstOrDefault();
            if(ncc != null)
            {
                db.NhaCungCaps.DeleteOnSubmit(ncc);
                db.SubmitChanges();
                MessageBox.Show("Xoá thành công '"+mancc+"'");
            }
        }
        
        public void suaNhaCungCap(string mancc, string tenncc,string sdt, string diachi)
        {
            if (!kiemtraMaNCC(mancc))
            {
                MessageBox.Show("Mã nhà cung cấp cần xoá không tồn tại.");
                return;
            }
            if (string.IsNullOrEmpty(mancc) || string.IsNullOrEmpty(tenncc) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu");
                return;
            }
            NhaCungCap ncc = db.NhaCungCaps.Where(a => a.MaNhaCungCap == mancc).FirstOrDefault();
            if(ncc!=null)
            {
                ncc.TenNhaCungCap = tenncc;
                ncc.SoDienThoai = sdt;
                ncc.DiaChi = diachi;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công nhà cung cấp '"+mancc+"'");
            }
        }
    }
}
