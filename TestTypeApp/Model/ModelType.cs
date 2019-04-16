using System.Collections.Generic;
using System.ComponentModel;
using TestTypeApp.Client;

namespace TestTypeApp
{
    class ModelType : IBaseModel<CType>
    {
        TypeRef.TypeServiceClient service;
        BindingList<CType> types;
        List<CType> toSave;
        List<int> toDelete;
        TestTypeApp.Client.Converter<TypeRef.type, CType> converter;

        public ModelType(TypeRef.TypeServiceClient service)
        {
            this.service = service;
            types = new BindingList<CType>();
            toSave = new List<CType>();
            toDelete = new List<int>();
            converter = new TestTypeApp.Client.Converter<TypeRef.type, CType>();
            types.ListChanged += types_ListChanged;
        }

        private void types_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged | 
                e.ListChangedType == ListChangedType.ItemAdded)
            {
                toSave.Add(types[e.NewIndex]);
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                toDelete.Add(types[e.OldIndex].Id);
            }
        }

        public void Reload()
        {
            types.ListChanged -= types_ListChanged;
            toDelete.Clear();
            toSave.Clear();
            types.Clear();
            converter.toClientType(this.service.readAll())
                .ForEach(n => types.Add(n));
            types.ListChanged += types_ListChanged;
        }

        public void Save()
        {
            service.save(new TestTypeApp.Client.Converter<TypeRef.type, CType>().toDto(toSave));
            toDelete.ForEach(n => service.delete(n));
            Reload();
        }

        public BindingList<CType> ItemList
        {
            get
            {
                return types;
            }
            set
            {
                types = value;
            }
        }
    }
}
