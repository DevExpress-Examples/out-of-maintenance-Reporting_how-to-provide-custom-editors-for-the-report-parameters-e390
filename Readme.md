# How to provide custom editors for the report parameters


<p>This example illustrates how to change the standard parameter editor to any custom one (in this case the text editor is changed to the drop-down list box, populated from another data source).</p><p>To do this, handle the <strong>XtraReport.ParametersRequestBeforeShow</strong> event, and assign the custom editor to the <strong>e.ParametersInformation[<i>i</i>].Editor</strong> property.</p><p>See also:<br />
- <a href="https://www.devexpress.com/Support/Center/p/E2045">How to cancel parameter submitting if user input validation fails</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E1182">How to conditionally change FormatString</a>.</p>


<h3>Description</h3>

<p>Note that starting from the <strong>v2010 vol 2</strong> version, the default editors are auto-created in accordance with the parameter&#39;s type.</p>

<br/>


