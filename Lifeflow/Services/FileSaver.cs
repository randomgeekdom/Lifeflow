using FantasticalWorldSim.Model.Geography;
using Lifeflow.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifeflow.Services
{
    public class FileSaver
    {
        private readonly string file = Path.Combine(FileSystem.Current.AppDataDirectory, "flows");

        
        public CurrentFlow ReadFlow()
        {
            if (File.Exists(file))
            {
                return JsonConvert.DeserializeObject<CurrentFlow>(File.ReadAllText(file));
            }
            else
            {
                var flow = new CurrentFlow();
                this.WriteFlow(flow);
                return flow;
            }
        }

        public void WriteFlow(CurrentFlow flow)
        {
            File.WriteAllText(file, JsonConvert.SerializeObject(flow));
        }
    }
}
