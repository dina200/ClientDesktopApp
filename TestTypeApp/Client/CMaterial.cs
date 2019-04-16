using System.ComponentModel;

namespace TestTypeApp.Client
{
    class CMaterial : Transportable<MaterialRef.material>, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CMaterial() : base(new MaterialRef.material())
        { }

        public CMaterial(MaterialRef.material dto) : base(dto)
        { }

        public int Id
        {
            get { return dto.id; }
        }
        public string Name
        {
            get { return dto.name; }
            set { dto.name = value; PropertyChanged(this, new PropertyChangedEventArgs("Name")); }
        }
    }
}
