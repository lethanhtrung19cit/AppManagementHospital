using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;
namespace Bus_QuanLy
{
    public class busBacSi
    {
        BacSi busBS = new BacSi();
        public DataTable getBacSi()
        {
            return busBS.getBacSi();
        }
        public string maBacSi()
        {
            return busBS.maBacSi();
        }
        public bool themBacSi(QuanLyBacSi bs, string maBacSi, string path)
        {
            return busBS.themBacSi(bs, maBacSi, path);

        }
        public bool suaBacSi(QuanLyBacSi bs, string maBacSi, string path)
        {
            return busBS.suaBacSi(bs, maBacSi, path);

        }
    }
}
