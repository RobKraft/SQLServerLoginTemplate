namespace SQLServerLoginTemplate
{
	partial class FormConnectToSQLServer
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
			this.labelServerName = new System.Windows.Forms.Label();
			this.labelAuthentication = new System.Windows.Forms.Label();
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.comboBoxServerName = new System.Windows.Forms.ComboBox();
			this.comboBoxLogin = new System.Windows.Forms.ComboBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonHelp = new System.Windows.Forms.Button();
			this.buttonOptions = new System.Windows.Forms.Button();
			this.checkBoxRememberPassword = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelSQLServer = new System.Windows.Forms.Label();
			this.comboBoxAuthentication = new System.Windows.Forms.ComboBox();
			this.labelServerType = new System.Windows.Forms.Label();
			this.comboBoxServerType = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// labelServerName
			// 
			this.labelServerName.AutoSize = true;
			this.labelServerName.Location = new System.Drawing.Point(42, 271);
			this.labelServerName.Name = "labelServerName";
			this.labelServerName.Size = new System.Drawing.Size(207, 37);
			this.labelServerName.TabIndex = 0;
			this.labelServerName.Text = "&Server name:";
			// 
			// labelAuthentication
			// 
			this.labelAuthentication.AutoSize = true;
			this.labelAuthentication.Location = new System.Drawing.Point(42, 349);
			this.labelAuthentication.Name = "labelAuthentication";
			this.labelAuthentication.Size = new System.Drawing.Size(230, 37);
			this.labelAuthentication.TabIndex = 1;
			this.labelAuthentication.Text = "&Authentication:";
			// 
			// labelLogin
			// 
			this.labelLogin.AutoSize = true;
			this.labelLogin.Location = new System.Drawing.Point(105, 423);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(105, 37);
			this.labelLogin.TabIndex = 2;
			this.labelLogin.Text = "&Login:";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(105, 495);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(167, 37);
			this.labelPassword.TabIndex = 3;
			this.labelPassword.Text = "&Password:";
			// 
			// comboBoxServerName
			// 
			this.comboBoxServerName.FormattingEnabled = true;
			this.comboBoxServerName.Location = new System.Drawing.Point(543, 263);
			this.comboBoxServerName.Name = "comboBoxServerName";
			this.comboBoxServerName.Size = new System.Drawing.Size(960, 45);
			this.comboBoxServerName.TabIndex = 6;
			this.comboBoxServerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxServerName_SelectedIndexChanged);
			// 
			// comboBoxLogin
			// 
			this.comboBoxLogin.FormattingEnabled = true;
			this.comboBoxLogin.Location = new System.Drawing.Point(604, 415);
			this.comboBoxLogin.Name = "comboBoxLogin";
			this.comboBoxLogin.Size = new System.Drawing.Size(899, 45);
			this.comboBoxLogin.TabIndex = 8;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(604, 488);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(899, 44);
			this.textBoxPassword.TabIndex = 9;
			// 
			// buttonConnect
			// 
			this.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonConnect.Location = new System.Drawing.Point(486, 690);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(232, 61);
			this.buttonConnect.TabIndex = 10;
			this.buttonConnect.Text = "&Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(743, 690);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(218, 61);
			this.buttonCancel.TabIndex = 11;
			this.buttonCancel.Text = "C&ancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonHelp
			// 
			this.buttonHelp.Location = new System.Drawing.Point(983, 687);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new System.Drawing.Size(257, 64);
			this.buttonHelp.TabIndex = 12;
			this.buttonHelp.Text = "&Help";
			this.buttonHelp.UseVisualStyleBackColor = true;
			// 
			// buttonOptions
			// 
			this.buttonOptions.Location = new System.Drawing.Point(1261, 690);
			this.buttonOptions.Name = "buttonOptions";
			this.buttonOptions.Size = new System.Drawing.Size(246, 61);
			this.buttonOptions.TabIndex = 13;
			this.buttonOptions.Text = "&Options >>";
			this.buttonOptions.UseVisualStyleBackColor = true;
			// 
			// checkBoxRememberPassword
			// 
			this.checkBoxRememberPassword.AutoSize = true;
			this.checkBoxRememberPassword.Location = new System.Drawing.Point(604, 565);
			this.checkBoxRememberPassword.Name = "checkBoxRememberPassword";
			this.checkBoxRememberPassword.Size = new System.Drawing.Size(366, 41);
			this.checkBoxRememberPassword.TabIndex = 14;
			this.checkBoxRememberPassword.Text = "Re&member password";
			this.checkBoxRememberPassword.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(36, 656);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1467, 10);
			this.label1.TabIndex = 15;
			// 
			// labelSQLServer
			// 
			this.labelSQLServer.AutoSize = true;
			this.labelSQLServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSQLServer.Location = new System.Drawing.Point(526, 58);
			this.labelSQLServer.Name = "labelSQLServer";
			this.labelSQLServer.Size = new System.Drawing.Size(501, 101);
			this.labelSQLServer.TabIndex = 16;
			this.labelSQLServer.Text = "SQL Server";
			// 
			// comboBoxAuthentication
			// 
			this.comboBoxAuthentication.FormattingEnabled = true;
			this.comboBoxAuthentication.Location = new System.Drawing.Point(543, 341);
			this.comboBoxAuthentication.Name = "comboBoxAuthentication";
			this.comboBoxAuthentication.Size = new System.Drawing.Size(960, 45);
			this.comboBoxAuthentication.TabIndex = 7;
			this.comboBoxAuthentication.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthentication_SelectedIndexChanged);
			// 
			// labelServerType
			// 
			this.labelServerType.AutoSize = true;
			this.labelServerType.Location = new System.Drawing.Point(42, 191);
			this.labelServerType.Name = "labelServerType";
			this.labelServerType.Size = new System.Drawing.Size(197, 37);
			this.labelServerType.TabIndex = 17;
			this.labelServerType.Text = "S&erver Type:";
			// 
			// comboBoxServerType
			// 
			this.comboBoxServerType.FormattingEnabled = true;
			this.comboBoxServerType.Location = new System.Drawing.Point(543, 191);
			this.comboBoxServerType.Name = "comboBoxServerType";
			this.comboBoxServerType.Size = new System.Drawing.Size(960, 45);
			this.comboBoxServerType.TabIndex = 18;
			// 
			// FormConnectToSQLServer
			// 
			this.AcceptButton = this.buttonConnect;
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(1534, 776);
			this.Controls.Add(this.comboBoxServerType);
			this.Controls.Add(this.labelServerType);
			this.Controls.Add(this.labelSQLServer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBoxRememberPassword);
			this.Controls.Add(this.buttonOptions);
			this.Controls.Add(this.buttonHelp);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonConnect);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.comboBoxLogin);
			this.Controls.Add(this.comboBoxAuthentication);
			this.Controls.Add(this.comboBoxServerName);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.labelLogin);
			this.Controls.Add(this.labelAuthentication);
			this.Controls.Add(this.labelServerName);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormConnectToSQLServer";
			this.Text = "Connect to Server";
			this.Load += new System.EventHandler(this.FormConnectToSQLServer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelServerName;
		private System.Windows.Forms.Label labelAuthentication;
		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.ComboBox comboBoxServerName;
		private System.Windows.Forms.ComboBox comboBoxLogin;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonHelp;
		private System.Windows.Forms.Button buttonOptions;
		private System.Windows.Forms.CheckBox checkBoxRememberPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelSQLServer;
		private System.Windows.Forms.ComboBox comboBoxAuthentication;
		private System.Windows.Forms.Label labelServerType;
		private System.Windows.Forms.ComboBox comboBoxServerType;
	}
}