using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(CustomerManage.Startup))]
namespace CustomerManage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);   
            app.MapSignalR();
        }
    }
}
