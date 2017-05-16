using Net.Chdk.Model.Software;
using System.Collections.Generic;

namespace Net.Chdk.Detectors.Software
{
    public interface IProductBinarySoftwareDetector
    {
        string ProductName { get; }
        IEnumerable<byte[]> Bytes { get; }
        SoftwareInfo GetSoftware(byte[] buffer, int index);
    }
}
