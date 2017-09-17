﻿using System;
using Autofac;
using TinyMvvm.IoC;

namespace TinyMvvm.Forms.Sample.iOS
{
    public static class Bootstrapper
    {
        public static void Initialize(App app)
        {
            var builder = new ContainerBuilder();

            // Common stuff
            TinyMvvm.Forms.Sample.Bootstrapper.Initialize(app, builder); 

            // iOS specific stuff

            // Build and set
            var container = builder.Build();
            var resolver = new TinyMvvm.Autofac.AutofacResolver(container);
            TinyMvvm.IoC.Resolver.SetResolver(resolver);
        }
    }
}
