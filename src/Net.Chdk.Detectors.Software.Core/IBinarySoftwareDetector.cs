using Net.Chdk.Model.Software;

namespace Net.Chdk.Detectors.Software
{
    public interface IBinarySoftwareDetector
    {
        SoftwareInfo GetSoftware(string basePath);
        SoftwareInfo UpdateSoftware(SoftwareInfo software, byte[] buffer);
    }
}
