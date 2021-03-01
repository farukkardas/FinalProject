using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Business.CCS;
using Core.Utilities.Security.JWT;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http;
namespace Business.DependecyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {

                builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
                builder.RegisterType<EFProductDal>().As<IProductDal>().SingleInstance();

                builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
                builder.RegisterType<EFCategoryDal>().As<ICategoryDal>().SingleInstance();

                builder.RegisterType<UserManager>().As<IUserService>();
                builder.RegisterType<EFUserDal>().As<IUserDal>();

                builder.RegisterType<AuthManager>().As<IAuthService>();
                builder.RegisterType<JwtHelper>().As<ITokenHelper>();

                builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();

                var assembly = System.Reflection.Assembly.GetExecutingAssembly();

                builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                    .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                    {
                        Selector = new AspectInterceptorSelector()
                    }).SingleInstance();


            }
        }
    }
