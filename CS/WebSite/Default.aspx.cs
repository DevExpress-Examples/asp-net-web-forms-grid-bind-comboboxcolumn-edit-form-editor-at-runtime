using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load (object sender, EventArgs e) {

    }
    protected void grid_CellEditorInitialize (object sender, ASPxGridViewEditorEventArgs e) {
        if (e.Column.FieldName == "CategoryID") {
            ASPxComboBox cmb = e.Editor as ASPxComboBox;
            cmb.DataSource = dsCombo;
            cmb.ValueField = "CategoryID";
            cmb.ValueType = typeof(Int32);
            cmb.TextField = "CategoryName";
            cmb.DataBindItems();
        }
    }
    protected void grid_RowInserting (object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e) {
        throw new Exception("Data modifications are not allowed in the online example.");
    }
    protected void grid_RowUpdating (object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e) {
        throw new Exception("Data modifications are not allowed in the online example.");
    }
}
