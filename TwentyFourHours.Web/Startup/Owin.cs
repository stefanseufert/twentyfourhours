using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourHours.Web.Startup
{
    class Owin
    {
        public void Configuration(IAppBuilder app)
        {
            app
#if DEBUG
                .UseErrorPage()
#endif         
                .MapSignalR()
                .UseNancy();
        }
    }
}
