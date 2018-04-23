Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters


Public Class XtraReport1

    Private Sub XtraReport1_ParametersRequestBeforeShow(ByVal sender As System.Object, ByVal e As ParametersRequestEventArgs) _
    Handles MyBase.ParametersRequestBeforeShow
        Dim DataSet As New CategoriesDataSet()
        Dim Adapter As New CategoriesDataSetTableAdapters.CategoriesTableAdapter()
        Adapter.Fill(DataSet.Categories)

        Dim Info As ParameterInfo

        For Each Info In e.ParametersInformation
            If Info.Parameter.Name = "Parameter1" Then
                Dim LookUpEdit As New LookUpEdit()
                LookUpEdit.Properties.DataSource = DataSet.Categories
                LookUpEdit.Properties.DisplayMember = "CategoryName"
                LookUpEdit.Properties.ValueMember = "CategoryID"
                LookUpEdit.Properties.Columns.Add(New LookUpColumnInfo("CategoryName", 0, "Category Name"))
                LookUpEdit.Properties.NullText = "<Select Category>"

                Info.Editor = LookUpEdit
                Info.Parameter.Value = DBNull.Value
            End If
        Next Info

    End Sub

End Class