namespace ProbabilityGameProject
{
    partial class Form2
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
            this.lblBet = new System.Windows.Forms.Label();
            this.lblOwn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnOpenA = new System.Windows.Forms.Button();
            this.btnOpenB = new System.Windows.Forms.Button();
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblOwnValue = new System.Windows.Forms.Label();
            this.btnChangeBet = new System.Windows.Forms.Button();
            this.txbChange = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(22, 25);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(245, 91);
            this.lblBet.TabIndex = 0;
            this.lblBet.Text = "Bet: $";
            // 
            // lblOwn
            // 
            this.lblOwn.AutoSize = true;
            this.lblOwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblOwn.Location = new System.Drawing.Point(490, 25);
            this.lblOwn.Name = "lblOwn";
            this.lblOwn.Size = new System.Drawing.Size(290, 91);
            this.lblOwn.TabIndex = 1;
            this.lblOwn.Text = "Own: $";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(391, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 355);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(712, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(267, 355);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnOpenA
            // 
            this.btnOpenA.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenA.Location = new System.Drawing.Point(56, 563);
            this.btnOpenA.Name = "btnOpenA";
            this.btnOpenA.Size = new System.Drawing.Size(266, 107);
            this.btnOpenA.TabIndex = 5;
            this.btnOpenA.Text = "Open";
            this.btnOpenA.UseVisualStyleBackColor = true;
            this.btnOpenA.Click += new System.EventHandler(this.btnOpenA_Click);
            // 
            // btnOpenB
            // 
            this.btnOpenB.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenB.Location = new System.Drawing.Point(391, 563);
            this.btnOpenB.Name = "btnOpenB";
            this.btnOpenB.Size = new System.Drawing.Size(266, 107);
            this.btnOpenB.TabIndex = 6;
            this.btnOpenB.Text = "Open";
            this.btnOpenB.UseVisualStyleBackColor = true;
            this.btnOpenB.Click += new System.EventHandler(this.btnOpenB_Click);
            // 
            // btnOpen3
            // 
            this.btnOpen3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen3.Location = new System.Drawing.Point(713, 563);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(266, 107);
            this.btnOpen3.TabIndex = 7;
            this.btnOpen3.Text = "Open";
            this.btnOpen3.UseVisualStyleBackColor = true;
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen3_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(1083, 25);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(246, 91);
            this.lblSum.TabIndex = 8;
            this.lblSum.Text = "Sum: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(1091, 191);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 91);
            this.lblResult.TabIndex = 9;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(1023, 563);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(192, 107);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblOwnValue
            // 
            this.lblOwnValue.AutoSize = true;
            this.lblOwnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnValue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblOwnValue.Location = new System.Drawing.Point(766, 25);
            this.lblOwnValue.Name = "lblOwnValue";
            this.lblOwnValue.Size = new System.Drawing.Size(0, 91);
            this.lblOwnValue.TabIndex = 12;
            // 
            // btnChangeBet
            // 
            this.btnChangeBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeBet.Location = new System.Drawing.Point(1023, 437);
            this.btnChangeBet.Name = "btnChangeBet";
            this.btnChangeBet.Size = new System.Drawing.Size(192, 120);
            this.btnChangeBet.TabIndex = 13;
            this.btnChangeBet.Text = "Change bet";
            this.btnChangeBet.UseVisualStyleBackColor = true;
            this.btnChangeBet.Click += new System.EventHandler(this.btnChangeBet_Click);
            // 
            // txbChange
            // 
            this.txbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbChange.Location = new System.Drawing.Point(1233, 448);
            this.txbChange.Name = "txbChange";
            this.txbChange.Size = new System.Drawing.Size(296, 98);
            this.txbChange.TabIndex = 14;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1558, 448);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 49);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "Change";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1558, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 49);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1731, 682);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txbChange);
            this.Controls.Add(this.btnChangeBet);
            this.Controls.Add(this.lblOwnValue);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnOpen3);
            this.Controls.Add(this.btnOpenB);
            this.Controls.Add(this.btnOpenA);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOwn);
            this.Controls.Add(this.lblBet);
            this.Name = "Form2";
            this.Text = "The Sum Game MDM4U";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblOwn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnOpenA;
        private System.Windows.Forms.Button btnOpenB;
        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblOwnValue;
        private System.Windows.Forms.Button btnChangeBet;
        public System.Windows.Forms.TextBox txbChange;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}