using DuongShop.Data.Infrastructure;
using DuongShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongShop.Data.Repositoryes
{
    public interface IDanhMucBaiVietRepository
    {

    }
    class DanhMucBaiVietRepository : RepositoryBase<DanhMucBaiViet>, IDanhMucBaiVietRepository
    {
        public DanhMucBaiVietRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
