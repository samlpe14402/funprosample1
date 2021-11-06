namespace Project5
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
            this.main_input1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.euro_amount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exchange_rate_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exchanged_amount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // main_input1
            // 
            this.main_input1.Location = new System.Drawing.Point(12, 12);
            this.main_input1.Name = "main_input1";
            this.main_input1.Size = new System.Drawing.Size(100, 20);
            this.main_input1.TabIndex = 0;
            this.main_input1.TextChanged += new System.EventHandler(this.main_input1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input your amount of Euros";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Rick?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your amount:";
            // 
            // euro_amount
            // 
            this.euro_amount.AutoSize = true;
            this.euro_amount.Location = new System.Drawing.Point(119, 78);
            this.euro_amount.Name = "euro_amount";
            this.euro_amount.Size = new System.Drawing.Size(0, 13);
            this.euro_amount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exchange rate:";
            // 
            // exchange_rate_label
            // 
            this.exchange_rate_label.AutoSize = true;
            this.exchange_rate_label.Location = new System.Drawing.Point(119, 94);
            this.exchange_rate_label.Name = "exchange_rate_label";
            this.exchange_rate_label.Size = new System.Drawing.Size(49, 13);
            this.exchange_rate_label.TabIndex = 7;
            this.exchange_rate_label.Text = "1.3170 $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Exchanged amount: ";
            // 
            // exchanged_amount
            // 
            this.exchanged_amount.AutoSize = true;
            this.exchanged_amount.Location = new System.Drawing.Point(119, 111);
            this.exchanged_amount.Name = "exchanged_amount";
            this.exchanged_amount.Size = new System.Drawing.Size(0, 13);
            this.exchanged_amount.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 434);
            this.Controls.Add(this.exchanged_amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exchange_rate_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.euro_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox main_input1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label euro_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label exchange_rate_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label exchanged_amount;
    }
}

