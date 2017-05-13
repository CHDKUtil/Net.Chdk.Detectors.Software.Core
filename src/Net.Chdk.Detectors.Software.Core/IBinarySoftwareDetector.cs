using Net.Chdk.Model.Software;

namespace Net.Chdk.Detectors.Software
{
    public interface IBinarySoftwareDetector
    {
        SoftwareInfo GetSoftware(SoftwareProductInfo product, SoftwareCameraInfo camera, byte[] buffer);
    }
}
