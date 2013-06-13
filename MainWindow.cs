using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnfactClicked (object sender, EventArgs e)
	{
		double p1 = double.Parse(this.producto1.Text);
		double p2 = double.Parse(this.producto2.Text);
		double p3 = double.Parse(this.producto3.Text);

		double sub = p1+p2+p3;
		this.subtotal.Text = sub.ToString();

		double iva = sub*.16;
		this.iva.Text = iva.ToString();
				
		double tot = sub+iva;
		this.total.Text = tot.ToString();
	}

	protected void OnBtnlimpClicked (object sender, EventArgs e)
	{
		this.producto1.Text = "";
		this.producto2.Text = "";
		this.producto3.Text = "";
		this.subtotal.Text = "";
		this.iva.Text = "";
		this.total.Text = "";
	}
}
