using Net.Chdk.Model.Software;
using System;

namespace Net.Chdk.Detectors.Software
{
    public interface IBinarySoftwareDetector
    {
        SoftwareInfo GetSoftware(string basePath, IProgress<double> progress);
        SoftwareInfo UpdateSoftware(SoftwareInfo software, byte[] buffer);
    }
}
