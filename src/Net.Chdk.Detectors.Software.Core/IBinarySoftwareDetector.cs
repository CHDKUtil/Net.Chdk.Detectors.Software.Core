using Net.Chdk.Model.Software;
using System;
using System.Threading;

namespace Net.Chdk.Detectors.Software
{
    public interface IBinarySoftwareDetector
    {
        SoftwareInfo GetSoftware(string basePath, IProgress<double> progress, CancellationToken token);
        SoftwareInfo UpdateSoftware(SoftwareInfo software, byte[] buffer);
    }
}
