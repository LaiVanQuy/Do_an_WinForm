using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_an_cuoi_ki.DTO;

namespace Do_an_cuoi_ki.DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        public static NhaCungCapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhaCungCapDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private NhaCungCapDAO() { }
        public DataTable LoadNhaCungCap()
        {
            string query = "select * from NhaCungCap";
            DataTable data = new DataTable();
            data = DataProvider.Instance.MyExcuteQuery(query);
            return data;
        }
        public List<NhaCungCapDTO> ListNCC()
        {
            List<NhaCungCapDTO> list = new List<NhaCungCapDTO>();
            DataTable dt = LoadNhaCungCap();
            foreach(DataRow r in dt.Rows)
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO(r);
                list.Add(ncc);
            }
            return list;
        }
        public bool ThemNCC(string tenncc,string diachi,string sdt)
        {
            bool f = false;
            string query = "insert into NhaCungCap values(N'"+tenncc+"',N'"+diachi+"','"+sdt+"')";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public bool SuaNCC(int MaNCC,string tenncc, string diachi, string sdt)
        {
            bool f = false;
            string query = "update NhaCungCap set TenNCC=N'"+tenncc+"',DiaChi=N'"+diachi+"',Sdt='"+sdt+"' where MaNCC="+MaNCC+"";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }
        public bool XoaNCC(int MaNCC)
        {
            bool f = false;
            string query = "delete from NhaCungCap where MaNCC="+MaNCC+"";
            f = DataProvider.Instance.MyExcuteNonQuery(query);
            return f;
        }

    }
}
