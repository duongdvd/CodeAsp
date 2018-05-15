using DuongShop.Data.Infrastructure;
using DuongShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongShop.Data.Repositoryes
{
    public interface ISanPhamRepository
    {

    }
    class SanPhamRepository : RepositoryBase<SanPham>, ISanPhamRepository
    {
        public SanPhamRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
