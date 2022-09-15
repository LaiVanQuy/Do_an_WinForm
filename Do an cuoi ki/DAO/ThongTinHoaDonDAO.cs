using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_an_cuoi_ki.DTO;

namespace Do_an_cuoi_ki.DAO
{
    public class ThongTinHoaDonDAO
    {
        private static ThongTinHoaDonDAO instance;
        public static ThongTinHoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongTinHoaDonDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private ThongTinHoaDonDAO() { }
        public List<ThongTinHoaDon> LayTTHoaDon(int mahd)
        {
            List<ThongTinHoaDon> list = new List<ThongTinHoaDon>();
            string query = "select HangHoa.MaHang,HangHoa.TenHang,HangHoa.GiaKM,BanHang.soluong,HangHoa.GiaKM*BanHang.soluong as ThanhTien from HangHoa,BanHang,HoaDon where HoaDon.MaHoaDon = BanHang.MaHoaDon and BanHang.MaHang = HangHoa.MaHang and HoaDon.MaHoaDon = "+ mahd +"";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.MyExcuteQuery(query);
            foreach(DataRow r in dt.Rows)
            {
                ThongTinHoaDon tthd = new ThongTinHoaDon(r);
                list.Add(tthd);
            }
            return list;

        }
       
    }
}
