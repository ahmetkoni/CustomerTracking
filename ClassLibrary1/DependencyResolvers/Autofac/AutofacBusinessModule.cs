using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<MongoDB_CustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<CuriousCustomerManager>().As<ICuriousCustomerService>().SingleInstance();
            builder.RegisterType<MongoDB_CuriousCustomerDal>().As<ICuriousCustomerDal>().SingleInstance();

            builder.RegisterType<ForeignInvestorManager>().As<IForeignInvestorService>().SingleInstance();
            builder.RegisterType<MongoDB_ForeignInvestorDal>().As<IForeignInvestorDal>().SingleInstance();

            builder.RegisterType<InvestorManager>().As<IInvestorService>().SingleInstance();
            builder.RegisterType<MongoDB_InvestorDal>().As<IInvestorDal>().SingleInstance();

            builder.RegisterType<PossibleCustomerManager>().As<IPossibleCustomerService>().SingleInstance();
            builder.RegisterType<MongoDB_PossibleCustomerDal>().As<IPossibleCustomerDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
