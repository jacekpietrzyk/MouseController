using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestStack.White.InputDevices;

namespace MouseController
{
   
    public class WaitAction : IAction
    {
        public string Name { get; set; }
        public int DelayTime { get; set; }
        public void Execute()
        {
            Thread.Sleep(1500);
        }
    }
    public class MoveAction : IAction
    {
        public string Name { get; set; }
        Area area = new Area();
        public MoveAction(Area area)
        {
            this.area = area;
        }
        public void Execute()
        {
            Mouse.Instance.Location = new System.Windows.Point(area.ClickX, area.ClickY);
        }
    }
    public class ClickAction : IAction
    {
        public string Name { get; set; }

        public ClickAction()
        {

        }
        public void Execute()
        {

            Mouse.Instance.Click();
        }
    }
}
