using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011060306_NguyenDinhHoang_BigSchool.Startup))]
namespace _2011060306_NguyenDinhHoang_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
