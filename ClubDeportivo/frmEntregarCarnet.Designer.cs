using System.Windows.Forms;

namespace ClubDeportivo
{
    partial class frmEntregarCarnet : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox3 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(437, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(168, 23);
            textBox3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(264, 168);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(117, 15);
            label4.TabIndex = 10;
            label4.Text = "Numero Documento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(437, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(72, 23);
            comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(264, 124);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 15);
            label3.TabIndex = 8;
            label3.Text = "Tipo documento";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(599, 246);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(204, 23);
            button2.TabIndex = 15;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(131, 246);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(204, 23);
            button1.TabIndex = 14;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmEntragarCarnet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(919, 330);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Name = "frmEntragarCarnet";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}