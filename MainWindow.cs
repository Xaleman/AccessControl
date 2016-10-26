using System;
using Gtk;
using AccessControl;


public partial class MainWindow: Gtk.Window
{	AccessControl.DTOConfig dTOConfig;
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		int Idx;

		Build ();
		dTOConfig = new DTOConfig ();
		InfoText.Buffer.Text = "Versión :\t\t" + dTOConfig.Version;
		InfoText.Buffer.Text += "\nFecha de versión :\t\t" + dTOConfig.VersionDate;
		InfoText.Buffer.Text += "\nCadena de conexión:\t\t" + dTOConfig.ConnectionString;
		InfoText.Buffer.Text += "\nNombre dispositivo :\t\t" + dTOConfig.DeviceName;
		InfoText.Buffer.Text += "\nUsuario del dispositivo :\t\t" + dTOConfig.DeviceUser;
		InfoText.Buffer.Text += "\nNombre de host :\t\t" + dTOConfig.HostName;
		InfoText.Buffer.Text += "\nNombre de dominio :\t\t" + dTOConfig.DomainName;
		InfoText.Buffer.Text += "\nIP Num :\t\t" + dTOConfig.IpNum.ToString();
		for (Idx=0; Idx<dTOConfig.IpNum; Idx++) {
			InfoText.Buffer.Text += "\nIP :\t\t" + dTOConfig.Ip[Idx];
		}
		InfoText.Buffer.Text += "\nMAC Num :\t\t" + dTOConfig.MacNum.ToString();
		for (Idx=0; Idx<dTOConfig.MacNum; Idx++) {
			InfoText.Buffer.Text += "\nMAC :\t\t" + dTOConfig.Mac[Idx];
		}
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void onInfoEvent (object sender, EventArgs e)
	{
		frmInfo Info = new frmInfo (dTOConfig);
		Info.Show();

		throw new NotImplementedException ();
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		new AccessControl.frmInfo (dTOConfig);
		//throw new NotImplementedException ();
	}
	protected void OnInformacinDelSistemaActionActivated (object sender, EventArgs e)
	{
		new AccessControl.frmInfo (dTOConfig);
		//throw new NotImplementedException ();
	}



	protected void OnInformacinDeLaBaseDeDatosActionActivated (object sender, EventArgs e)
	{
		new AccessControl.frmDbInfo (dTOConfig);
		//throw new NotImplementedException ();
	}
	/*protected void OnInformacinDeLaBaseDeDatosActionActivated (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}*/
}
