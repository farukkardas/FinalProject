using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IoC
{
   public interface ICoreModule
    { 
       void Load(IServiceCollection serviceCollection);
    }
}
