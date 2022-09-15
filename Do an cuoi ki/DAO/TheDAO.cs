using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_cuoi_ki.DAO
{
    public class TheDAO
    {
        private static TheDAO instance;
        public static TheDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TheDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private TheDAO() { }
        public DataTable LoadThe()
        {
            DataTable dt = new DataTable();
            string query = "select * from The";
            dt = DataProvider.Instance.MyExcuteQuery(query);
            return dt;
        }
        public DataTable TimTheTheoSDT(string sdt)
        {
            DataTable dt = new DataTable();
            string query = "select * from The where SDT='" + sdt + "'";
            dt = DataProvider.Instance.MyExcuteQuery(query);
            return dt;
        }
        public bool ThemThe(string sdt,string tenkh)
        {
            bool f = false;
            string query = "insert into The values (" + sdt + ",N'" + tenkh +"',default,default)";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        
        public void UpdateTienThe(float Tien,string sdt)
        {
            string query = "update The set TongTien=TongTien+"+Tien+" where SDT=" + sdt + "";
           
            DataProvider.Instance.MyExcuteNonQuery(query);
        }
        public void UpdateLoaiThe()
        {
            string query2 = "update The set Hang=N'Đồng' where TongTien>2000000";
            string query3 = "update The set Hang=N'Bạc' where TongTien>8000000";
            string query4 = "update The set Hang=N'Vàng' where TongTien>15000000";
            string query5 = "update The set Hang=N'Kim Cương' where TongTien>20000000";
            DataProvider.Instance.MyExcuteNonQuery(query2);
            DataProvider.Instance.MyExcuteNonQuery(query3);
            DataProvider.Instance.MyExcuteNonQuery(query4);
            DataProvider.Instance.MyExcuteNonQuery(query5);
        }
        public bool UpdateThe(string tenkh,string sdt)
        {
            bool f = false;
            string query = "update The set TenKH=N'"+tenkh+"' where SDT='"+sdt+"'";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
    }

    
}
