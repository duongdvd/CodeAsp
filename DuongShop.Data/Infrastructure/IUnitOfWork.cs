using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongShop.Data.Infrastructure
{
    interface IUnitOfWork
    {
        void Commit();
    }
}
