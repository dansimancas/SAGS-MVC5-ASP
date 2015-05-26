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
        public static Dictionary<long, IObserver> activityObservers = new Dictionary<long, IObserver>();

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
                }
            }
        }

        #endregion

        #region Methods

        public void RegisterObserver(IObserver observer)
        {
            long key = observer.Key();
            if(!activityObservers.ContainsKey(key)) activityObservers.Add(key, observer);
            
        }

        public void UnregisterObserver(IObserver observer)
        {
            long key = observer.Key();
            if (activityObservers.ContainsKey(key)) activityObservers.Remove(key);
        }

        public void NotifyObservers(Activity activity, string message)
        {
           foreach(KeyValuePair<long, IObserver> ob in activityObservers)
            {
                ob.Value.Update(activity, message);
            }
        }
        
        #endregion
    }
}
