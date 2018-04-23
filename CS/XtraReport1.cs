using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;


namespace CustomParametersForm {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_ParametersRequestBeforeShow(object sender, ParametersRequestEventArgs e) {
            CategoriesDataSet dataSet = new CategoriesDataSet();
            CategoriesDataSetTableAdapters.CategoriesTableAdapter adapter = 
                    new CategoriesDataSetTableAdapters.CategoriesTableAdapter();
            adapter.Fill(dataSet.Categories);

            foreach (ParameterInfo info in e.ParametersInformation) {
                if (info.Parameter.Name == "parameter1") {
                    LookUpEdit lookUpEdit = new LookUpEdit();
                    lookUpEdit.Properties.DataSource = dataSet.Categories;
                    lookUpEdit.Properties.DisplayMember = "CategoryName";
                    lookUpEdit.Properties.ValueMember = "CategoryID";
                    lookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("CategoryName", 0, "Category Name"));
                    lookUpEdit.Properties.NullText = "<Select Category>";

                    info.Editor = lookUpEdit;
                    info.Parameter.Value = DBNull.Value;
                }
            }

        }

    }
}