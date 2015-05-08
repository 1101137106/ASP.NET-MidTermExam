using AopAlliance.Intercept;
using KuasCore.Models;
using System;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KuasCore.Interceptors 
{
    class CourseInterceptor : IMethodInterceptor
    {

        public object Invoke(IMethodInvocation invocation)
        {

            Console.WriteLine("CourseInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("CourseInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            object result = invocation.Proceed();

            if (result is Course)
            {
                Stopwatch sw = new Stopwatch(); 
                sw.Reset(); 
                sw.Start();
                Thread.Sleep(1000); 
                sw.Stop();
                Console.WriteLine("Stopwatch Mathod : {0} ms", sw.Elapsed.TotalMilliseconds);
            }

            return result;
        }
    }
}
