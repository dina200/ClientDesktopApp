using System.Collections.Generic;
using System.ComponentModel;
using TestTypeApp.Client;

namespace TestTypeApp
{
    class ModelMaterial : IBaseModel<CMaterial>
    {
        MaterialRef.MaterialServiceClient service;
        BindingList<CMaterial> materials;
        List<CMaterial> toSave;
        List<int> toDelete;
        TestTypeApp.Client.Converter<MaterialRef.material, CMaterial> converter;

        public ModelMaterial(MaterialRef.MaterialServiceClient service)
        {
            this.service = service;
            materials = new BindingList<CMaterial>();
            toSave = new List<CMaterial>();
            toDelete = new List<int>();
            converter = new TestTypeApp.Client.Converter<MaterialRef.material, CMaterial>();
            materials.ListChanged += MaterialsListChanged;
        }

        private void MaterialsListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged | 
                e.ListChangedType == ListChangedType.ItemAdded)
            {
                toSave.Add(materials[e.NewIndex]);
            }
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                toDelete.Add(materials[e.OldIndex].Id);
            }
        }

        public void Reload()
        {
            materials.ListChanged -= MaterialsListChanged;
            toDelete.Clear();
            toSave.Clear();
            materials.Clear();
            converter.toClientType(this.service.readAll())
                .ForEach(n => materials.Add(n));
            materials.ListChanged += MaterialsListChanged;
        }

        public void Save()
        {
            service.save(new TestTypeApp.Client.Converter<MaterialRef.material, CMaterial>().toDto(toSave));
            toDelete.ForEach(n => service.delete(n));
            Reload();
        }

        public BindingList<CMaterial> ItemList
        {
            get
            {
                return materials;
            }
            set
            {
                materials = value;
            }
        }
    }
}
