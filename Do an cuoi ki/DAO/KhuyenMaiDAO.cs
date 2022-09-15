using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_cuoi_ki.DAO
{
    public class KhuyenMaiDAO
    {
        private static KhuyenMaiDAO instance;
        public static KhuyenMaiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhuyenMaiDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private KhuyenMaiDAO() { }
        public DataTable LoadKhuyenMai()
        {
            string query = "select MaKM,HangHoa.MaHang,TenHang,MucGiam,KhuyenMai.NgayHetHan from KhuyenMai,HangHoa where HangHoa.MaHang=KhuyenMai.MaHang";
            DataTable data = new DataTable();
            data = DataProvider.Instance.MyExcuteQuery(query);
            return data;
        }
        public bool ThemKM(int mahang,int mucgiam,DateTime ngayhethan)
        {
            bool f = false;
            string query = "insert into KhuyenMai values("+ mahang +","+ mucgiam +",'"+ ngayhethan +"')";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public bool SuaKM(int makm,int mucgiam,DateTime nhh)
        {
            bool f = false;
            string query = "update KhuyenMai set MucGiam="+mucgiam+",NgayHetHan='"+nhh+"' where makm="+makm+"";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public bool XoaKM(int makm)
        {
            bool f = false;
            string query = "delete from KhuyenMai where MaKM="+makm+"";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public DataTable LoadKMSapHetHan()
        {
            DataTable data = new DataTable();
            string query = "select MaKM,HangHoa.MaHang,TenHang,MucGiam,KhuyenMai.NgayHetHan from KhuyenMai, HangHoa where HangHoa.MaHang = KhuyenMai.MaHang and DATEADD(day,7,GETDATE())>= KhuyenMai.NgayHetHan and KhuyenMai.NgayHetHan > GETDATE()";
            data = DataProvider.Instance.MyExcuteQuery(query);
            return data;
        }
    }
}
