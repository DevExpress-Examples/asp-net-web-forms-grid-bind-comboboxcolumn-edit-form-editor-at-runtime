Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim comboColumn = (CType(grid.Columns("CategoryID"), GridViewDataComboBoxColumn))
        comboColumn.PropertiesComboBox.DataSource = dsCombo
        comboColumn.PropertiesComboBox.TextField = "CategoryName"
        comboColumn.PropertiesComboBox.ValueField = "CategoryID"
        comboColumn.PropertiesComboBox.ValueType = GetType(Int32)
    End Sub

    Protected Sub grid_RowInserting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInsertingEventArgs)
        Throw New CallbackException("Data modifications are not allowed in the online example.")
    End Sub
    Protected Sub grid_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs)
        Throw New CallbackException("Data modifications are not allowed in the online example.")
    End Sub
    Protected Sub grid_CustomErrorText(ByVal sender As Object, ByVal e As ASPxGridViewCustomErrorTextEventArgs)
        If TypeOf e.Exception Is CallbackException Then
            e.ErrorText = e.Exception.Message
        End If
    End Sub
End Class
