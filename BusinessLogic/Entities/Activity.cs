using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic
{
    [Table("Activities")]
    public class Activity : ISubject
    {
        #region Attributes
        
        private string name;
        private DateTime begginingDate;
        private DateTime endingDate;
        private string description;
        public static List<IObserver> activityObservers = new List<IObserver>();

        #endregion

        #region Properties

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name
        {
            get { return name; }
            set {
                if (name != value)
                {
                    name = value;
                    NotifyObservers(this, "updated activity name");
                }
            }
        }

        
        public DateTime BegginingDate
        {
            get { return begginingDate; }
            set {
                if (begginingDate != value)
                {
                    begginingDate = value;
                    NotifyObservers(this, "updated beggining date");
                }
            }
        }

        
        public DateTime EndingDate
        {
            get { return endingDate; }
            set {
                if (endingDate != value)
                {
                    endingDate = value;
                    NotifyObservers(this, "updated ending date");
                }
            }
        }

        [Required]
        [StringLength(200)]
        public string Description
        {
            get { return description; }
            set {
                if(description != value){
                    description = value;
                    NotifyObservers(this, "updated activity description");
                }
            }
        }

        #endregion

        #region Methods

        public void RegisterObserver(IObserver observer)
        {
            if (!activityObservers.Contains(observer)) activityObservers.Add(observer);         
        }

        public void UnregisterObserver(IObserver observer)
        {
            if (activityObservers.Contains(observer)) activityObservers.Remove(observer);
        }

        public void NotifyObservers(Activity activity, string message)
        {
            foreach (IObserver o in activityObservers)
            {
                o.Update(activity, message);
            }
        }

        #endregion
    }
}
