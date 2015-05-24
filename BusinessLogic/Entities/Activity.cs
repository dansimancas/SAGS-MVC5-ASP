using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Activity : ISubject
    {
        #region Attributes

        private int id;
        private string name;
        private DateTime begginingDate;
        private DateTime endingDate;
        private string description;
        private int val = 0;

        //Observer
        private static List<IObserver> observers = new List<IObserver>();

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; NotifyObservers(this, "updated activity name"); }
        }

        public DateTime BegginingDate
        {
            get { return begginingDate; }
            set { begginingDate = value; NotifyObservers(this, "updated beggining date"); }
        }

        public DateTime EndingDate
        {
            get { return endingDate; }
            set { endingDate = value; NotifyObservers(this, "updated ending date"); }
        }

        public string Description
        {
            get { return description; }
            set { description = value; NotifyObservers(this, "updated description"); }
        }

        #endregion

        #region Constructors

        public Activity(List<IObserver> obs)
        {
            this.id = ++val;
            this.name = "Der Tag den Offenen Tür";
            this.begginingDate = DateTime.Now;
            this.endingDate = begginingDate.AddHours(6);
            this.description = "Heute ist der Tag wenn alles kann mitkommen und deutcshe Würstchen essen.";
            //Observer
            //if(val == 1) observers = new List<IObserver>();
            observers.AddRange(obs);
            NotifyObservers(this,"creation of activity");
        }

        #endregion

        #region Methods

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            if (observers.Contains(observer)) observers.Remove(observer);
        }

        public void NotifyObservers(Activity activity, string message)
        {
            foreach (IObserver o in observers)
            {
                o.Update(activity, message);
            }
        }

        #endregion
    }
}
