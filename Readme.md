<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128533412/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3591)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Grid View for ASP.NET Web Forms - How to bind GridViewDataComboBoxColumn Edit Form editor at runtime

<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3591/)**
<!-- run online end -->


This example illustrates how to populate a [GridViewDataComboBoxColumn](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewDataComboBoxColumn?p=netframework) with data and set its properties at runtime.

![A grid with an edit form](images/grid-with-edit-form.png)

Use the [GridViewDataComboBoxColumn.PropertiesComboBox](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewDataComboBoxColumn.PropertiesComboBox) property to access and customize the column editor's settings:

```cs
protected void Page_Load(object sender, EventArgs e) {
    var comboColumn = ((GridViewDataComboBoxColumn)grid.Columns["CategoryID"]);
    comboColumn.PropertiesComboBox.DataSource = dsCombo;
    comboColumn.PropertiesComboBox.TextField = "CategoryName";
    comboColumn.PropertiesComboBox.ValueField = "CategoryID";
    comboColumn.PropertiesComboBox.ValueType = typeof(Int32);
}
```

**Note:** The [ComboBoxProperties.ValueType](https://docs.devexpress.com/AspNet/DevExpress.Web.ComboBoxProperties.ValueType) should be set according to the [Data Type Mappings (ADO.NET)](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings) table.



## Files to Look At

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))

## Documentation

* [ASPxGridView](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView)
* [Grid View - Examples](https://docs.devexpress.com/AspNet/3768/components/grid-view/examples)

## More Examples