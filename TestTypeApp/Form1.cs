using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Presenter;
using TestTypeApp.REST;

namespace TestTypeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          //  TypeRef.TestServiceClient service = new TypeRef.TestServiceClient();
          //  ModelType model = new ModelType(service);
          //  TypePresenter presenter = new TypePresenter(model, typeSetupControl1);

            TestRestClient client = new TestRestClient();
            MessageBox.Show(client.DbTest("some text"));
            
        }

        private void typeSetupControl1_Load(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.Show();
        }
    }
}
