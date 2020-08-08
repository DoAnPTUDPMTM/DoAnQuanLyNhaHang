using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyNguyenLieu
    {
        QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext();
        public IQueryable loadDatagridviewNguyenLieu()
        {
            var nls = from nl in db.NguyenLieus select new { nl.MaNguyenLieu, nl.TenNguyenLieu, nl.SoLuong };
            return nls;
        }
        public string xulyMaNguyenLieu()
        {
            string rs = "";
            int count = db.NguyenLieus.Count();
            if(count==0)
            {
                rs = "NL_1";
            }
            else
            {
                
                string flag = "";
                int songuyenlieu = 1;
                do
                {
                    rs = "NL_" + (songuyenlieu++);
                    NguyenLieu tnl = db.NguyenLieus.Where(a => a.MaNguyenLieu == rs).FirstOrDefault();
                    if (tnl == null)
                    {
                        break;
                    }
                    else
                    {
                        flag = tnl.MaNguyenLieu;
                    }
                } while (flag == rs);
            }
            return rs;
        }
        public void themNguyenLieu(string tennl, string soluong)
        {
            if(string.IsNullOrEmpty(tennl) || string.IsNullOrEmpty(soluong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu");
                return;
            }
            NguyenLieu n = new NguyenLieu();
            string rs = xulyMaNguyenLieu();
            n.MaNguyenLieu = rs;
            n.TenNguyenLieu = tennl;
            n.SoLuong = int.Parse(soluong);

            db.NguyenLieus.InsertOnSubmit(n);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công nguyên liệu '"+tennl+"'");
        }

        public void xoaNguyenLieu(string manl)
        {
            if (MessageBox.Show("Bạn có chắc chắn xoá?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                NguyenLieu nl = db.NguyenLieus.Where(a => a.MaNguyenLieu == manl).FirstOrDefault();
                if (nl != null)
                {
                    db.NguyenLieus.DeleteOnSubmit(nl);
                    db.SubmitChanges();
                    MessageBox.Show("Bạn đã xoá thành công nguyên liệu '" + manl + "'");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lại nguyên liệu để xoá.");
                    return;
                }
            }
            
        }

        public void suaNguyenLieu(string manl,string tennl,string soluong)
        {

            NguyenLieu nl = db.NguyenLieus.Where(a => a.MaNguyenLieu == manl).FirstOrDefault();
            if (nl != null)
            {
                nl.TenNguyenLieu = tennl;
                nl.SoLuong = int.Parse(soluong);
                db.SubmitChanges();
                MessageBox.Show("Bạn đã cập nhật thành công nguyên liệu '" + manl + "'");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại nguyên liệu để cập nhật.");
                return;
            }
        }

        
    }
}
