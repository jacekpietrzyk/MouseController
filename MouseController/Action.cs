using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestStack.White.InputDevices;

namespace MouseController
{

    public class MoveAction : IAction
    {
        public Type Type { get; set; } = Type.MoveAction;
        public string Name { get; set; }
        public bool Active { get; set; } = true;

        private int _delayTime = 0;

        public int DelayTime
        {
            get { return _delayTime; }
            set { _delayTime = value; }
        }

        

        [JsonIgnore]
        private Area _area;
        
        public Area Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public MoveAction(Area area)
        {
            this.Area = area;
        }
        public void Execute()
        {
            Thread.Sleep(DelayTime);
            Mouse.Instance.Location = new System.Windows.Point(Area.ClickX, Area.ClickY);
        }
    }


    public class ClickAction : IAction
    {
        public Type Type { get; set; } = Type.ClickAction;
        public string Name { get; set; }
        private int _delayTime = 0;

        public int DelayTime
        {
            get { return _delayTime; }
            set { _delayTime = value; }
        }
        public bool Active { get; set; } = false;

        public ClickAction()
        {

        }
        public void Execute()
        {
            Thread.Sleep(DelayTime);
            Mouse.Instance.Click();
        }
    }
}
