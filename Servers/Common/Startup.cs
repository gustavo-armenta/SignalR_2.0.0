using Microsoft.AspNet.SignalR.Samples.Raw;
using Microsoft.AspNet.SignalR.Server;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Microsoft.AspNet.SignalR.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR<RawConnection>("/raw");
            app.MapSignalR();
        }
    }
}
