
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

void draw_elipse(PaintEventArgs e)
{
    Pen pen = new Pen(Color.Aquamarine,2);
    SolidBrush brush = new SolidBrush(Color.Aquamarine);

    e.Graphics.DrawEllipse(pen, 10, 10, 100, 20);
    e.Graphics.FillEllipse(brush, 10, 50, 100, 20);
}

public class DrawPane : Control
{
    public DrawPane()
    {
        InitializeComponent();

        this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);
		
		this.Width = 800
		this.Height = 600
		
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        // we draw the progressbar normally 
        // with the flags sets to our settings
        draw_elipse(pe.Graphics);
    }
}	
	


