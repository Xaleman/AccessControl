using System;
using AccessControl;
using Gtk; 

namespace AccessControl
{
	public partial class frmDbInfo : Gtk.Window
	{
		DTOConfig dTOConfig;
		public frmDbInfo (DTOConfig _DTOConfig) : base(Gtk.WindowType.Toplevel)
		{
			dTOConfig = _DTOConfig;
			this.Build ();
			fillForm ();
		}
		public void fillForm()
		{
			D1.Text = dTOConfig.DBServer;
			D2.Text = dTOConfig.DBPort;
			D3.Text = dTOConfig.DBUser;
			D4.Text = dTOConfig.DBPassword;
			D5.Text = dTOConfig.DB;;
			D6.Text = dTOConfig.ConnectionString;
		}
		protected void OnBtnExitClicked (object sender, EventArgs e)
		{
			this.Destroy ();
		}
		protected void OnBtnCheckClicked (object sender, EventArgs e)
		{
			CADConnection connection = new CADConnection (dTOConfig);
			if (connection.checkConnection ()) 
			{
				MessageDialog dialogo;
				dialogo = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "CONEXIÓN CORRECTA");
				dialogo.Run ();
				dialogo.Destroy ();
			}
			else
			{
				MessageDialog dialogo;
				dialogo = new MessageDialog (this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "ERROR DE CONEXIÓN");
				dialogo.Run ();
				dialogo.Destroy ();
			} 
		}
	}
}

