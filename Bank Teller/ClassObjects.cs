using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Teller
{
    public class ClassObjects
    {
        public static void RemoveResources(ref Control activeControl)
        {
            if (activeControl == null) return;

            activeControl.Dispose();
            activeControl = null;
        }
    }
}
