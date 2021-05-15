using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Torch;
using Torch.API;

namespace PluginTest
{
    public class TestPlugin : TorchPluginBase
    {
        public static readonly Logger log = LogManager.GetCurrentClassLogger();

        public override void Init(ITorchBase torch)
        {
            base.Init(torch);
            log.Info("Logger test.");
        }
    }
}
