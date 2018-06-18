namespace Example
{
    partial class ExampleForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.positiveNumberTextBox = new ValidatedTextBox.PositiveNumberTextBox();
            this.readPositiveNumberButton = new System.Windows.Forms.Button();
            this.readPositiveFloatingNumberButton = new System.Windows.Forms.Button();
            this.positiveFloatingPointNumberTextBox = new ValidatedTextBox.PositiveFloatingPointNumberTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.positiveNumberTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.readPositiveNumberButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.readPositiveFloatingNumberButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.positiveFloatingPointNumberTextBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1287, 114);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PositiveNumberTextBox";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "PositiveFloatingPointNumberTextBox";
            // 
            // positiveNumberTextBox
            // 
            this.positiveNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.positiveNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveNumberTextBox.Location = new System.Drawing.Point(353, 13);
            this.positiveNumberTextBox.Name = "positiveNumberTextBox";
            this.positiveNumberTextBox.Size = new System.Drawing.Size(681, 30);
            this.positiveNumberTextBox.TabIndex = 1;
            // 
            // readPositiveNumberButton
            // 
            this.readPositiveNumberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.readPositiveNumberButton.AutoSize = true;
            this.readPositiveNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readPositiveNumberButton.Location = new System.Drawing.Point(1040, 11);
            this.readPositiveNumberButton.Name = "readPositiveNumberButton";
            this.readPositiveNumberButton.Size = new System.Drawing.Size(244, 35);
            this.readPositiveNumberButton.TabIndex = 2;
            this.readPositiveNumberButton.Text = "read from text box";
            this.readPositiveNumberButton.UseVisualStyleBackColor = true;
            this.readPositiveNumberButton.Click += new System.EventHandler(this.readPositiveNumberButton_Click);
            // 
            // readPositiveFloatingNumberButton
            // 
            this.readPositiveFloatingNumberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.readPositiveFloatingNumberButton.AutoSize = true;
            this.readPositiveFloatingNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readPositiveFloatingNumberButton.Location = new System.Drawing.Point(1040, 68);
            this.readPositiveFloatingNumberButton.Name = "readPositiveFloatingNumberButton";
            this.readPositiveFloatingNumberButton.Size = new System.Drawing.Size(244, 35);
            this.readPositiveFloatingNumberButton.TabIndex = 2;
            this.readPositiveFloatingNumberButton.Text = "read from text box";
            this.readPositiveFloatingNumberButton.UseVisualStyleBackColor = true;
            this.readPositiveFloatingNumberButton.Click += new System.EventHandler(this.readPositiveFloatingNumberButton_Click);
            // 
            // positiveFloatingPointNumberTextBox
            // 
            this.positiveFloatingPointNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.positiveFloatingPointNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveFloatingPointNumberTextBox.Location = new System.Drawing.Point(353, 70);
            this.positiveFloatingPointNumberTextBox.Name = "positiveFloatingPointNumberTextBox";
            this.positiveFloatingPointNumberTextBox.Size = new System.Drawing.Size(681, 30);
            this.positiveFloatingPointNumberTextBox.TabIndex = 3;
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 114);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExampleForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ValidatedTextBox.PositiveNumberTextBox positiveNumberTextBox;
        private System.Windows.Forms.Button readPositiveNumberButton;
        private System.Windows.Forms.Button readPositiveFloatingNumberButton;
        private ValidatedTextBox.PositiveFloatingPointNumberTextBox positiveFloatingPointNumberTextBox;
    }
}

