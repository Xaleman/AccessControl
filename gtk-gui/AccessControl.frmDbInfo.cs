
// This file has been generated by the GUI designer. Do not modify.
namespace AccessControl
{
	public partial class frmDbInfo
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label lb1;
		private global::Gtk.Label D1;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label lb2;
		private global::Gtk.Label D2;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Label lb5;
		private global::Gtk.Label D5;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label lb3;
		private global::Gtk.Label D3;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Label lb4;
		private global::Gtk.Label D4;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Label lb6;
		private global::Gtk.Label D6;
		private global::Gtk.Button btnCheck;
		private global::Gtk.Button btnExit;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget AccessControl.frmDbInfo
			this.Name = "AccessControl.frmDbInfo";
			this.Title = global::Mono.Unix.Catalog.GetString ("Información de la base de datos.");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child AccessControl.frmDbInfo.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.lb1 = new global::Gtk.Label ();
			this.lb1.WidthRequest = 150;
			this.lb1.Name = "lb1";
			this.lb1.Xalign = 0F;
			this.lb1.LabelProp = global::Mono.Unix.Catalog.GetString ("Servidor:");
			this.hbox1.Add (this.lb1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.lb1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			w1.Padding = ((uint)(5));
			// Container child hbox1.Gtk.Box+BoxChild
			this.D1 = new global::Gtk.Label ();
			this.D1.Name = "D1";
			this.D1.Xalign = 0F;
			this.D1.LabelProp = global::Mono.Unix.Catalog.GetString ("...");
			this.hbox1.Add (this.D1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.D1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.lb2 = new global::Gtk.Label ();
			this.lb2.WidthRequest = 150;
			this.lb2.Name = "lb2";
			this.lb2.Xalign = 0F;
			this.lb2.LabelProp = global::Mono.Unix.Catalog.GetString ("Puerto:");
			this.hbox2.Add (this.lb2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.lb2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(5));
			// Container child hbox2.Gtk.Box+BoxChild
			this.D2 = new global::Gtk.Label ();
			this.D2.Name = "D2";
			this.D2.Xalign = 0F;
			this.D2.LabelProp = global::Mono.Unix.Catalog.GetString ("...");
			this.hbox2.Add (this.D2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.D2]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.lb5 = new global::Gtk.Label ();
			this.lb5.WidthRequest = 150;
			this.lb5.Name = "lb5";
			this.lb5.Xalign = 0F;
			this.lb5.LabelProp = global::Mono.Unix.Catalog.GetString ("DB:");
			this.hbox5.Add (this.lb5);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.lb5]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			w7.Padding = ((uint)(5));
			// Container child hbox5.Gtk.Box+BoxChild
			this.D5 = new global::Gtk.Label ();
			this.D5.Name = "D5";
			this.D5.Xalign = 0F;
			this.D5.LabelProp = global::Mono.Unix.Catalog.GetString ("...");
			this.hbox5.Add (this.D5);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.D5]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox1.Add (this.hbox5);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox5]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.lb3 = new global::Gtk.Label ();
			this.lb3.WidthRequest = 150;
			this.lb3.Name = "lb3";
			this.lb3.Xalign = 0F;
			this.lb3.LabelProp = global::Mono.Unix.Catalog.GetString ("Usuario:");
			this.hbox3.Add (this.lb3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.lb3]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			w10.Padding = ((uint)(5));
			// Container child hbox3.Gtk.Box+BoxChild
			this.D3 = new global::Gtk.Label ();
			this.D3.Name = "D3";
			this.D3.Xalign = 0F;
			this.D3.LabelProp = global::Mono.Unix.Catalog.GetString ("...");
			this.hbox3.Add (this.D3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.D3]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.lb4 = new global::Gtk.Label ();
			this.lb4.WidthRequest = 150;
			this.lb4.Name = "lb4";
			this.lb4.Xalign = 0F;
			this.lb4.LabelProp = global::Mono.Unix.Catalog.GetString ("Contraseña:");
			this.hbox4.Add (this.lb4);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.lb4]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			w13.Padding = ((uint)(5));
			// Container child hbox4.Gtk.Box+BoxChild
			this.D4 = new global::Gtk.Label ();
			this.D4.Name = "D4";
			this.D4.Xalign = 0F;
			this.D4.LabelProp = global::Mono.Unix.Catalog.GetString ("...");
			this.hbox4.Add (this.D4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.D4]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox1.Add (this.hbox4);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox4]));
			w15.Position = 4;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.lb6 = new global::Gtk.Label ();
			this.lb6.WidthRequest = 150;
			this.lb6.Name = "lb6";
			this.lb6.Xalign = 0F;
			this.lb6.LabelProp = global::Mono.Unix.Catalog.GetString ("Cdena conexión:");
			this.hbox6.Add (this.lb6);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.lb6]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			w16.Padding = ((uint)(5));
			// Container child hbox6.Gtk.Box+BoxChild
			this.D6 = new global::Gtk.Label ();
			this.D6.Name = "D6";
			this.D6.Xalign = 0F;
			this.D6.LabelProp = global::Mono.Unix.Catalog.GetString ("...");
			this.hbox6.Add (this.D6);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.D6]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox1.Add (this.hbox6);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox6]));
			w18.Position = 5;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.btnCheck = new global::Gtk.Button ();
			this.btnCheck.HeightRequest = 80;
			this.btnCheck.CanFocus = true;
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.UseUnderline = true;
			// Container child btnCheck.Gtk.Container+ContainerChild
			global::Gtk.Alignment w19 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w20 = new global::Gtk.HBox ();
			w20.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w21 = new global::Gtk.Image ();
			w21.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-connect", global::Gtk.IconSize.Menu);
			w20.Add (w21);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w23 = new global::Gtk.Label ();
			w23.LabelProp = global::Mono.Unix.Catalog.GetString ("  Comprobar la conexión");
			w23.UseUnderline = true;
			w20.Add (w23);
			w19.Add (w20);
			this.btnCheck.Add (w19);
			this.vbox1.Add (this.btnCheck);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.btnCheck]));
			w27.Position = 6;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.btnExit = new global::Gtk.Button ();
			this.btnExit.HeightRequest = 80;
			this.btnExit.CanFocus = true;
			this.btnExit.Name = "btnExit";
			this.btnExit.UseUnderline = true;
			// Container child btnExit.Gtk.Container+ContainerChild
			global::Gtk.Alignment w28 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w29 = new global::Gtk.HBox ();
			w29.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w30 = new global::Gtk.Image ();
			w30.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-quit", global::Gtk.IconSize.Menu);
			w29.Add (w30);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w32 = new global::Gtk.Label ();
			w32.LabelProp = global::Mono.Unix.Catalog.GetString ("  Salir");
			w32.UseUnderline = true;
			w29.Add (w32);
			w28.Add (w29);
			this.btnExit.Add (w28);
			this.vbox1.Add (this.btnExit);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.btnExit]));
			w36.Position = 7;
			w36.Expand = false;
			w36.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 328;
			this.Show ();
			this.btnCheck.Clicked += new global::System.EventHandler (this.OnBtnCheckClicked);
			this.btnExit.Clicked += new global::System.EventHandler (this.OnBtnExitClicked);
		}
	}
}
