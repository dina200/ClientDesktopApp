using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Client;

namespace TestTypeApp.View
{
    public partial class TypeControl : UserControl
    {
        public TypeControl()
        {
            InitializeComponent();
        }

        CType type;
        public CType DataSource
        {
            set 
            {
                if (value != null && type != value)
                {
                    if (type!=null) type.PropertyChanged -= type_PropertyChanged;
                    type = value;
                    typeNameEdit.Text = type.Name;
                    type.PropertyChanged += type_PropertyChanged;
                }
            }
            get { return type; }
        }

        private void type_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name")
            {
                typeNameEdit.Text = type.Name;
            }
            else
            {
                throw new NotImplementedException("Unsupported property: " + e.PropertyName);
            }
            
        }

        private void typeNameEdit_EditValueChanged(object sender, EventArgs e)
        {
             type.Name = typeNameEdit.Text;
        }
    }
}
