using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
        public void RemoveActivity(string activityToRemoveName)
        {
            if ((this.Activities.Where(t => t.Name == activityToRemoveName).Any()))
            {
                try
                {
                    IActivity activityToRemove = this.Activities.Where(t => t.Name == activityToRemoveName).First();
                    this.Activities.Remove(activityToRemove);
                    foreach (Area area in this.Areas.Where(t => t.ActivityName == activityToRemove.Name))
                    {
                        area.ActivityName = String.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception occurred while removing the activity");
                }
            }
        }
        
        public ObservableCollection<Area> GetAreas()
        {
            return _areas;
        }
        public ObservableCollection<IActivity> GetActivities()
        {
            return _activities;
        }
        public Tuple<int, int> GetCollectionsCount()
        {
            Tuple<int, int> result = new Tuple<int, int>(GetAreas().Count, GetActivities().Count);
            return result;
        }

        public void BeginEdit()
        {
            if (!inTxn)
            {
                this.backupData = (ProfileData)this.Clone();
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
            ProfileData profileClone = new ProfileData();
            profileClone.name = this.Name;
            profileClone.areas = new ObservableCollection<Area>();
            profileClone.activities = new ObservableCollection<IActivity>();

            foreach (Area area in Areas)
            {
                profileClone.areas.Add(new Area
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
                        activityClone.AddAction(new MoveAction(profileClone.areas.Where(t => t.Name == moveAction.Area.Name).First())
                        {
                            Name = moveAction.Name,
                            Active = moveAction.Active,
                            DelayTime = moveAction.DelayTime
                        });
                    }
                    
                }
                profileClone.activities.Add(activityClone);
            }
            return profileClone;
        }
    }
}
