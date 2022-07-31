namespace Random_No_Generator
{
    partial class DICL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DICL));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGenNo = new System.Windows.Forms.Label();
            this.lstArray = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblGenName = new System.Windows.Forms.Label();
            this.llblPlLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(571, 396);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(170, 43);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(562, 330);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(171, 35);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(794, 330);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(180, 35);
            this.txtTo.TabIndex = 2;
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(745, 331);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(49, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "To";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(484, 331);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(78, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGenNo
            // 
            this.lblGenNo.AutoSize = true;
            this.lblGenNo.BackColor = System.Drawing.Color.Transparent;
            this.lblGenNo.Font = new System.Drawing.Font("Palatino Linotype", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenNo.ForeColor = System.Drawing.Color.Black;
            this.lblGenNo.Location = new System.Drawing.Point(469, 440);
            this.lblGenNo.Name = "lblGenNo";
            this.lblGenNo.Padding = new System.Windows.Forms.Padding(10);
            this.lblGenNo.Size = new System.Drawing.Size(105, 78);
            this.lblGenNo.TabIndex = 5;
            this.lblGenNo.Text = "No";
            this.lblGenNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblGenNo.Click += new System.EventHandler(this.lblGenNo_Click);
            // 
            // lstArray
            // 
            this.lstArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lstArray.AutoSize = true;
            this.lstArray.BackColor = System.Drawing.Color.OrangeRed;
            this.lstArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstArray.ForeColor = System.Drawing.Color.White;
            this.lstArray.Location = new System.Drawing.Point(442, 569);
            this.lstArray.Name = "lstArray";
            this.lstArray.Padding = new System.Windows.Forms.Padding(4);
            this.lstArray.Size = new System.Drawing.Size(79, 37);
            this.lstArray.TabIndex = 6;
            this.lstArray.Text = "array";
            this.lstArray.Click += new System.EventHandler(this.lstArray_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.OrangeRed;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(772, 396);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(171, 43);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblGenName
            // 
            this.lblGenName.AutoSize = true;
            this.lblGenName.BackColor = System.Drawing.Color.Transparent;
            this.lblGenName.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenName.ForeColor = System.Drawing.Color.Red;
            this.lblGenName.Location = new System.Drawing.Point(471, 503);
            this.lblGenName.Name = "lblGenName";
            this.lblGenName.Padding = new System.Windows.Forms.Padding(10);
            this.lblGenName.Size = new System.Drawing.Size(229, 63);
            this.lblGenName.TabIndex = 10;
            this.lblGenName.Text = "Player name";
            this.lblGenName.Click += new System.EventHandler(this.lblGenName_Click);
            // 
            // llblPlLink
            // 
            this.llblPlLink.ActiveLinkColor = System.Drawing.Color.Tomato;
            this.llblPlLink.AutoSize = true;
            this.llblPlLink.BackColor = System.Drawing.Color.Transparent;
            this.llblPlLink.Font = new System.Drawing.Font("Palatino Linotype", 32.25F, System.Drawing.FontStyle.Bold);
            this.llblPlLink.ForeColor = System.Drawing.Color.Black;
            this.llblPlLink.LinkColor = System.Drawing.Color.Black;
            this.llblPlLink.Location = new System.Drawing.Point(557, 451);
            this.llblPlLink.Name = "llblPlLink";
            this.llblPlLink.Size = new System.Drawing.Size(277, 58);
            this.llblPlLink.TabIndex = 5;
            this.llblPlLink.TabStop = true;
            this.llblPlLink.Text = "Player Name";
            this.llblPlLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblPlLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-312, -114);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10);
            this.label5.Size = new System.Drawing.Size(105, 78);
            this.label5.TabIndex = 5;
            this.label5.Text = "No";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Click += new System.EventHandler(this.lblGenNo_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.OrangeRed;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(52, 821);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4);
            this.label6.Size = new System.Drawing.Size(79, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "array";
            this.label6.Click += new System.EventHandler(this.lstArray_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Tomato;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Palatino Linotype", 32.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(-224, -107);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(277, 58);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Player Name";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblPlLink_LinkClicked);
            // 
            // DICL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1278, 675);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.llblPlLink);
            this.Controls.Add(this.lblGenName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstArray);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGenNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.btnGenerate);
            this.Name = "DICL";
            this.Text = "3DICL";
            this.Load += new System.EventHandler(this.DICL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGenNo;
        private System.Windows.Forms.Label lstArray;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblGenName;
        private System.Windows.Forms.LinkLabel llblPlLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

