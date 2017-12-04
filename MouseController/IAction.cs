using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseController
{
    public enum Type { MoveAction, ClickAction }
    public interface IAction
    {
        bool Active { get; set; }
        int DelayTime { get; set; }
        Type Type { get; set; }
        string Name { get; set; }
        void Execute();
    }
}
