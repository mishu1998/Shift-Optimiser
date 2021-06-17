
namespace Shift_Optimiser
{
    partial class MainWindow
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
            this.staffTable = new System.Windows.Forms.DataGridView();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.RotaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staffTable)).BeginInit();
            this.SuspendLayout();
            // 
            // staffTable
            // 
            this.staffTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffTable.Location = new System.Drawing.Point(12, 116);
            this.staffTable.Name = "staffTable";
            this.staffTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.staffTable.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffTable.Size = new System.Drawing.Size(1240, 150);
            this.staffTable.TabIndex = 0;
            // 
            // addStaffButton
            // 
            this.addStaffButton.Location = new System.Drawing.Point(12, 296);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(75, 23);
            this.addStaffButton.TabIndex = 1;
            this.addStaffButton.Text = "Add Staff";
            this.addStaffButton.UseVisualStyleBackColor = true;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // RotaButton
            // 
            this.RotaButton.Location = new System.Drawing.Point(129, 295);
            this.RotaButton.Name = "RotaButton";
            this.RotaButton.Size = new System.Drawing.Size(75, 23);
            this.RotaButton.TabIndex = 2;
            this.RotaButton.Text = "Rota";
            this.RotaButton.UseVisualStyleBackColor = true;
            this.RotaButton.Click += new System.EventHandler(this.RotaButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.RotaButton);
            this.Controls.Add(this.addStaffButton);
            this.Controls.Add(this.staffTable);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.staffTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView staffTable;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.Button RotaButton;
    }
}

