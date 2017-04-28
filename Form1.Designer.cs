namespace Example2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblExpAdd = new System.Windows.Forms.Label();
            this.lblExpSub = new System.Windows.Forms.Label();
            this.lblExpMul = new System.Windows.Forms.Label();
            this.lblExpDiv = new System.Windows.Forms.Label();
            this.btnCalcAdd = new System.Windows.Forms.Button();
            this.btnCalcSub = new System.Windows.Forms.Button();
            this.btnCalcMul = new System.Windows.Forms.Button();
            this.btnCalcDiv = new System.Windows.Forms.Button();
            this.lblAnsadd = new System.Windows.Forms.Label();
            this.lblAnsSub = new System.Windows.Forms.Label();
            this.lblAnsMul = new System.Windows.Forms.Label();
            this.lblAnsDiv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExpAdd
            // 
            this.lblExpAdd.AutoSize = true;
            this.lblExpAdd.Location = new System.Drawing.Point(40, 20);
            this.lblExpAdd.Name = "lblExpAdd";
            this.lblExpAdd.Size = new System.Drawing.Size(33, 12);
            this.lblExpAdd.TabIndex = 0;
            this.lblExpAdd.Text = "１＋２";
            // 
            // lblExpSub
            // 
            this.lblExpSub.AutoSize = true;
            this.lblExpSub.Location = new System.Drawing.Point(40, 60);
            this.lblExpSub.Name = "lblExpSub";
            this.lblExpSub.Size = new System.Drawing.Size(33, 12);
            this.lblExpSub.TabIndex = 1;
            this.lblExpSub.Text = "５－３";
            // 
            // lblExpMul
            // 
            this.lblExpMul.AutoSize = true;
            this.lblExpMul.Location = new System.Drawing.Point(40, 100);
            this.lblExpMul.Name = "lblExpMul";
            this.lblExpMul.Size = new System.Drawing.Size(33, 12);
            this.lblExpMul.TabIndex = 2;
            this.lblExpMul.Text = "２×３";
            // 
            // lblExpDiv
            // 
            this.lblExpDiv.AutoSize = true;
            this.lblExpDiv.Location = new System.Drawing.Point(40, 140);
            this.lblExpDiv.Name = "lblExpDiv";
            this.lblExpDiv.Size = new System.Drawing.Size(33, 12);
            this.lblExpDiv.TabIndex = 3;
            this.lblExpDiv.Text = "８÷２";
            this.lblExpDiv.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCalcAdd
            // 
            this.btnCalcAdd.Location = new System.Drawing.Point(105, 15);
            this.btnCalcAdd.Name = "btnCalcAdd";
            this.btnCalcAdd.Size = new System.Drawing.Size(43, 23);
            this.btnCalcAdd.TabIndex = 4;
            this.btnCalcAdd.Text = "＝";
            this.btnCalcAdd.UseVisualStyleBackColor = true;
            this.btnCalcAdd.Click += new System.EventHandler(this.btnCalcAdd_Click);
            // 
            // btnCalcSub
            // 
            this.btnCalcSub.Location = new System.Drawing.Point(105, 55);
            this.btnCalcSub.Name = "btnCalcSub";
            this.btnCalcSub.Size = new System.Drawing.Size(43, 23);
            this.btnCalcSub.TabIndex = 5;
            this.btnCalcSub.Text = "＝";
            this.btnCalcSub.UseVisualStyleBackColor = true;
            this.btnCalcSub.Click += new System.EventHandler(this.btnCalcSub_Click);
            // 
            // btnCalcMul
            // 
            this.btnCalcMul.Location = new System.Drawing.Point(105, 95);
            this.btnCalcMul.Name = "btnCalcMul";
            this.btnCalcMul.Size = new System.Drawing.Size(43, 23);
            this.btnCalcMul.TabIndex = 6;
            this.btnCalcMul.Text = "＝";
            this.btnCalcMul.UseVisualStyleBackColor = true;
            this.btnCalcMul.Click += new System.EventHandler(this.btnCalcMul_Click);
            // 
            // btnCalcDiv
            // 
            this.btnCalcDiv.Location = new System.Drawing.Point(105, 135);
            this.btnCalcDiv.Name = "btnCalcDiv";
            this.btnCalcDiv.Size = new System.Drawing.Size(43, 23);
            this.btnCalcDiv.TabIndex = 7;
            this.btnCalcDiv.Text = "＝";
            this.btnCalcDiv.UseVisualStyleBackColor = true;
            this.btnCalcDiv.Click += new System.EventHandler(this.btnCalcDiv_Click);
            // 
            // lblAnsadd
            // 
            this.lblAnsadd.AutoSize = true;
            this.lblAnsadd.Location = new System.Drawing.Point(180, 20);
            this.lblAnsadd.Name = "lblAnsadd";
            this.lblAnsadd.Size = new System.Drawing.Size(10, 12);
            this.lblAnsadd.TabIndex = 8;
            this.lblAnsadd.Text = "?";
            this.lblAnsadd.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAnsSub
            // 
            this.lblAnsSub.AutoSize = true;
            this.lblAnsSub.Location = new System.Drawing.Point(180, 60);
            this.lblAnsSub.Name = "lblAnsSub";
            this.lblAnsSub.Size = new System.Drawing.Size(10, 12);
            this.lblAnsSub.TabIndex = 8;
            this.lblAnsSub.Text = "?";
            this.lblAnsSub.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAnsMul
            // 
            this.lblAnsMul.AutoSize = true;
            this.lblAnsMul.Location = new System.Drawing.Point(180, 100);
            this.lblAnsMul.Name = "lblAnsMul";
            this.lblAnsMul.Size = new System.Drawing.Size(10, 12);
            this.lblAnsMul.TabIndex = 8;
            this.lblAnsMul.Text = "?";
            this.lblAnsMul.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAnsDiv
            // 
            this.lblAnsDiv.AutoSize = true;
            this.lblAnsDiv.Location = new System.Drawing.Point(180, 140);
            this.lblAnsDiv.Name = "lblAnsDiv";
            this.lblAnsDiv.Size = new System.Drawing.Size(10, 12);
            this.lblAnsDiv.TabIndex = 8;
            this.lblAnsDiv.Text = "?";
            this.lblAnsDiv.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 171);
            this.Controls.Add(this.lblAnsDiv);
            this.Controls.Add(this.lblAnsMul);
            this.Controls.Add(this.lblAnsSub);
            this.Controls.Add(this.lblAnsadd);
            this.Controls.Add(this.btnCalcDiv);
            this.Controls.Add(this.btnCalcMul);
            this.Controls.Add(this.btnCalcSub);
            this.Controls.Add(this.btnCalcAdd);
            this.Controls.Add(this.lblExpDiv);
            this.Controls.Add(this.lblExpMul);
            this.Controls.Add(this.lblExpSub);
            this.Controls.Add(this.lblExpAdd);
            this.Name = "Form1";
            this.Text = "四則演算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpAdd;
        private System.Windows.Forms.Label lblExpSub;
        private System.Windows.Forms.Label lblExpMul;
        private System.Windows.Forms.Label lblExpDiv;
        private System.Windows.Forms.Button btnCalcAdd;
        private System.Windows.Forms.Button btnCalcSub;
        private System.Windows.Forms.Button btnCalcMul;
        private System.Windows.Forms.Button btnCalcDiv;
        private System.Windows.Forms.Label lblAnsadd;
        private System.Windows.Forms.Label lblAnsSub;
        private System.Windows.Forms.Label lblAnsMul;
        private System.Windows.Forms.Label lblAnsDiv;
    }
}

