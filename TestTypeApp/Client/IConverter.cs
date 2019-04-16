using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.Client
{
    interface IConverter<DTOType, ClientType>
    {
        DTOType[] toDto(IList<ClientType> list);
        List<ClientType> toClientType(DTOType[] dtoArray);
    }
}
