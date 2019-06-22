using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB
{
    class ChuyenbayBLL
    {

        DAL.ChuyenbayDAL dalCB;
        public ChuyenbayBLL()
        {
            dalCB = new DAL.ChuyenbayDAL();
        }

        public DataTable Search(string maSanBayDi, string maSanBayDen, DateTime ngayKH, DateTime ngayKH2, string tmp)
        {
            return dalCB.Search(maSanBayDi, maSanBayDen, ngayKH,ngayKH2,tmp);
        }

    }
}
