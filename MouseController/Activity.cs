using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseController
{

    public class Activity: IActivity
    {
        public string Name { get; set; }

        List<IAction> _actions = new List<IAction>();

        public void AddAction(IAction action)
        {
            _actions.Add(action);
        }

        public List<IAction> GetActions()
        {
            return _actions;
        }
        
        public void Execute()
        {
            foreach (IAction action in _actions)
            {
                action.Execute();
            }
        }
    }
}
