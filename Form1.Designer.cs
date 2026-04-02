namespace LoginScreen
{
    partial class Form1
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
            btnLogin = new Button();
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            lblErrorMsg = new Label();
            btnIDclear = new Button();
            btnPWclear = new Button();
            btnPWcheck = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CadetBlue;
            btnLogin.Font = new Font("굴림", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(200, 336);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(280, 83);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Imprint MT Shadow", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.Black;
            lblAppName.Location = new Point(224, 33);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(221, 85);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(93, 148);
            txtID.Name = "txtID";
            txtID.Size = new Size(477, 61);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.TextChanged += txtID_TextChanged;
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(93, 233);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(477, 61);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.TextChanged += txtPW_TextChanged;
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(93, 297);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(346, 25);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // btnIDclear
            // 
            btnIDclear.BackColor = SystemColors.ControlDark;
            btnIDclear.Location = new Point(586, 161);
            btnIDclear.Name = "btnIDclear";
            btnIDclear.Size = new Size(39, 34);
            btnIDclear.TabIndex = 5;
            btnIDclear.Text = "X";
            btnIDclear.UseVisualStyleBackColor = false;
            btnIDclear.Click += btnIDclear_Click;
            // 
            // btnPWclear
            // 
            btnPWclear.BackColor = SystemColors.ControlDark;
            btnPWclear.Location = new Point(586, 246);
            btnPWclear.Name = "btnPWclear";
            btnPWclear.Size = new Size(39, 34);
            btnPWclear.TabIndex = 6;
            btnPWclear.Text = "X";
            btnPWclear.UseVisualStyleBackColor = false;
            btnPWclear.Click += btnPWclear_Click;
            // 
            // btnPWcheck
            // 
            btnPWcheck.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPWcheck.BackColor = SystemColors.ActiveCaptionText;
            btnPWcheck.FlatStyle = FlatStyle.System;
            btnPWcheck.Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnPWcheck.ForeColor = SystemColors.ActiveCaptionText;
            btnPWcheck.ImageAlign = ContentAlignment.MiddleLeft;
            btnPWcheck.Location = new Point(466, 300);
            btnPWcheck.Name = "btnPWcheck";
            btnPWcheck.Size = new Size(159, 34);
            btnPWcheck.TabIndex = 7;
            btnPWcheck.Text = "패스워드 확인";
            btnPWcheck.UseVisualStyleBackColor = false;
            btnPWcheck.Click += btnPWcheck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(672, 450);
            Controls.Add(btnPWcheck);
            Controls.Add(btnPWclear);
            Controls.Add(btnIDclear);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Login Screen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Label lblErrorMsg;
        private Button btnIDclear;
        private Button btnPWclear;
        private Button btnPWcheck;
    }
}
