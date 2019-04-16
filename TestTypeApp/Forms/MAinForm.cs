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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            TypeRef.TypeServiceClient service = new TypeRef.TypeServiceClient();
            //try
            //{
                ModelType model = new ModelType(service);
                TypePresenter presenter = new TypePresenter(model, typeSetupControl1);
            //} catch(System.ServiceModel.EndpointNotFoundException)
            //{
            //    TestRestClient client = new TestRestClient();
            //    MessageBox.Show(client.DbTest("some text"));
            //}
        }

        private void typeSetupControl1_Load(object sender, EventArgs e)
        {
            //ReportForm form = new ReportForm();
            //form.Show();
        }
    }
}
