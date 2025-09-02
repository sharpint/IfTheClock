using System;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{
    private System.Windows.Forms.Timer timer1;
    private Label label1;

    public Form1()
    {
        this.Text = "IfTheClock Build 100010";
        this.Size = new Size(400, 200);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.BackColor = Color.Black;

        label1 = new Label();
        label1.Font = new Font("Berlin Sans FB", 24);
        label1.ForeColor = Color.LimeGreen;
        label1.Dock = DockStyle.Fill;
        label1.TextAlign = ContentAlignment.MiddleCenter;
        this.Controls.Add(label1);

        timer1 = new System.Windows.Forms.Timer();
        timer1.Interval = 100; // Actualiza cada 100 ms para milisegundos
        timer1.Tick += Timer1_Tick;
        timer1.Start();
    }

    private void Timer1_Tick(object? sender, EventArgs e)
    {
        label1.Text = DateTime.Now.ToString("HH:mm:ss");
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            timer1?.Dispose();
            label1?.Dispose();
        }
        base.Dispose(disposing);
    }
}
