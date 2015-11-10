using System;
using System.Windows.Forms;
using System.Drawing;
using Inventor;

namespace Shaft
{
	/// <summary>
	/// AddShaftButton class
	/// </summary>
	
	internal class AddShaftButton : Button
	{
		#region "Methods"

		public AddShaftButton(string displayName, string internalName, CommandTypesEnum commandType, string clientId, string description, string tooltip, Icon standardIcon, Icon largeIcon, ButtonDisplayEnum buttonDisplayType)
			: base(displayName, internalName, commandType, clientId, description, tooltip, standardIcon, largeIcon, buttonDisplayType)
		{
			
		}
		public AddShaftButton(string displayName, string internalName, CommandTypesEnum commandType, string clientId, string description, string tooltip, ButtonDisplayEnum buttonDisplayType)
			: base(displayName, internalName, commandType, clientId, description, tooltip, buttonDisplayType)
		{
			
		}

		override protected void ButtonDefinition_OnExecute(NameValueMap context)
		{
			try
			{
                //C:\Users\PC\AppData\Roaming\Autodesk\Inventor 2015\Addins\Shaft\
                //bin\Debug\

                Form_ShaftPparts Form_ShaftDesigner1 = new Form_ShaftPparts();
                Form_ShaftDesigner1.Show();

			}
			catch(Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		}

		#endregion
	}
}
