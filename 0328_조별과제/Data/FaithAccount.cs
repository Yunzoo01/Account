using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_CRUD
{
    class FaithAccount:Account
    {
        public FaithAccount(int id, string name, int balance)
            : base(id, (int)(balance + balance * 0.01), name)
        {

        }        

        public override void AddMoney(int val)
        {
            base.AddMoney((int)(val + val * 0.01));
        }
    }
}
