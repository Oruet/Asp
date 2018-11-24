using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizMe_.Startup))]
namespace QuizMe_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
