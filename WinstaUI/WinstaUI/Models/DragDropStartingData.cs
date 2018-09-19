using System.Collections.Generic;

using Windows.ApplicationModel.DataTransfer;

namespace WinstaUI.Models
{
    public class DragDropStartingData
    {
        public DataPackage Data { get; set; }

        public IList<object> Items { get; set; }
    }
}
