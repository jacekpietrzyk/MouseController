using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseController
{
    public interface IAction
    {
        string Name { get; set; }
        void Execute();
    }
}
