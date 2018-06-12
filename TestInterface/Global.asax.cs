﻿using System;
using System.Web.Http;
using TestInterface.Config;

namespace TestInterface
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}