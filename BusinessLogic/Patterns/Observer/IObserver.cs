using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IObserver
    {
        //TODO: Implementar el update en un nuevo thread.
        void Update(Activity activity, string message);

        long Key();
    }
}
