using Net.Chdk.Model.Card;
using Net.Chdk.Model.Software;
using System;
using System.Threading;

namespace Net.Chdk.Detectors.Software
{
    public interface IModulesDetector
    {
        ModulesInfo GetModules(CardInfo card, SoftwareInfo software, IProgress<double> progress, CancellationToken token);
    }
}
