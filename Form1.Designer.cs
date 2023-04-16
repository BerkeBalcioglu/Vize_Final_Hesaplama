namespace Kullanıcıdan_Alınan_Değer_vize_final_hesabı
{
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
            components=new System.ComponentModel.Container();
            label1=new Label();
            label2=new Label();
            contextMenuStrip1=new ContextMenuStrip(components);
            ortalama=new TextBox();
            vize=new TextBox();
            final=new TextBox();
            label3=new Label();
            richTextBox1=new RichTextBox();
            button1=new Button();
            label4=new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(26, 38);
            label1.Name="label1";
            label1.Size=new Size(30, 15);
            label1.TabIndex=0;
            label1.Text="VİZE";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(195, 38);
            label2.Name="label2";
            label2.Size=new Size(39, 15);
            label2.TabIndex=1;
            label2.Text="FİNAL";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size(61, 4);
            // 
            // ortalama
            // 
            ortalama.Location=new Point(468, 35);
            ortalama.Name="ortalama";
            ortalama.Size=new Size(100, 23);
            ortalama.TabIndex=3;
            ortalama.TextChanged+=textBox1_TextChanged;
            // 
            // vize
            // 
            vize.Location=new Point(62, 35);
            vize.Name="vize";
            vize.Size=new Size(100, 23);
            vize.TabIndex=4;
            vize.TextChanged+=vize_TextChanged;
            vize.Leave+=textBox2_Leave;
            // 
            // final
            // 
            final.Location=new Point(240, 35);
            final.Name="final";
            final.Size=new Size(100, 23);
            final.TabIndex=5;
            final.TextChanged+=textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(394, 38);
            label3.Name="label3";
            label3.Size=new Size(68, 15);
            label3.TabIndex=6;
            label3.Text="ORTALAMA";
            // 
            // richTextBox1
            // 
            richTextBox1.Location=new Point(45, 162);
            richTextBox1.Name="richTextBox1";
            richTextBox1.Size=new Size(726, 62);
            richTextBox1.TabIndex=7;
            richTextBox1.Text="";
            // 
            // button1
            // 
            button1.Location=new Point(663, 35);
            button1.Name="button1";
            button1.Size=new Size(125, 39);
            button1.TabIndex=8;
            button1.Text="HESAPLA";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(45, 144);
            label4.Name="label4";
            label4.Size=new Size(87, 15);
            label4.TabIndex=9;
            label4.Text="SİSTEM MESAJI";
            label4.Click+=label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(final);
            Controls.Add(vize);
            Controls.Add(ortalama);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="Form1";
            Text="NOT HESAPLAMA";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox ortalama;
        private TextBox vize;
        private TextBox final;
        private Label label3;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label label4;
    }
}