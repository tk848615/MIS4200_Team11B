﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS4200_Team11B.Startup))]
namespace MIS4200_Team11B
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
