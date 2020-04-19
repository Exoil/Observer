using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface ObserverAble
    {
        public void Attach(Observer observer);
     
        public void Detach(Observer observer);
        public void Notify();
    }
}
