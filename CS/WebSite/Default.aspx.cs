using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load (object sender, EventArgs e) {
        var comboColumn = ((GridViewDataComboBoxColumn)grid.Columns["CategoryID"]);
        comboColumn.PropertiesComboBox.DataSource = dsCombo;
        comboColumn.PropertiesComboBox.TextField = "CategoryName";
        comboColumn.PropertiesComboBox.ValueField = "CategoryID";
        comboColumn.PropertiesComboBox.ValueType = typeof(Int32);
    }

    protected void grid_RowInserting (object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e) {
        throw new CallbackException("Data modifications are not allowed in the online example.");
    }
    protected void grid_RowUpdating (object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e) {
        throw new CallbackException("Data modifications are not allowed in the online example.");
    }
    protected void grid_CustomErrorText(object sender, ASPxGridViewCustomErrorTextEventArgs e)
    {
        if (e.Exception is CallbackException)
            e.ErrorText = e.Exception.Message;
    }
}
