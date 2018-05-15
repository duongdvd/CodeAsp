using DuongShop.Data.Infrastructure;
using DuongShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongShop.Data.Repositoryes
{
    public interface IChiTietHoaDonRepository
    {

    }
    class ChiTietHoaDonRepository : RepositoryBase<BaiViet>, IChiTietHoaDonRepository
    {
        public ChiTietHoaDonRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
