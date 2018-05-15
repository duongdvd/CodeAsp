using DuongShop.Data.Infrastructure;
using DuongShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongShop.Data.Repositoryes
{
    public interface IGioiThieuRepository
    {

    }
    class GioiThieuRepository : RepositoryBase<GioiThieu>, IGioiThieuRepository
    {
        public GioiThieuRepository(IDbFactory dbFactory) : base(dbFactory)
        {


        }
    }
}
