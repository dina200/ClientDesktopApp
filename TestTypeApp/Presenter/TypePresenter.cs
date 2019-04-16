using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTypeApp.Client;
using TestTypeApp.View;

namespace TestTypeApp.Presenter
{
    class TypePresenter : IPresenter
    {
        IBaseModel<CType> model;
        IItemView<CType> view;
        CType current;

        public TypePresenter(IBaseModel<CType> model, IItemView<CType> view)
        {
            this.model = model;
            this.view = view;
            model.Reload();
            view.ItemList = model.ItemList;
            view.Refresh += view_Refresh;
            view.Save += view_Save;
        }

        void view_Save(object sender, EventArgs e)
        {
            model.Save();
        }

        void view_Refresh(object sender, EventArgs e)
        {
            current = view.CurrentItem;
            model.Reload();
            view.CurrentItem = model.ItemList.First(n => n.Id == current.Id);
        }

    }
}
