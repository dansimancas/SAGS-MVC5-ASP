using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace BusinessLogic
{
    public class ScoutGroupManager
    {
        private IManagerFileStrategy ManagerStrategy;

        public ScoutGroupManager(IManagerFileStrategy strategy)
        {
            this.ManagerStrategy = strategy;
        }

        public ScoutGroup loadFile(){
            return this.ManagerStrategy.loadFile();
        }

        public void writeFile(ScoutGroup S)
        {
            this.ManagerStrategy.writeFile(S);
        }
    }
}
