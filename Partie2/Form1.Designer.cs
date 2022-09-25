namespace Partie2;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Save pepole";
        btn1 = new Button();
        btn1.Name = "btn1";
        btn1.Text = "Valider";
        btn1.Location = new System.Drawing.Point(100,100);
        lbl1 = new Label();
        lbl1.Name = "lbl1";
        lbl1.Text = "Nom";
        lbl1.Size = new System.Drawing.Size(40,20);
        lbl1.Location = new System.Drawing.Point(20,20);
        txt1 = new TextBox();
        txt1.Name = "txt1";
        txt1.Location = new System.Drawing.Point(60,20);
        txt2 = new TextBox();
        txt2.Name = "txt2";
        txt2.Location = new System.Drawing.Point(80,60);

        this.Controls.Add(lbl1);
        this.Controls.Add(txt1);
        this.Controls.Add(txt2);
        this.Controls.Add(btn1);
    }

    private Button btn1;
    private TextBox txt1,txt2;
    private Label lbl1;
    #endregion
}
