using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MouseController
{
    public class WorkProfile: System.ComponentModel.IEditableObject
    { 
        struct ProfileData
        {
            internal string name;
            internal ObservableCollection<Area> areas;
            internal ObservableCollection<IActivity> activities;
        }
        
        private ProfileData backupData;
        private bool inTxn = false;
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        private ObservableCollection<Area> _areas = new ObservableCollection<Area>();
        [JsonProperty]
        private ObservableCollection<IActivity> _activities = new ObservableCollection<IActivity>();


        public ObservableCollection<Area> Areas
        {
            get { return _areas; }
        }
        public ObservableCollection<IActivity> Activities
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
        
        public ObservableCollection<Area> GetAreas()
        {
            return _areas;
        }
        public ObservableCollection<IActivity> GetActivities()
        {
            return _activities;
        }

        public void BeginEdit()
        {
            if (!inTxn)
            {
                this.backupData.name = Name;
                this.backupData.areas = new ObservableCollection<Area>(Areas.Select(t => t).ToList());
                this.backupData.activities = new System.Collections.ObjectModel.ObservableCollection<IActivity>(Activities.Select(t => t).ToList());

                inTxn = true;
            }
        }

        public void EndEdit()
        {
            if (inTxn)
            {
                backupData = new ProfileData();
                inTxn = false;
            }
        }

        public void CancelEdit()
        {
            if (inTxn)
            {
                this.Name = this.backupData.name;
                this.Activities.Clear();
                this.Areas.Clear();
                foreach(Area area in this.backupData.areas)
                {
                    Areas.Add(area);
                }
                foreach(IActivity activity in this.backupData.activities)
                {
                    Activities.Add(activity);
                }

                inTxn = false;
            }
        }
    }
}
