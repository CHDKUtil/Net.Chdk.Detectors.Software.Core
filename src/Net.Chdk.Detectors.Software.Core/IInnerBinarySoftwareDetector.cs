using Net.Chdk.Model.Software;
using System;
using System.Threading;

namespace Net.Chdk.Detectors.Software
{
    public interface IInnerBinarySoftwareDetector
    {
        SoftwareInfo GetSoftware(string basePath, IProgress<double> progress, CancellationToken token);
        bool UpdateSoftware(ref SoftwareInfo software, byte[] buffer);
    }
}
