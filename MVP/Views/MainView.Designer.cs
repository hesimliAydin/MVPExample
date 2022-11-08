namespace MVP
{
    partial class MainView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modelTxtb = new System.Windows.Forms.TextBox();
            this.vendorTxt = new System.Windows.Forms.TextBox();
            this.colorTxtb = new System.Windows.Forms.TextBox();
            this.yearTxtb = new System.Windows.Forms.TextBox();
            this.carListBox = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vendor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Year";
            // 
            // modelTxtb
            // 
            this.modelTxtb.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelTxtb.Location = new System.Drawing.Point(265, 49);
            this.modelTxtb.Name = "modelTxtb";
            this.modelTxtb.Size = new System.Drawing.Size(160, 51);
            this.modelTxtb.TabIndex = 1;
            // 
            // vendorTxt
            // 
            this.vendorTxt.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vendorTxt.Location = new System.Drawing.Point(265, 143);
            this.vendorTxt.Name = "vendorTxt";
            this.vendorTxt.Size = new System.Drawing.Size(160, 51);
            this.vendorTxt.TabIndex = 1;
            // 
            // colorTxtb
            // 
            this.colorTxtb.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorTxtb.Location = new System.Drawing.Point(265, 248);
            this.colorTxtb.Name = "colorTxtb";
            this.colorTxtb.Size = new System.Drawing.Size(160, 51);
            this.colorTxtb.TabIndex = 1;
            // 
            // yearTxtb
            // 
            this.yearTxtb.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearTxtb.Location = new System.Drawing.Point(265, 351);
            this.yearTxtb.Name = "yearTxtb";
            this.yearTxtb.Size = new System.Drawing.Size(160, 51);
            this.yearTxtb.TabIndex = 1;
            // 
            // carListBox
            // 
            this.carListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.carListBox.FormattingEnabled = true;
            this.carListBox.ItemHeight = 41;
            this.carListBox.Location = new System.Drawing.Point(610, 49);
            this.carListBox.Name = "carListBox";
            this.carListBox.Size = new System.Drawing.Size(334, 332);
            this.carListBox.TabIndex = 2;
            this.carListBox.SelectedIndexChanged += new System.EventHandler(this.carListBox_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(267, 432);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(158, 49);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add Car";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.loadBtn.Location = new System.Drawing.Point(610, 432);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(334, 49);
            this.loadBtn.TabIndex = 3;
            this.loadBtn.Text = "Load Cars";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 544);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.carListBox);
            this.Controls.Add(this.yearTxtb);
            this.Controls.Add(this.colorTxtb);
            this.Controls.Add(this.vendorTxt);
            this.Controls.Add(this.modelTxtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox modelTxtb;
        private TextBox vendorTxt;
        private TextBox colorTxtb;
        private TextBox yearTxtb;
        private ListBox carListBox;
        private Button addBtn;
        private Button loadBtn;
    }
}