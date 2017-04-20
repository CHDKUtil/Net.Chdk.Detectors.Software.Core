using Net.Chdk.Model.Card;
using Net.Chdk.Model.Software;

namespace Net.Chdk.Detectors.Software
{
    public interface ISoftwareDetector
    {
        SoftwareInfo GetSoftware(CardInfo cardInfo);
    }
}
