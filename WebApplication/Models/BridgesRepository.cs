using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using WebApplication.Interfaces;

namespace WebApplication.Models
{
    public class BridgesRepository : IBridgesRepository
    {
        private readonly List<IBridge> _bridges = new List<IBridge>()
        {
            new AnnArundel(),
            new PrinceGeorge(),
            new BaltimoreBridge(),
            new HarfordBridge(),
            new CarollBridge()
        };

        public async Task<IBridge> GetBridgeById(int id)
        {
            //todo add tpl here to make  truely async
            IBridge bridge = new NullBridge();
            var result = Task.Factory.StartNew(() =>
            {
                 bridge = _bridges.ElementAt(id);
            });

            await result;
            return bridge;
        }

        public async  Task<IBridge> GetBridgesByName(string name)
        {
            //todo add tpl here to make  truely async
            IBridge bridge = new NullBridge();
            var result = Task.Factory.StartNew(() =>
            {
                bridge = _bridges.FirstOrDefault(b => b.GetType().Name.Equals(name));
            });

            await result;
            return bridge;
        }
    }
}