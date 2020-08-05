using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{

    public class QuanLyThucDon
    {
        QuanLyNhaHangDataContext qlnh = new QuanLyNhaHangDataContext();

        public IEnumerable<ThucDon> getThucDons()
        {
            var ThucDons = from td in qlnh.ThucDons select td;
            return ThucDons;
        }
        public double? getGiaByMaThucDon(string mathucdon)
        {
            ThucDon td = qlnh.ThucDons.Where(a => a.MaThucDon == mathucdon).FirstOrDefault();
            return td.Gia;
        }
        public IEnumerable<LoaiThucDon> getLoaiThucDons()
        {
            var LoaiThucDons = from ltd in qlnh.LoaiThucDons select ltd;
            return LoaiThucDons;
        }
        private bool kiemtraThucDon(string mathucdon)
        {
            ThucDon td = qlnh.ThucDons.Where(a => a.MaThucDon == mathucdon).FirstOrDefault();
            if (td != null)
            {
                return true;
            }
            else { return false; }
        }
        public void themThucDon(string mathucdon, string maloaithucdon, string tenthucdon, float gia, string trangthai)
        {
            if (kiemtraThucDon(mathucdon))
            {
                MessageBox.Show("Mã thực đơn đã tồn tại\nVui lòng nhập lại.");
                return;
            }
            ThucDon newThucDon = new ThucDon();
            newThucDon.MaThucDon = mathucdon;
            newThucDon.MaLoaiThucDon = maloaithucdon;
            newThucDon.TenThucDon = tenthucdon;
            newThucDon.Gia = gia;
            newThucDon.TrangThai = trangthai;

            qlnh.ThucDons.InsertOnSubmit(newThucDon);
            qlnh.SubmitChanges();
            MessageBox.Show("Thêm thực đơn '" + tenthucdon + "' thành công.");
        }

        public bool xoaThucDon(string mathucdon)
        {
            try
            {
                ThucDon td = qlnh.ThucDons.Where(a => a.MaThucDon == mathucdon).FirstOrDefault();
                if (td != null)
                {
                    qlnh.ThucDons.DeleteOnSubmit(td);
                    qlnh.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void suaThucDon(string mathucdon,string maloai, string tenthucdon, float gia, string trangthai)
        {
            ThucDon td = qlnh.ThucDons.Where(a => a.MaThucDon == mathucdon).FirstOrDefault();
            if(!kiemtraThucDon(mathucdon))
            {
                MessageBox.Show("Mã thực đơn không tồn tại.");
                return;
            }
            if(td!=null)
            {
                td.TenThucDon = tenthucdon;
                td.MaLoaiThucDon = maloai;
                td.Gia = gia;
                td.TrangThai = trangthai;

                qlnh.SubmitChanges();
            }
            MessageBox.Show("Sửa thành công món '"+mathucdon+"'");
        }

    }
}
