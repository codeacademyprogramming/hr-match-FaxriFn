namespace TaskWinform.Forums
{
    partial class HomeEmployeesForum
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
            this.btnCv = new System.Windows.Forms.Button();
            this.btnIs = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnElan = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCv
            // 
            this.btnCv.BackColor = System.Drawing.Color.Teal;
            this.btnCv.FlatAppearance.BorderSize = 0;
            this.btnCv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCv.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCv.Location = new System.Drawing.Point(3, 0);
            this.btnCv.Name = "btnCv";
            this.btnCv.Size = new System.Drawing.Size(306, 88);
            this.btnCv.TabIndex = 0;
            this.btnCv.Text = " CV yerlesdir";
            this.btnCv.UseVisualStyleBackColor = false;
            this.btnCv.Click += new System.EventHandler(this.btnCv_Click);
            // 
            // btnIs
            // 
            this.btnIs.BackColor = System.Drawing.Color.Teal;
            this.btnIs.FlatAppearance.BorderSize = 0;
            this.btnIs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIs.Location = new System.Drawing.Point(6, 80);
            this.btnIs.Name = "btnIs";
            this.btnIs.Size = new System.Drawing.Size(303, 79);
            this.btnIs.TabIndex = 1;
            this.btnIs.Text = " Is axtar";
            this.btnIs.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(6, 218);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(324, 79);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Teal;
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnData.Location = new System.Drawing.Point(6, 151);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(312, 74);
            this.btnData.TabIndex = 3;
            this.btnData.Text = "Melumatlari goster";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnElan
            // 
            this.btnElan.BackColor = System.Drawing.Color.Teal;
            this.btnElan.FlatAppearance.BorderSize = 0;
            this.btnElan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElan.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnElan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnElan.Location = new System.Drawing.Point(6, 290);
            this.btnElan.Name = "btnElan";
            this.btnElan.Size = new System.Drawing.Size(303, 95);
            this.btnElan.TabIndex = 4;
            this.btnElan.Text = "Butun elanlari goster";
            this.btnElan.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(-2, 382);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(303, 87);
            this.button7.TabIndex = 6;
            this.button7.Text = "Log Out";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnIs);
            this.panel1.Controls.Add(this.btnData);
            this.panel1.Controls.Add(this.btnElan);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnCv);
            this.panel1.Location = new System.Drawing.Point(-14, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 473);
            this.panel1.TabIndex = 7;
            // 
            // HomeEmployeesForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HomeEmployeesForum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeEmployeesForum";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeEmployeesForum_FormClosed);
            this.Load += new System.EventHandler(this.HomeEmployeesForum_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCv;
        private System.Windows.Forms.Button btnIs;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnElan;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
    }
}