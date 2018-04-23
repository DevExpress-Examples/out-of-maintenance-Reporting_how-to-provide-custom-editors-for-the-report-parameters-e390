Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters


Namespace CustomParametersForm
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XtraReport1_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As ParametersRequestEventArgs) Handles MyBase.ParametersRequestBeforeShow
			Dim dataSet As New CategoriesDataSet()
			Dim adapter As New CategoriesDataSetTableAdapters.CategoriesTableAdapter()
			adapter.Fill(dataSet.Categories)

			For Each info As ParameterInfo In e.ParametersInformation
				If info.Parameter.Name = "parameter1" Then
					Dim lookUpEdit As New LookUpEdit()
					lookUpEdit.Properties.DataSource = dataSet.Categories
					lookUpEdit.Properties.DisplayMember = "CategoryName"
					lookUpEdit.Properties.ValueMember = "CategoryID"
					lookUpEdit.Properties.Columns.Add(New LookUpColumnInfo("CategoryName", 0, "Category Name"))
					lookUpEdit.Properties.NullText = "<Select Category>"

					info.Editor = lookUpEdit
					info.Parameter.Value = DBNull.Value
				End If
			Next info

		End Sub

	End Class
End Namespace
