// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace AnimationTiming
{
    public partial class AccelDecelExample : Page
    {
        #region Proxy Pattern
        //Subject Class
        interface ISubject
        {
            string value();
        }

        // real Subject Class
        class real_Subject : ISubject
        {
            public string value()
            {
                return null;
            }
        }
        //Proxy class
        class ProxyClass : ISubject
        {
            public string value()
            {
                return null;
            }
        }

        private void StateInvalidated(object sender, EventArgs args)
        {
            ISubject subject = new real_Subject();
            string _value = subject.value();

            if (sender != _value)
            {
                elapsedTime.Clock = (Clock)sender;
            }
        }
        #endregion
    }
}

/*
        private void StateInvalidated(object sender, EventArgs args)
        {
            if (sender != null)
            {
                elapsedTime.Clock = (Clock) sender;
            }
        }
    */