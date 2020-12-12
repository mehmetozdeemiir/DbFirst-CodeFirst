
namespace Lab2_DatabaseFirst_Example2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnornek1 = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.btnornek3 = new System.Windows.Forms.Button();
            this.btnornek4 = new System.Windows.Forms.Button();
            this.btnornek5 = new System.Windows.Forms.Button();
            this.btnornek6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnornek1
            // 
            this.btnornek1.BackColor = System.Drawing.Color.Maroon;
            this.btnornek1.Location = new System.Drawing.Point(12, 47);
            this.btnornek1.Name = "btnornek1";
            this.btnornek1.Size = new System.Drawing.Size(104, 44);
            this.btnornek1.TabIndex = 0;
            this.btnornek1.Text = "Örnek1";
            this.btnornek1.UseVisualStyleBackColor = false;
            this.btnornek1.Click += new System.EventHandler(this.btnornek1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.BackColor = System.Drawing.Color.Orchid;
            this.btnOrnek2.Location = new System.Drawing.Point(141, 24);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(105, 44);
            this.btnOrnek2.TabIndex = 1;
            this.btnOrnek2.Text = "Örnek 2";
            this.btnOrnek2.UseVisualStyleBackColor = false;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // btnornek3
            // 
            this.btnornek3.BackColor = System.Drawing.Color.Brown;
            this.btnornek3.Location = new System.Drawing.Point(273, 47);
            this.btnornek3.Name = "btnornek3";
            this.btnornek3.Size = new System.Drawing.Size(104, 44);
            this.btnornek3.TabIndex = 0;
            this.btnornek3.Text = "Örnek 3";
            this.btnornek3.UseVisualStyleBackColor = false;
            this.btnornek3.Click += new System.EventHandler(this.btnornek3_Click);
            // 
            // btnornek4
            // 
            this.btnornek4.BackColor = System.Drawing.Color.Firebrick;
            this.btnornek4.Location = new System.Drawing.Point(411, 24);
            this.btnornek4.Name = "btnornek4";
            this.btnornek4.Size = new System.Drawing.Size(105, 44);
            this.btnornek4.TabIndex = 1;
            this.btnornek4.Text = "Örnek 4";
            this.btnornek4.UseVisualStyleBackColor = false;
            this.btnornek4.Click += new System.EventHandler(this.btnornek4_Click);
            // 
            // btnornek5
            // 
            this.btnornek5.BackColor = System.Drawing.Color.IndianRed;
            this.btnornek5.Location = new System.Drawing.Point(547, 47);
            this.btnornek5.Name = "btnornek5";
            this.btnornek5.Size = new System.Drawing.Size(104, 44);
            this.btnornek5.TabIndex = 0;
            this.btnornek5.Text = "Örnek 5";
            this.btnornek5.UseVisualStyleBackColor = false;
            this.btnornek5.Click += new System.EventHandler(this.btnornek5_Click);
            // 
            // btnornek6
            // 
            this.btnornek6.BackColor = System.Drawing.Color.LightCoral;
            this.btnornek6.Location = new System.Drawing.Point(683, 24);
            this.btnornek6.Name = "btnornek6";
            this.btnornek6.Size = new System.Drawing.Size(105, 44);
            this.btnornek6.TabIndex = 1;
            this.btnornek6.Text = "Örnek 6";
            this.btnornek6.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 326);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnornek6);
            this.Controls.Add(this.btnornek4);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnornek5);
            this.Controls.Add(this.btnornek3);
            this.Controls.Add(this.btnornek1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnornek1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnornek3;
        private System.Windows.Forms.Button btnornek4;
        private System.Windows.Forms.Button btnornek5;
        private System.Windows.Forms.Button btnornek6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

