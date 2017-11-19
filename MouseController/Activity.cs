using Newtonsoft.Json;
using System.Collections.Generic;

namespace MouseController
{

    public class Activity: IActivity
    {
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
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
