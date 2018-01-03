using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elmah.Centralize;

namespace Elmah.BAL
{
    public class MYBal
    {
        public void Test()
        {
            try
            {
                int y = 2, z = 0;
                int x = y / z;
            }
            catch (Exception ex)
            {
                ElmahExtension.LogToElmah(ex);
            }
        }
    }
}
