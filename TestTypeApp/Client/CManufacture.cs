using System.ComponentModel;

namespace TestTypeApp.Client
{
    class CManufacture : Transportable<ManufactureRef.manufacture>, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CManufacture() : base(new ManufactureRef.manufacture())
        { }

        public CManufacture(ManufactureRef.manufacture dto) : base(dto)
        { }
             
        public int Id
        {
            get { return dto.id; }
        }
        public string Name
        {
            get { return dto.name; }
            set { dto.name = value; PropertyChanged(this,new PropertyChangedEventArgs("Name")); }
        }
    }
}
