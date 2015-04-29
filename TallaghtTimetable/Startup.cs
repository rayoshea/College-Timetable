using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TallaghtTimetable.Startup))]
namespace TallaghtTimetable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
