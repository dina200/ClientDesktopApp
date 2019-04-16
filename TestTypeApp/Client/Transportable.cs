using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.Client
{
   public class Transportable<DTO> : ITransportable<DTO>
    {
        protected DTO dto;

        public Transportable(DTO dto)
        {
            this.dto = dto;
        }

        public DTO ToDTO()
        {
           return this.dto;
        }
    }
}
