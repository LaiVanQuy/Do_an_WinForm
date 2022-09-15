using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_cuoi_ki.DAO
{
    public class NhapHangDAO
    {

        private static NhapHangDAO instance;
        public static NhapHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhapHangDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private NhapHangDAO() { }
        public bool NhapHang(int manv,int mahang,float gianhap,float sl,DateTime? ngayhh)
        {
            bool f = false;
            string query = "insert into NhapHang values(" + manv + ","+ mahang +","+ gianhap +","+ sl +",GETDATE(),'"+ngayhh+"')";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public DataTable LayThongTinNhapHang()
        {
            DataTable dt = new DataTable();
            string query = "LayThongTinNhapHang";
            dt = DataProvider.Instance.MyExcuteQuery(query);
            return dt;
        }
    }
}
