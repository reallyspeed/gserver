using System;
//using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class DrawPane : Form
{
    public double vpx;
    public double vpy;
    public double px;
    public double py;
    public double vel;
    public bool key_a_down;
    public bool key_d_down;
    public bool key_w_down;
    public bool key_s_down;

    public DrawPane()
    {
        //InitializeComponent();

        this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);
        
        this.KeyDown += new KeyEventHandler(H_KeyDown);
        this.KeyUp += new KeyEventHandler(H_KeyUp);
        this.Width = 800;
        this.Height = 600;
        
        this.vpx = 0.0;
        this.vpy = 0.0;
        this.px = this.Width / 2.0;
        this.py = this.Height / 2.0;
        this.vel = 5.0;
        
        this.key_a_down = false;
        this.key_d_down = false;
        this.key_w_down = false;
        this.key_s_down = false;

    }

    public void tick()
    {
        //MessageBox.Show("Test");
        double v = this.vel;

        bool vert = false;
        bool hori = false;
        if (this.key_a_down || this.key_d_down) { hori = true; }
        if (this.key_w_down || this.key_s_down) { vert = true; }
        if (hori && vert) { v = v * 0.71; }
        if (this.key_a_down)
        {
            this.px -= v;
            this.Refresh();
        }
        if (this.key_d_down)
        {
            this.px += v;
            this.Refresh();
        }
        if (this.key_w_down)
        {
            this.py -= v;
            this.Refresh();
        }
        if (this.key_s_down)
        {
            this.py += v;
            this.Refresh();
        }

    }
    
    void H_KeyDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.A:
                this.key_a_down = true;
                break;
            case Keys.D:
                this.key_d_down = true;
                break;
            case Keys.W:
                this.key_w_down = true;
                break;
            case Keys.S:
                this.key_s_down = true;
                break;
        }
        e.Handled = true;
    }

    void H_KeyUp(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.A:
                this.key_a_down = false;
                break;
            case Keys.D:
                this.key_d_down = false;
                break;
            case Keys.W:
                this.key_w_down = false;
                break;
            case Keys.S:
                this.key_s_down = false;
                break;
        }
        e.Handled = true;
    }

    protected void update(int x, int y)
    {
        this.px = x;
        this.py = y;
    }

    protected void draw_elipse(PaintEventArgs e)
    {
        SolidBrush brush = new SolidBrush(Color.FromArgb(35, 66, 49));
        e.Graphics.FillEllipse(brush, (float)this.px, (float)this.py, (float)40.0, (float)40.0);
    }
    
    protected override void OnPaint(PaintEventArgs pe)
    {
        // we draw the progressbar normally 
        // with the flags sets to our settings
        draw_elipse(pe);
    }
}   