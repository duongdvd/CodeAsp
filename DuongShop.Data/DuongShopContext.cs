using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuongShop.Model.Models;
namespace DuongShop.Data
{
    public class DuongShopContext : DbContext
    {
        public DuongShopContext() : base("DuongShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<BaiViet> BaiViets { get; set; }
        public DbSet<BaiViet> ChiTietHoaDons { get; set; }
        public DbSet<DanhMucBaiViet> DanhMucBaiViets { get; set; }
        public DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<GioiThieu> GioiThieux { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<PhanHoiKH> PhanHoiKHs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<TAG> TAGS { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}
