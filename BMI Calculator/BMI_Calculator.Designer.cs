/// <summary>
/// Komaldeep Kaur 300926834
/// BMI CALCULATOR
/// </summary>
namespace BMI_Calculator
{
    partial class BMI_Calculator
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
            this.Result = new System.Windows.Forms.TextBox();
            this.Metric = new System.Windows.Forms.RadioButton();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.ControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Height = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.HeightUnits = new System.Windows.Forms.Label();
            this.WeightUnits = new System.Windows.Forms.Label();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.Highlight;
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(1, 60);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(300, 61);
            this.Result.TabIndex = 0;
            // 
            // Metric
            // 
            this.Metric.AutoSize = true;
            this.Metric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metric.Location = new System.Drawing.Point(108, 4);
            this.Metric.Name = "Metric";
            this.Metric.Size = new System.Drawing.Size(86, 29);
            this.Metric.TabIndex = 1;
            this.Metric.TabStop = true;
            this.Metric.Text = "Metric";
            this.Metric.UseVisualStyleBackColor = true;
            // 
            // Imperial
            // 
            this.Imperial.AutoSize = true;
            this.Imperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imperial.Location = new System.Drawing.Point(1, 4);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(101, 29);
            this.Imperial.TabIndex = 2;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            this.ControlPanel.ColumnCount = 3;
            this.ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlPanel.Controls.Add(this.WeightBox, 1, 1);
            this.ControlPanel.Controls.Add(this.Height, 0, 0);
            this.ControlPanel.Controls.Add(this.Weight, 0, 1);
            this.ControlPanel.Controls.Add(this.HeightUnits, 2, 0);
            this.ControlPanel.Controls.Add(this.WeightUnits, 2, 1);
            this.ControlPanel.Controls.Add(this.HeightText, 1, 0);
            this.ControlPanel.Location = new System.Drawing.Point(1, 127);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.RowCount = 3;
            this.ControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlPanel.Size = new System.Drawing.Size(300, 300);
            this.ControlPanel.TabIndex = 3;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height.Location = new System.Drawing.Point(3, 0);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(86, 29);
            this.Height.TabIndex = 0;
            this.Height.Text = "Height";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(3, 99);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(92, 29);
            this.Weight.TabIndex = 1;
            this.Weight.Text = "Weight";
            // 
            // HeightUnits
            // 
            this.HeightUnits.AutoSize = true;
            this.HeightUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightUnits.Location = new System.Drawing.Point(201, 0);
            this.HeightUnits.Name = "HeightUnits";
            this.HeightUnits.Size = new System.Drawing.Size(48, 29);
            this.HeightUnits.TabIndex = 2;
            this.HeightUnits.Text = "cm";
            // 
            // WeightUnits
            // 
            this.WeightUnits.AutoSize = true;
            this.WeightUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnits.Location = new System.Drawing.Point(201, 99);
            this.WeightUnits.Name = "WeightUnits";
            this.WeightUnits.Size = new System.Drawing.Size(53, 29);
            this.WeightUnits.TabIndex = 3;
            this.WeightUnits.Text = "kgs";
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(102, 3);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(93, 45);
            this.HeightText.TabIndex = 4;
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(102, 102);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(93, 45);
            this.WeightBox.TabIndex = 5;
            // 
            // BMI_Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.Imperial);
            this.Controls.Add(this.Metric);
            this.Controls.Add(this.Result);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.Name = "BMI_Calculator";
            this.Text = "BMI";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.RadioButton Metric;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.TableLayoutPanel ControlPanel;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label HeightUnits;
        private System.Windows.Forms.Label WeightUnits;
        private System.Windows.Forms.TextBox HeightText;
    }
}

