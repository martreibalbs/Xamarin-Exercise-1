using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace XamarinExer1.DependencyService
{
    public interface IBrowserDependency
    {
        void OpenUrl(string url);
        
    }

}
