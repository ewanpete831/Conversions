
namespace Conversions
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.instruction1Label = new System.Windows.Forms.Label();
            this.instruction2Label = new System.Windows.Forms.Label();
            this.instruction3Label = new System.Windows.Forms.Label();
            this.instruction4Label = new System.Windows.Forms.Label();
            this.instruction5Label = new System.Windows.Forms.Label();
            this.choiceInput = new System.Windows.Forms.TextBox();
            this.instruction6label = new System.Windows.Forms.Label();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Salmon;
            this.titleLabel.Location = new System.Drawing.Point(156, 48);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(284, 51);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Conversions";
            // 
            // instruction1Label
            // 
            this.instruction1Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction1Label.ForeColor = System.Drawing.Color.Maroon;
            this.instruction1Label.Location = new System.Drawing.Point(101, 121);
            this.instruction1Label.Name = "instruction1Label";
            this.instruction1Label.Size = new System.Drawing.Size(401, 51);
            this.instruction1Label.TabIndex = 1;
            this.instruction1Label.Text = "1. Inches to Centimetres";
            // 
            // instruction2Label
            // 
            this.instruction2Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction2Label.ForeColor = System.Drawing.Color.Maroon;
            this.instruction2Label.Location = new System.Drawing.Point(101, 172);
            this.instruction2Label.Name = "instruction2Label";
            this.instruction2Label.Size = new System.Drawing.Size(401, 51);
            this.instruction2Label.TabIndex = 2;
            this.instruction2Label.Text = "2. Feet to Centimeters";
            // 
            // instruction3Label
            // 
            this.instruction3Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction3Label.ForeColor = System.Drawing.Color.Maroon;
            this.instruction3Label.Location = new System.Drawing.Point(101, 223);
            this.instruction3Label.Name = "instruction3Label";
            this.instruction3Label.Size = new System.Drawing.Size(401, 51);
            this.instruction3Label.TabIndex = 3;
            this.instruction3Label.Text = "3. Yards to Metres";
            // 
            // instruction4Label
            // 
            this.instruction4Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction4Label.ForeColor = System.Drawing.Color.Maroon;
            this.instruction4Label.Location = new System.Drawing.Point(101, 274);
            this.instruction4Label.Name = "instruction4Label";
            this.instruction4Label.Size = new System.Drawing.Size(401, 51);
            this.instruction4Label.TabIndex = 4;
            this.instruction4Label.Text = "4. Miles to Kilometres";
            // 
            // instruction5Label
            // 
            this.instruction5Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction5Label.ForeColor = System.Drawing.Color.Firebrick;
            this.instruction5Label.Location = new System.Drawing.Point(33, 377);
            this.instruction5Label.Name = "instruction5Label";
            this.instruction5Label.Size = new System.Drawing.Size(339, 34);
            this.instruction5Label.TabIndex = 5;
            this.instruction5Label.Text = "Enter Conversion Choice (1 - 4):";
            // 
            // choiceInput
            // 
            this.choiceInput.Location = new System.Drawing.Point(378, 377);
            this.choiceInput.Name = "choiceInput";
            this.choiceInput.Size = new System.Drawing.Size(100, 26);
            this.choiceInput.TabIndex = 6;
            // 
            // instruction6label
            // 
            this.instruction6label.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction6label.ForeColor = System.Drawing.Color.Firebrick;
            this.instruction6label.Location = new System.Drawing.Point(61, 409);
            this.instruction6label.Name = "instruction6label";
            this.instruction6label.Size = new System.Drawing.Size(311, 34);
            this.instruction6label.TabIndex = 7;
            this.instruction6label.Text = "Enter Value to be Converted:";
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(378, 409);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(100, 26);
            this.valueInput.TabIndex = 8;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(108, 445);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(351, 42);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Salmon;
            this.outputLabel.Location = new System.Drawing.Point(3, 491);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(607, 98);
            this.outputLabel.TabIndex = 10;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 587);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.instruction6label);
            this.Controls.Add(this.choiceInput);
            this.Controls.Add(this.instruction5Label);
            this.Controls.Add(this.instruction4Label);
            this.Controls.Add(this.instruction3Label);
            this.Controls.Add(this.instruction2Label);
            this.Controls.Add(this.instruction1Label);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Conversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instruction1Label;
        private System.Windows.Forms.Label instruction2Label;
        private System.Windows.Forms.Label instruction3Label;
        private System.Windows.Forms.Label instruction4Label;
        private System.Windows.Forms.Label instruction5Label;
        private System.Windows.Forms.TextBox choiceInput;
        private System.Windows.Forms.Label instruction6label;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

