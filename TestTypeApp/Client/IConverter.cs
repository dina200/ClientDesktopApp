using System.Collections.Generic;

namespace TestTypeApp.Client
{
    interface IConverter<DTOType, ClientType>
    {
        DTOType[] toDto(IList<ClientType> list);
        List<ClientType> toClientType(DTOType[] dtoArray);
    }
}
