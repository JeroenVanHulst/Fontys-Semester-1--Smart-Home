using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakSmartHome.Classes
{
    interface IDatabaseObject
    {
        int Id { get; set; }
        string Name { get; set; }

        void Update();
        void Remove();
        void Insert();
    }
}
