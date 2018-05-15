using DuongShop.Data.Infrastructure;
using DuongShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongShop.Data.Repositoryes
{
    public interface ISpportOnlineRepository
    {

    }
    class SpportOnlineRepository : RepositoryBase<SupportOnline>, ISpportOnlineRepository
    {
        public SpportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
