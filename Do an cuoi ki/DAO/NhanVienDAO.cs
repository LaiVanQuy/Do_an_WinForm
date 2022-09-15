using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_cuoi_ki.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private NhanVienDAO() { }
        public DataTable LoadNhanVien()
        {
            string query = "select * from NhanVien";
            DataTable data = new DataTable();
            data = DataProvider.Instance.MyExcuteQuery(query);
            return data;
        }
        public DataTable LayTTNV(int manv)
        {
            string query = "select * from NhanVien,TaiKhoan where NhanVien.MaNV=TaiKhoan.MaNV and NhanVien.MaNV="+manv+"";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.MyExcuteQuery(query);
            return dt;
        }
        public bool ThemNV(string tennv,string sdt,string diachi,float Luong)
        {
            bool f = false;
            string query = "insert into NhanVien values(N'"+tennv+"','"+sdt+"',N'"+diachi+"',"+Luong+")";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public bool SuaNV(int manv, string tennv, string sdt, string diachi, float Luong)
        {
            bool f = false;
            string query = "update NhanVien set TenNV=N'"+tennv+"',SDT="+sdt+",DiaChi=N'"+diachi+"',Luong="+Luong+" where MaNV="+manv+"";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public bool XoaNV(int manv)
        {
            bool f = false;
            string query = "delete from NhanVien where MaNV="+manv+"";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
    }
}
