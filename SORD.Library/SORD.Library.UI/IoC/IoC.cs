﻿using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Text;
using SORD.Library.UI.ViewModels;

namespace SORD.Library.UI
{
    public static class IoC
    {
        public static WindsorContainer Container { get; set; }
        public static IApplicationInstance Application { get; set; }
        static IoC()
        {
            Container = new WindsorContainer();
            Container.Register(Component.For<IApplicationInstance>().ImplementedBy<ApplicationInstance>());
            Application = Container.Resolve<IApplicationInstance>();
        }
    }
}
