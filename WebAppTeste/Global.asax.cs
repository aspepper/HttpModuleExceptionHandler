using System;
using HttpModuleExceptionHandler;

namespace WebAppTeste
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {   
        }
        protected void HttpModuleExceptionHandler_ErrorEventHandler(Object src, EventArgs e)
        {
            Context.Response.Write("Hello from HttpModuleExceptionHandler_ErrorEventHandler called in Global.asax.<br>");
        }

    }
}