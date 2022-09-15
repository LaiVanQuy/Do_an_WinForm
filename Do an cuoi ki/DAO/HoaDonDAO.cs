using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_an_cuoi_ki.DTO;

namespace Do_an_cuoi_ki.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private HoaDonDAO() { }
        public bool InsertBill(int manv)
        {
            bool f = false;
            string query = "insert into HoaDon values("+manv+",default,default)";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public int LayIDMax()
        {
            int i = 0;
            string query = "select max(MaHoaDon) from HoaDon";
            try
            {
                i = (int)DataProvider.Instance.MyExcuteScalar(query);
            }
            catch
            {

            }
            return i;
        }
        public HoaDonDTO LayHdTheoID(int mahd)
        {
            DataTable dt = new DataTable();
            string query="select * from HoaDon where MaHoaDon="+mahd+"";
            dt = DataProvider.Instance.MyExcuteQuery(query);
            HoaDonDTO hd = new HoaDonDTO(dt.Rows[0]);
            return hd;
        }
        public DataTable LoadHoaDon()
        {
            DataTable dt = new DataTable();
            string query = "select * from HoaDon";
            dt = DataProvider.Instance.MyExcuteQuery(query);
            return dt;
        }
        public DataTable TimKiemHDTheoNgay(DateTime ngay)
        {
            DataTable dt = new DataTable();
            string query = "select * from HoaDon where Ngay='"+ngay+"'";
            dt = DataProvider.Instance.MyExcuteQuery(query);
            return dt;
        }
        public bool UpdateTongBill(int mahd,float tien)
        {
            bool f = false;
            string query = "update HoaDon set tongbill=tongbill + " + tien + " where MaHoaDon=" + mahd + "";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
    }
}
