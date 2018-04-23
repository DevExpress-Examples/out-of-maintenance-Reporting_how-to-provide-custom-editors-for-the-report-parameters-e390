Imports Microsoft.VisualBasic
Imports System
Namespace CustomParametersForm
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.productsDataSet1 = New CustomParametersForm.ProductsDataSet()
			Me.productsTableAdapter = New CustomParametersForm.ProductsDataSetTableAdapters.ProductsTableAdapter()
			Me.parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
			CType(Me.productsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.Detail.Height = 44
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName", "")})
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.xrLabel1.Location = New System.Drawing.Point(8, 8)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(633, 25)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' productsDataSet1
			' 
			Me.productsDataSet1.DataSetName = "ProductsDataSet"
			Me.productsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' parameter1
			' 
			Me.parameter1.Description = "Category: "
			Me.parameter1.Name = "parameter1"
			Me.parameter1.Type = GetType(System.Int32)
			Me.parameter1.Value = 0
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.productsDataSet1
			Me.FilterString = "[CategoryID] = [Parameters.parameter1]"
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.parameter1})
			Me.Version = "8.2"
'			Me.ParametersRequestBeforeShow += New System.EventHandler(Of DevExpress.XtraReports.Parameters.ParametersRequestEventArgs)(Me.XtraReport1_ParametersRequestBeforeShow);
			CType(Me.productsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private productsDataSet1 As ProductsDataSet
		Private productsTableAdapter As CustomParametersForm.ProductsDataSetTableAdapters.ProductsTableAdapter
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private parameter1 As DevExpress.XtraReports.Parameters.Parameter
	End Class
End Namespace