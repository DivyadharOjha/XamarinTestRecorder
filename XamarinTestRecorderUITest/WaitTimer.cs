using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Utils;

namespace XamarinTestRecorderUITest
{
    public class WaitTimer : IWaitTimes
    {
        public TimeSpan WaitForTimeout { get { return TimeSpan.FromMinutes(5); } }

        public TimeSpan GestureWaitTimeout { get { return TimeSpan.FromMinutes(5); } }

        public TimeSpan GestureCompletionTimeout { get { return TimeSpan.FromMinutes(5); } } 
    }
}
