using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSWatcher.Models {
    public enum FileEventTypes {
        Deleted,
        Modified,
        Created,
        Renamed
    }
}
