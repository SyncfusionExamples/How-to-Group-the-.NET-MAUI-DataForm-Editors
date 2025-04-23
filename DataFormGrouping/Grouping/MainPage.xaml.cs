using Syncfusion.Maui.DataForm;

namespace Grouping;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void dataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
		if(e.DataFormItem != null)
		{
			if(e.DataFormItem.FieldName=="FirstName"||e.DataFormItem.FieldName=="LastName"||
				e.DataFormItem.FieldName == "MiddleName")
			{
				e.DataFormItem.GroupName = "Name";
			}
		}
		if(e.DataFormGroupItem != null)
		{
			if(e.DataFormGroupItem.Name=="Name")
			{
				e.DataFormGroupItem.HeaderBackground = Color.FromArgb("#D7DDED");
				e.DataFormGroupItem.HeaderTextStyle = new DataFormTextStyle
				{
					FontSize=16,
					FontAttributes=FontAttributes.Bold
				};
			}
		}
		
    }
}

