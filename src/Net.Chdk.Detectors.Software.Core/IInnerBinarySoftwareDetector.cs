using Net.Chdk.Model.Software;
using System.Collections.Generic;

namespace Net.Chdk.Detectors.Software
{
    public interface IInnerBinarySoftwareDetector
    {
        string ProductName { get; }
        IEnumerable<byte[]> Bytes { get; }
        SoftwareInfo GetSoftware(byte[] buffer, int index);
    }
}
