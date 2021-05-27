using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class DBConnection
    {
        public static MenuEntities1 Entities { get; } = new MenuEntities1();
    }
}
