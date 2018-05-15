using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private DuongShopContext dbContext;

        public DuongShopContext Init()
        {
            return dbContext ?? (dbContext = new DuongShopContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
