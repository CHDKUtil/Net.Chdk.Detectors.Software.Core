using Net.Chdk.Model.Software;
using System;
using System.Threading;

namespace Net.Chdk.Detectors.Software
{
    public interface IMetadataModulesDetector
    {
        ModulesInfo GetModules(string basePath, SoftwareInfo software, IProgress<double> progress, CancellationToken token);
    }
}
