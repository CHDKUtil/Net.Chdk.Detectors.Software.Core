using Net.Chdk.Model.Software;
using System.Collections.Generic;

namespace Net.Chdk.Detectors.Software
{
    public interface IInnerBinarySoftwareDetector
    {
        IEnumerable<byte[]> Bytes { get; }
        SoftwareInfo GetSoftware(byte[] buffer, int index);
    }
}
