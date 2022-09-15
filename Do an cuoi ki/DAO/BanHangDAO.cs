using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_an_cuoi_ki.DTO;

namespace Do_an_cuoi_ki.DAO
{
    public class BanHangDAO
    {
        private static BanHangDAO instance;
        public static BanHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BanHangDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BanHangDAO() { }
        public bool InsertBillInfo(int mahd,int mahang,float sl)
        {
            string query = "insert into BanHang values("+mahd+","+mahang+","+sl+")";
            bool f = false;
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public bool updateBillInfo(int mahd,float sluongtra,ThongTinHoaDon tthd)
        {
            bool f = false;
            string query = "update BanHang set soluong=soluong-("+sluongtra+") where MaHoaDon="+mahd+" and MaHang="+tthd.Mahang+"";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public bool deleteBillInfo(int mahd,ThongTinHoaDon tthd)
        {
            string query = "delete from BanHang where MaHoaDon="+mahd+" and MaHang="+tthd.Mahang+"";
            bool f = false;
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
    }
}
