using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedSorghum.Dal;
using RedSorghum.Model;

namespace RedSorghum.Bll
{
    public class bllAccount
    {
        private dalAccount dal = new dalAccount();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Account GetAccountById(int id)
        {
            return dal.GetAccountById(id);
        }
    }
}
