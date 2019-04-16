using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.Client
{
    public class Converter<DTOType, ClientType> : IConverter<DTOType, ClientType> where ClientType : Transportable<DTOType>
    {

        public DTOType[] toDto(IList<ClientType> list)
        {
            List<DTOType> res = new List<DTOType>();
            foreach (ClientType type in list)
            {
                res.Add(type.ToDTO());
            }
            return res.ToArray();
        }

        public List<ClientType> toClientType(DTOType[] dtoArray)
        {   
            List<ClientType> res = new List<ClientType>();
            List<DTOType> list = dtoArray.ToList();
            list.ForEach(n => res.Add((ClientType)Activator.CreateInstance(typeof(ClientType), new object[] {n})));
            return res;
        }
    }
}
