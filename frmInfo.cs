using System;
using AccessControl;

namespace AccessControl
{
	public partial class frmInfo : Gtk.Window
	{
		DTOConfig dTOConfig;
		public frmInfo (DTOConfig _DTOConfig) : base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			dTOConfig = _DTOConfig;
			fillForm ();
		}
		public void fillForm(){
			D1.Text =dTOConfig.Version;
			D2.Text = dTOConfig.VersionDate;
			D3.Text = dTOConfig.ConnectionString;
			D4.Text = dTOConfig.DeviceName;
			D5.Text = dTOConfig.DeviceUser;
			D6.Text = dTOConfig.HostName;
			D7.Text = dTOConfig.DomainName;
			switch (dTOConfig.IpNum) {
			case 3:
				D10.Text = dTOConfig.Ip [2];
				D9.Text = dTOConfig.Ip [1];
				D8.Text = dTOConfig.Ip [0];
				break;
			case 2:
				D9.Text = dTOConfig.Ip [1];
				D8.Text = dTOConfig.Ip [0];
				break;
			case 1:
				D8.Text = dTOConfig.Ip [0];
				break;
			}
			switch (dTOConfig.MacNum) {
				case 3:
					if(dTOConfig.Mac [2].Length > 0) D13.Text = dTOConfig.Mac [2];
					if(dTOConfig.Mac [1].Length > 0) D12.Text = dTOConfig.Mac [1];
					if(dTOConfig.Mac [0].Length > 0) D11.Text = dTOConfig.Mac [0];
				break;
				case 2:
					if(dTOConfig.Mac [1]!= null) D12.Text = dTOConfig.Mac [1];
					if(dTOConfig.Mac [0]!=null) D11.Text = dTOConfig.Mac [0];
				break;
				case 1:
					if(dTOConfig.Mac [0].Length > 0) D11.Text = dTOConfig.Mac [0];
				break;
			}
		}
		protected void OnBtnExitClicked (object sender, EventArgs e)
		{
			this.Destroy ();
		}
	}
}