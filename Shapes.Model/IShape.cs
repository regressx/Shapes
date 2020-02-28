using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    public interface IShape
    {
        int Width { get; }
        int Height { get;}

        Image Draw();
    }
}
