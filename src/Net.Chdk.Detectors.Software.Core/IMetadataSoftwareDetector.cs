using Net.Chdk.Model.Software;
using System;
using System.Threading;

namespace Net.Chdk.Detectors.Software
{
    public interface IMetadataSoftwareDetector
    {
        SoftwareInfo GetSoftware(string basePath, SoftwareCategoryInfo category, IProgress<double> progress, CancellationToken token);
    }
}
