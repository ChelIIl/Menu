using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class DBConnection
    {
        public static MenuEntities Entities { get; } = new MenuEntities();
    }
}
