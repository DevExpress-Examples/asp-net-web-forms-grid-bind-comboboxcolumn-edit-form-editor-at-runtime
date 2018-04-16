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

    End Sub
    Protected Sub grid_CellEditorInitialize(ByVal sender As Object, ByVal e As ASPxGridViewEditorEventArgs)
        If e.Column.FieldName = "CategoryID" Then
            Dim cmb As ASPxComboBox = TryCast(e.Editor, ASPxComboBox)
            cmb.DataSource = dsCombo
            cmb.ValueField = "CategoryID"
            cmb.ValueType = GetType(Int32)
            cmb.TextField = "CategoryName"
            cmb.DataBindItems()
        End If
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
