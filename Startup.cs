using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011063274_NguyenQuangTam.Startup))]
namespace _2011063274_NguyenQuangTam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
