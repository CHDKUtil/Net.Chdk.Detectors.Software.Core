using Net.Chdk.Model.Software;

namespace Net.Chdk.Detectors.Software
{
    public interface IBinarySoftwareDetector
    {
        SoftwareInfo UpdateSoftware(SoftwareInfo software, byte[] buffer);
    }
}
