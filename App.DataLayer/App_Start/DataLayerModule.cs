﻿#region licence
// =====================================================
// Example code containing some useful methods that will be pulled out into libraries
// Filename: DataLayerModule.cs
// Date Created: 2014/10/20
// © Copyright Selective Analytics 2014. All rights reserved
// =====================================================
#endregion

using App.DataLayer.Contexts;
using Autofac;
//using App.Data.Model;

namespace App.DataLayer
{

    public class DataLayerModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            //Autowire the classes with interfaces
            builder.RegisterAssemblyTypes(GetType().Assembly).AsImplementedInterfaces();

            //set Entity Framework context to instance per lifetime scope. 
            //This is important as we get one context per lifetime, so all db classes are tracked together.
            builder.RegisterType<MainDbContext>().InstancePerLifetimeScope();
        }
    }

}
