using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseController
{
    public interface IActivity
    {
        void Execute();
        void AddAction(IAction action);
        List<IAction> GetActions();
    }
}
