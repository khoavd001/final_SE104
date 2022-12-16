using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_vàng_bạc_trang_sức.DAO_database_callback
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set { instance = value; }
        }

        private CustomerDAO() { }
        public DataTable GetListCustomer()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT CustomerID, CustomerName, Gender, Address, ContactPhone, Totalmoney,VIP FROM dbo.Customer");
        }
    }
}
