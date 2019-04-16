using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.Client
{
   public interface ITransportable <DTOType>
         {
             DTOType ToDTO();
         }
}
