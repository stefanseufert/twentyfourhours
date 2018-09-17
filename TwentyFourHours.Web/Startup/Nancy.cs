using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Conventions;
using Nancy.Bootstrapper;

namespace TwentyFourHours.Web.Startup
{
    public class Nancy : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts"));

            base.ConfigureConventions(nancyConventions);
        }
    }
}
