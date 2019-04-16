using System.Collections.Generic;
using System.ComponentModel;
using TestTypeApp.Client;

namespace TestTypeApp
{
    class ModelManufacture : IBaseModel<CManufacture>
    {
        ManufactureRef.ManufactureServiceClient service;
        BindingList<CManufacture> manufactures;
        List<CManufacture> toSave;
        List<int> toDelete;
        TestTypeApp.Client.Converter<ManufactureRef.manufacture, CManufacture> converter;

        public ModelManufacture(ManufactureRef.ManufactureServiceClient service)
        {
            this.service = service;
            manufactures = new BindingList<CManufacture>();
            toSave = new List<CManufacture>();
            toDelete = new List<int>();
            converter = new TestTypeApp.Client.Converter<ManufactureRef.manufacture, CManufacture>();
            manufactures.ListChanged += ManufacturesListChanged;
        }

        private void ManufacturesListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged | 
                e.ListChangedType == ListChangedType.ItemAdded)
            {
                toSave.Add(manufactures[e.NewIndex]);
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                toDelete.Add(manufactures[e.OldIndex].Id);
            }
        }

        public void Reload()
        {
            manufactures.ListChanged -= ManufacturesListChanged;
            toDelete.Clear();
            toSave.Clear();
            manufactures.Clear();
            converter.toClientType(this.service.readAll())
                .ForEach(n => manufactures.Add(n));
            manufactures.ListChanged += ManufacturesListChanged;
        }

        public void Save()
        {
            service.save(new TestTypeApp.Client.Converter<ManufactureRef.manufacture, CManufacture>().toDto(toSave));
            toDelete.ForEach(n => service.delete(n));
            Reload();
        }

        public BindingList<CManufacture> ItemList
        {
            get
            {
                return manufactures;
            }
            set
            {
                manufactures = value;
            }
        }
    }
}
