namespace Part_4_Forms
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
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.btnIntegerSubmit = new System.Windows.Forms.Button();
            this.btnDblSubmit = new System.Windows.Forms.Button();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.max = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(8, 9);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(244, 22);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Enter a max and min value";
            this.lblInstruction.Click += new System.EventHandler(this.lblInstruction_Click);
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(12, 41);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(48, 13);
            this.lblMinValue.TabIndex = 1;
            this.lblMinValue.Text = "Minimum";
            this.lblMinValue.Click += new System.EventHandler(this.lblMinValue_Click);
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(12, 77);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(51, 13);
            this.lblMaxValue.TabIndex = 2;
            this.lblMaxValue.Text = "Maximum";
            this.lblMaxValue.Click += new System.EventHandler(this.lblMaxValue_Click);
            // 
            // btnIntegerSubmit
            // 
            this.btnIntegerSubmit.Location = new System.Drawing.Point(12, 115);
            this.btnIntegerSubmit.Name = "btnIntegerSubmit";
            this.btnIntegerSubmit.Size = new System.Drawing.Size(106, 23);
            this.btnIntegerSubmit.TabIndex = 3;
            this.btnIntegerSubmit.Text = "Get Integer";
            this.btnIntegerSubmit.UseVisualStyleBackColor = true;
            this.btnIntegerSubmit.Click += new System.EventHandler(this.btnIntegerSubmit_Click);
            // 
            // btnDblSubmit
            // 
            this.btnDblSubmit.Location = new System.Drawing.Point(127, 115);
            this.btnDblSubmit.Name = "btnDblSubmit";
            this.btnDblSubmit.Size = new System.Drawing.Size(106, 23);
            this.btnDblSubmit.TabIndex = 4;
            this.btnDblSubmit.Text = "Get Double";
            this.btnDblSubmit.UseVisualStyleBackColor = true;
            this.btnDblSubmit.Click += new System.EventHandler(this.btnDblSubmit_Click);
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Location = new System.Drawing.Point(72, 158);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(0, 13);
            this.lblRandomNumber.TabIndex = 7;
            this.lblRandomNumber.Click += new System.EventHandler(this.lblRandomNumber_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(113, 39);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(120, 20);
            this.min.TabIndex = 8;
            this.min.ValueChanged += new System.EventHandler(this.minValue_ValueChanged);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(113, 75);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(120, 20);
            this.max.TabIndex = 9;
            this.max.ValueChanged += new System.EventHandler(this.maxValue_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 199);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.btnDblSubmit);
            this.Controls.Add(this.btnIntegerSubmit);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.lblMinValue);
            this.Controls.Add(this.lblInstruction);
            this.Name = "Form1";
            this.Text = "Random Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Button btnIntegerSubmit;
        private System.Windows.Forms.Button btnDblSubmit;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.NumericUpDown max;
    }
}

