using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        DuongShopContext Init();
    }
}
