using Stucts.BehavioralPatterns.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stucts.DelegateHelpers
{
    class PassingDelegates
    {
        public PassingDelegates()
        {
            //
        }

        public void PassDelegateMathodHere<T>(Action<T> action, T obj) where T : class
        {
            action(obj);
        }
    }
}
