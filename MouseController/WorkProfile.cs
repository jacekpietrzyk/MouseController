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

        public List<Area> _areas = new List<Area>();
        private List<IActivity> _activities = new List<IActivity>();

        public List<Area> Areas
        {
            get { return _areas; }
        }
        public List<IActivity> Activities
        {
            get { return _activities; }
        }


        public void AddArea(Area newArea)
        {
            _areas.Add(newArea);
        }
        public void AddActivity(IActivity newActivity)
        {
            _activities.Add(newActivity);
        }


        public List<Area> GetAreas()
        {
            return _areas;
        }
        public List<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}
