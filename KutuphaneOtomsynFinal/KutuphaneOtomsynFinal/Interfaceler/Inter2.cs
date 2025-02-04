using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomsynFinal.Interfaceler
{
  public   interface Inter2
    {
        void Delete(int uyeID);
        DataTable GetByID(int uyeid);
        
    }
}
