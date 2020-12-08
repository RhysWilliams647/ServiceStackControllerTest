using System.Web;
using System.Web.Mvc;
using Funq;
using Services;
using ServiceStack;
using ServiceStack.Mvc;

namespace TestServiceStack
{
    public class AppHost : AppSelfHostBase
    {

        public AppHost() : base("Test", typeof(TestService).Assembly)
        {

        }

        public override void Configure(Container container)
        {
            SetConfig(new HostConfig
            {
                HandlerFactoryPath = "api"
            });


            container.RegisterFactory<HttpContext>(() => HttpContext.Current);
            // register container for mvc
            ControllerBuilder.Current.SetControllerFactory(new FunqControllerFactory(container));
        }
    }
}