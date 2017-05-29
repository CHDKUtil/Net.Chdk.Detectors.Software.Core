using Net.Chdk.Model.Card;
using Net.Chdk.Model.Software;

namespace Net.Chdk.Detectors.Software
{
    public interface IModulesDetector
    {
        ModulesInfo GetModules(CardInfo card, SoftwareInfo software);
    }
}
