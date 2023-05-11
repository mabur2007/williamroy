using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
   public interface IDraggable
    {
        public void StartDrag(DataTransferSettings settings);
        public DataTransferSettings GetSettings();
    }
}
