<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.ProductsDataSet1 = New CustomParametersForm.ProductsDataSet
        Me.ProductsTableAdapter = New CustomParametersForm.ProductsDataSetTableAdapters.ProductsTableAdapter
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Parameter1 = New DevExpress.XtraReports.Parameters.Parameter
        CType(Me.ProductsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
        Me.Detail.Height = 46
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ProductsDataSet1
        '
        Me.ProductsDataSet1.DataSetName = "ProductsDataSet"
        Me.ProductsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'xrLabel1
        '
        Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName", "")})
        Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.xrLabel1.Location = New System.Drawing.Point(0, 8)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.Size = New System.Drawing.Size(633, 25)
        Me.xrLabel1.Text = "xrLabel1"
        '
        'Parameter1
        '
        Me.Parameter1.Description = "Category: "
        Me.Parameter1.Name = "Parameter1"
        Me.Parameter1.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.Int32
        Me.Parameter1.Value = 0
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
        Me.DataAdapter = Me.ProductsTableAdapter
        Me.DataMember = "Products"
        Me.DataSource = Me.ProductsDataSet1
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Parameter1})
        Me.Version = "8.2"
        CType(Me.ProductsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ProductsDataSet1 As CustomParametersForm.ProductsDataSet
    Friend WithEvents ProductsTableAdapter As CustomParametersForm.ProductsDataSetTableAdapters.ProductsTableAdapter
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Parameter1 As DevExpress.XtraReports.Parameters.Parameter
End Class
