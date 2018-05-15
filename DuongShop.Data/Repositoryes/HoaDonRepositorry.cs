using DuongShop.Data.Infrastructure;
using DuongShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongShop.Data.Repositoryes
{
    public interface IHoaDonRepositorry
    {

    }
    class HoaDonRepositorry : RepositoryBase<HoaDon>, IHoaDonRepositorry
    {
        public HoaDonRepositorry(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
