using Net.Chdk.Model.Card;
using Net.Chdk.Model.Software;
using System;

namespace Net.Chdk.Detectors.Software
{
    public interface ISoftwareDetector
    {
        SoftwareInfo GetSoftware(CardInfo cardInfo, IProgress<double> progress);
    }
}
