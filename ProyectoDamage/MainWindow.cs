using System;
using Gtk;

using Gdk;
public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnFilechooserwidget1SelectionChanged(object sender, EventArgs e)
    {
        
        Pixbuf pImagen;

            // cargo la imagen en la variable pixbuf
        pImagen = new Pixbuf(Logo.Filename);

            // pongo el pixbuf en el widget Image.
        imaglogo.Pixbuf= pImagen;

            // muestro en el label, la ruta de acceso a la imagen
        entlogo.Text = Logo.Filename;
    }

    protected void OnBtniniciarClicked(object sender, EventArgs e)
    {
    }

    protected void OnBtnsalirClicked(object sender, EventArgs e)
    {
    }
}
