using System;
using System.Web;

namespace HttpModuleExceptionHandler
{
    public class SyncModule : IHttpModule
    {



        public delegate void ErrorEventHandler(Object s, EventArgs e);

        private ErrorEventHandler _eventHandler = null;

        public event ErrorEventHandler MyEvent
        {
            add { _eventHandler += value; }
            remove { _eventHandler -= value; }
        }


        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(OnContext_BeginRequest);
        }

        private void OnContext_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication app = sender as HttpApplication;
            app.Context.Response.Write("Passei pelo OnBeginRequest do meu primeiro http módulo.<br>");
            if (_eventHandler != null)
                _eventHandler(this, null);
        }

        public void Dispose() { }

    }
}
