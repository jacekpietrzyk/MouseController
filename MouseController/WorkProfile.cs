using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;

namespace MouseController
{
    public class WorkProfile: System.ComponentModel.IEditableObject, ICloneable
    { 
        struct ProfileData
        {
            internal string name;
            internal ObservableCollection<Area> areas;
            internal ObservableCollection<IActivity> activities;
        }
        [JsonIgnore]
        private ProfileData backupData;
        [JsonIgnore]
        private bool inTxn = false;
        [JsonProperty]
        public string Name { get; set; }
        [JsonIgnore]
        private ObservableCollection<Area> _areas = new ObservableCollection<Area>();
        [JsonIgnore]
        private ObservableCollection<IActivity> _activities = new ObservableCollection<IActivity>();

        [JsonProperty]
        public ObservableCollection<Area> Areas
        {
            get { return _areas; }
        }
        [JsonProperty]
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

        public object Clone() // DeepClone
        {
            WorkProfile profileClone = new WorkProfile();
            profileClone.Name = this.Name;

            foreach(Area area in Areas)
            {
                profileClone.AddArea(new Area
                {
                    Name = area.Name,
                    StartPositionX = area.StartPositionX,
                    StartPositionY = area.StartPositionY,
                    Width = area.Width,
                    Height = area.Height,
                    FileName = area.FileName,
                    ActivityName = area.ActivityName,
                    Bitmap = (Bitmap)area.Bitmap.Clone()
                });
            }

            foreach(IActivity activity in Activities)
            {
                Activity activityClone = new Activity();
                activityClone.Name = activity.Name;
                foreach(IAction action in activity.GetActions())
                {
                    if (action.Type == Type.ClickAction)
                    {
                        ClickAction clickAction = (ClickAction)action;
                        activityClone.AddAction(new ClickAction
                        {
                            Name = clickAction.Name,
                            Active = clickAction.Active,
                            DelayTime = clickAction.DelayTime
                        });

                    }
                    else if(action.Type == Type.MoveAction)
                    {
                        MoveAction moveAction = (MoveAction)action;
                        activityClone.AddAction(new MoveAction(profileClone.Areas.Where(t => t.Name == moveAction.Area.Name).First())
                        {
                            Name = moveAction.Name,
                            Active = moveAction.Active,
                            DelayTime = moveAction.DelayTime
                        });
                    }
                    
                }
                profileClone.AddActivity(activityClone);
            }
            return profileClone;
        }
    }
}
