using Net.Chdk.Model.Software;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Chdk.Detectors.Software
{
    public interface IBinarySoftwareDetector
    {
        SoftwareInfo GetSoftware(SoftwareProductInfo product, SoftwareCameraInfo camera, byte[] buffer);
    }
}
