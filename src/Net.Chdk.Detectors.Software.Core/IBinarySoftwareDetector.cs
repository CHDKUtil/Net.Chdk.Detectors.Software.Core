using Net.Chdk.Model.Software;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Net.Chdk.Detectors.Software
{
    public interface IBinarySoftwareDetector
    {
        IEnumerable<SoftwareInfo> GetSoftware(string basePath, IProgress<double> progress, CancellationToken token);
        bool UpdateSoftware(SoftwareInfo software, byte[] buffer);
    }
}
