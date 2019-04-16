using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeApp.Client
{
   public class CType : Transportable<TypeRef.type>, INotifyPropertyChanged 
    {

        public CType():base(new TypeRef.type())
        {  }

        public CType(TypeRef.type type):base(type)
        {  }

        public int Id
        {
            get { return dto.id; }
        }
        public string Name
        {
            get { return dto.name; }
            set { dto.name = value; PropertyChanged(this,new PropertyChangedEventArgs("Name")); }
        }
   
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
