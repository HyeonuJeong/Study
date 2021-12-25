namespace 계산기
{
    partial class frmCalculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblExpression = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Button();
            this.lbl0 = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Button();
            this.btnEuqal = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnSQRT = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnRemainder = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Button();
            this.lbl6 = new System.Windows.Forms.Button();
            this.lbl9 = new System.Windows.Forms.Button();
            this.lbl8 = new System.Windows.Forms.Button();
            this.lbl7 = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.lblOutput);
            this.groupBox1.Controls.Add(this.lblExpression);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblOutput.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOutput.Location = new System.Drawing.Point(6, 57);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(456, 60);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "0";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // lblExpression
            // 
            this.lblExpression.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblExpression.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblExpression.Location = new System.Drawing.Point(6, 17);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(456, 40);
            this.lblExpression.TabIndex = 0;
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl1.Location = new System.Drawing.Point(39, 427);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(75, 69);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "1";
            this.lbl1.UseVisualStyleBackColor = false;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl0
            // 
            this.lbl0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl0.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl0.Location = new System.Drawing.Point(133, 514);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(75, 69);
            this.lbl0.TabIndex = 3;
            this.lbl0.Text = "0";
            this.lbl0.UseVisualStyleBackColor = false;
            this.lbl0.Click += new System.EventHandler(this.lbl0_Click);
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl3.Location = new System.Drawing.Point(231, 427);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(75, 69);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "3";
            this.lbl3.UseVisualStyleBackColor = false;
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // btnEuqal
            // 
            this.btnEuqal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEuqal.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEuqal.Location = new System.Drawing.Point(416, 514);
            this.btnEuqal.Name = "btnEuqal";
            this.btnEuqal.Size = new System.Drawing.Size(75, 69);
            this.btnEuqal.TabIndex = 5;
            this.btnEuqal.Text = "=";
            this.btnEuqal.UseVisualStyleBackColor = false;
            this.btnEuqal.Click += new System.EventHandler(this.btnEuqal_Click);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl2.Location = new System.Drawing.Point(133, 427);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(75, 69);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "2";
            this.lbl2.UseVisualStyleBackColor = false;
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackSpace.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBackSpace.Location = new System.Drawing.Point(39, 168);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(75, 69);
            this.btnBackSpace.TabIndex = 7;
            this.btnBackSpace.Text = "<-";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDot.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDot.Location = new System.Drawing.Point(231, 514);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(75, 69);
            this.btnDot.TabIndex = 8;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlus.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlus.Location = new System.Drawing.Point(324, 340);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 69);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMultiply.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMultiply.Location = new System.Drawing.Point(324, 427);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 69);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReverse.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReverse.Location = new System.Drawing.Point(39, 514);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 69);
            this.btnReverse.TabIndex = 11;
            this.btnReverse.Text = "+/-";
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnSQRT
            // 
            this.btnSQRT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSQRT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSQRT.Location = new System.Drawing.Point(324, 168);
            this.btnSQRT.Name = "btnSQRT";
            this.btnSQRT.Size = new System.Drawing.Size(75, 69);
            this.btnSQRT.TabIndex = 12;
            this.btnSQRT.Text = "SQRT";
            this.btnSQRT.UseVisualStyleBackColor = false;
            this.btnSQRT.Click += new System.EventHandler(this.btnSQRT_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSin.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSin.Location = new System.Drawing.Point(416, 168);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(75, 69);
            this.btnSin.TabIndex = 13;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnC.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnC.Location = new System.Drawing.Point(131, 168);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 69);
            this.btnC.TabIndex = 14;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCE.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCE.Location = new System.Drawing.Point(229, 168);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 69);
            this.btnCE.TabIndex = 15;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDivide.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDivide.Location = new System.Drawing.Point(416, 427);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 69);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMinus.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinus.Location = new System.Drawing.Point(419, 340);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 69);
            this.btnMinus.TabIndex = 17;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnRemainder
            // 
            this.btnRemainder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemainder.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemainder.Location = new System.Drawing.Point(324, 514);
            this.btnRemainder.Name = "btnRemainder";
            this.btnRemainder.Size = new System.Drawing.Size(75, 69);
            this.btnRemainder.TabIndex = 18;
            this.btnRemainder.Text = "%";
            this.btnRemainder.UseVisualStyleBackColor = false;
            this.btnRemainder.Click += new System.EventHandler(this.btnRemainder_Click);
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl4.Location = new System.Drawing.Point(41, 340);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(75, 69);
            this.lbl4.TabIndex = 19;
            this.lbl4.Text = "4";
            this.lbl4.UseVisualStyleBackColor = false;
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl5.Location = new System.Drawing.Point(133, 340);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(75, 69);
            this.lbl5.TabIndex = 20;
            this.lbl5.Text = "5";
            this.lbl5.UseVisualStyleBackColor = false;
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl6.Location = new System.Drawing.Point(231, 340);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(75, 69);
            this.lbl6.TabIndex = 21;
            this.lbl6.Text = "6";
            this.lbl6.UseVisualStyleBackColor = false;
            this.lbl6.Click += new System.EventHandler(this.lbl6_Click);
            // 
            // lbl9
            // 
            this.lbl9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl9.Location = new System.Drawing.Point(229, 254);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(75, 69);
            this.lbl9.TabIndex = 24;
            this.lbl9.Text = "9";
            this.lbl9.UseVisualStyleBackColor = false;
            this.lbl9.Click += new System.EventHandler(this.lbl9_Click);
            // 
            // lbl8
            // 
            this.lbl8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl8.Location = new System.Drawing.Point(131, 254);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(75, 69);
            this.lbl8.TabIndex = 23;
            this.lbl8.Text = "8";
            this.lbl8.UseVisualStyleBackColor = false;
            this.lbl8.Click += new System.EventHandler(this.lbl8_Click);
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl7.Location = new System.Drawing.Point(39, 254);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(75, 69);
            this.lbl7.TabIndex = 22;
            this.lbl7.Text = "7";
            this.lbl7.UseVisualStyleBackColor = false;
            this.lbl7.Click += new System.EventHandler(this.lbl7_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCos.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCos.Location = new System.Drawing.Point(324, 254);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(75, 69);
            this.btnCos.TabIndex = 25;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTan.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTan.Location = new System.Drawing.Point(416, 254);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(75, 69);
            this.btnTan.TabIndex = 26;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(588, 613);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btnRemainder);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnSQRT);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnEuqal);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCalculator";
            this.Text = "내가 만든 계산기";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Button lbl1;
        private System.Windows.Forms.Button lbl0;
        private System.Windows.Forms.Button lbl3;
        private System.Windows.Forms.Button btnEuqal;
        private System.Windows.Forms.Button lbl2;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnSQRT;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnRemainder;
        private System.Windows.Forms.Button lbl4;
        private System.Windows.Forms.Button lbl5;
        private System.Windows.Forms.Button lbl6;
        private System.Windows.Forms.Button lbl9;
        private System.Windows.Forms.Button lbl8;
        private System.Windows.Forms.Button lbl7;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
    }
}

