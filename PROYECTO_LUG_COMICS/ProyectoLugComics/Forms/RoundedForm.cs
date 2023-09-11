using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedForm : Form
{
    public RoundedForm()
    {
        this.FormBorderStyle = FormBorderStyle.None;
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Crear un path de rectángulo redondeado con radio de 5px
        int radio = 5; // Nuevo radio de las esquinas
        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, radio * 2, radio * 2, 180, 90);
        path.AddArc(rect.Right - radio * 2, rect.Y, radio * 2, radio * 2, 270, 90);
        path.AddArc(rect.Right - radio * 2, rect.Bottom - radio * 2, radio * 2, radio * 2, 0, 90);
        path.AddArc(rect.X, rect.Bottom - radio * 2, radio * 2, radio * 2, 90, 90);
        path.CloseAllFigures();

        // Establecer la región del formulario como el path del rectángulo redondeado
        this.Region = new Region(path);

        // No dibujar el círculo rojo en la esquina superior izquierda
    }
}