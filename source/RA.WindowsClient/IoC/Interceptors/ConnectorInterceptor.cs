using RA.Kernel.Common;
using RA.Kernel.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace RA.WindowsClient.IoC.Interceptors
{
    public class ConnectorInterceptor : IInterceptionBehavior
    {
        public bool WillExecute { get { return true; } }
        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                ProgressBar progressBar = (Application.Current.MainWindow.FindName("progressBar") as ProgressBar);
                if (progressBar != null)
                    progressBar.Opacity = 1;
            });
            return getNext()(input, getNext);
        }
    }
}
