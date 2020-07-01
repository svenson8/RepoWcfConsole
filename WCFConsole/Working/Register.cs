using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class Register : IRegister
{
    public void RunTask()
    {
        //Zapamiętaj kanał zwrotny
        INotify CallbackChannel = OperationContext.Current.GetCallbackChannel<INotify>();
        //Symulujemy jakieś długie obliczenia
        Thread.Sleep(1000);
        //Powiadamiamy klienta o zakończeniu
        CallbackChannel.Notify();
    }
}