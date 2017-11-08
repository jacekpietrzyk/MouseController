using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseController
{
    public class WorkProfile
    { 

        public string Name { get; set; }

        private List<Area> _areas = new List<Area>();

        public List<Area> Areas
        {
            get { return _areas; }
        }

        public void AddArea(Area newArea)
        {
            _areas.Add(newArea);
        }
    }
}
