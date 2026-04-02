namespace LoginScreen3
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
            lblLogin = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblLogin.Location = new Point(132, 46);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(207, 86);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = SystemColors.MenuBar;
            txtID.Location = new Point(42, 161);
            txtID.Name = "txtID";
            txtID.Size = new Size(389, 57);
            txtID.TabIndex = 1;
            txtID.Text = "아이디";
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = SystemColors.Menu;
            txtPW.Location = new Point(42, 253);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(389, 57);
            txtPW.TabIndex = 2;
            txtPW.Text = "패스워드";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 255, 255);
            btnLogin.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = SystemColors.Highlight;
            btnLogin.Location = new Point(149, 340);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(166, 83);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "button1";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
    }
}
