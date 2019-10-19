namespace LinqToExample
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
            this.btn_Data = new System.Windows.Forms.Button();
            this.dgw_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Data
            // 
            this.btn_Data.Location = new System.Drawing.Point(12, 356);
            this.btn_Data.Name = "btn_Data";
            this.btn_Data.Size = new System.Drawing.Size(628, 23);
            this.btn_Data.TabIndex = 0;
            this.btn_Data.Text = "GetData";
            this.btn_Data.UseVisualStyleBackColor = true;
            this.btn_Data.Click += new System.EventHandler(this.Btn_Data_Click);
            // 
            // dgw_data
            // 
            this.dgw_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_data.Location = new System.Drawing.Point(0, 0);
            this.dgw_data.Name = "dgw_data";
            this.dgw_data.Size = new System.Drawing.Size(640, 350);
            this.dgw_data.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 391);
            this.Controls.Add(this.dgw_data);
            this.Controls.Add(this.btn_Data);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Data;
        private System.Windows.Forms.DataGridView dgw_data;
    }
}

