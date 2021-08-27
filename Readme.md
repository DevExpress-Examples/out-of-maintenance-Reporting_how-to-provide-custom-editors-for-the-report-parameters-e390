<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602882/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E390)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to provide custom editors for the report parameters


<p>This example illustrates how to change the standard parameter editor to any custom one (in this case the text editor is changed to the drop-down list box, populated from another data source).</p><p>To do this, handle the <strong>XtraReport.ParametersRequestBeforeShow</strong> event, and assign the custom editor to the <strong>e.ParametersInformation[<i>i</i>].Editor</strong> property.</p><p>See also:<br />
- <a href="https://www.devexpress.com/Support/Center/p/E2045">How to cancel parameter submitting if user input validation fails</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1182">How to conditionally change FormatString</a>.</p>


<h3>Description</h3>

<p>Note that starting from the <strong>v2010 vol 2</strong> version, the default editors are auto-created in accordance with the parameter&#39;s type.</p>

<br/>


