using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_cuoi_ki.DAO
{
    public class ThongKeDAO
    {
        private static ThongKeDAO instance;
        public static ThongKeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private ThongKeDAO() { }
        public DataTable ThongKe()
        {
            DataTable dt = new DataTable();
            string query = "ThongKe";
            dt=DataProvider.Instance.MyExcuteQuery(query);
            return dt;
        }
    }
}
