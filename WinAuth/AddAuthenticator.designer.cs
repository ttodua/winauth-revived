namespace WinAuth
{
    partial class AddAuthenticator
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
            this.components = new System.ComponentModel.Container();
            this.secretCodeField = new MetroFramework.Controls.MetroTextBox();
            this.step1Label = new MetroFramework.Controls.MetroLabel();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.nameField = new MetroFramework.Controls.MetroTextBox();
            this.step2Label = new MetroFramework.Controls.MetroLabel();
            this.verifyButton = new MetroFramework.Controls.MetroButton();
            this.codeProgress = new System.Windows.Forms.ProgressBar();
            this.codeField = new WinAuth.SecretTextBox();
            this.step5Label = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.step4TimerLabel = new MetroFramework.Controls.MetroLabel();
            this.timeBasedRadio = new MetroFramework.Controls.MetroRadioButton();
            this.counterBasedRadio = new MetroFramework.Controls.MetroRadioButton();
            this.timeBasedPanel = new System.Windows.Forms.Panel();
            this.counterBasedPanel = new System.Windows.Forms.Panel();
            this.verifyCounterButton = new MetroFramework.Controls.MetroButton();
            this.counterField = new MetroFramework.Controls.MetroTextBox();
            this.step4CounterLabel = new MetroFramework.Controls.MetroLabel();
            this.hashField = new MetroFramework.Controls.MetroComboBox();
            this.intervalField = new MetroFramework.Controls.MetroTextBox();
            this.labelTYpe = new MetroFramework.Controls.MetroLabel();
            this.hashLabel = new MetroFramework.Controls.MetroLabel();
            this.periodLabel = new MetroFramework.Controls.MetroLabel();
            this.digitsField = new MetroFramework.Controls.MetroTextBox();
            this.digitsLabel = new MetroFramework.Controls.MetroLabel();
            this.intervalLabelPost = new MetroFramework.Controls.MetroLabel();
            this.dragImagePanel = new System.Windows.Forms.Panel();
            this.label_dragimage = new System.Windows.Forms.Label();
            this.timeBasedPanel.SuspendLayout();
            this.counterBasedPanel.SuspendLayout();
            this.dragImagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // secretCodeField
            // 
            this.secretCodeField.AllowDrop = true;
            this.secretCodeField.CausesValidation = false;
            this.secretCodeField.Location = new System.Drawing.Point(56, 172);
            this.secretCodeField.Margin = new System.Windows.Forms.Padding(4);
            this.secretCodeField.MaxLength = 32767;
            this.secretCodeField.Name = "secretCodeField";
            this.secretCodeField.PasswordChar = '\0';
            this.secretCodeField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.secretCodeField.SelectedText = "";
            this.secretCodeField.Size = new System.Drawing.Size(520, 27);
            this.secretCodeField.TabIndex = 1;
            this.secretCodeField.UseSelectable = true;
            this.secretCodeField.DragDrop += new System.Windows.Forms.DragEventHandler(this.secretCodeField_dragdrop);
            this.secretCodeField.DragEnter += new System.Windows.Forms.DragEventHandler(this.secretCodeField_DragEnter);
            this.secretCodeField.Leave += new System.EventHandler(this.secretCodeField_Leave);
            // 
            // step1Label
            // 
            this.step1Label.Location = new System.Drawing.Point(37, 121);
            this.step1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.step1Label.Name = "step1Label";
            this.step1Label.Size = new System.Drawing.Size(567, 59);
            this.step1Label.TabIndex = 1;
            this.step1Label.Text = "1. Enter the Secret Code or KeyUri string ( spaces don\'t matter ). You can paste " +
    "the QR image URL instead or drag image itself.\r\n";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(389, 732);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseSelectable = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(497, 732);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(37, 86);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 19);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(109, 82);
            this.nameField.Margin = new System.Windows.Forms.Padding(4);
            this.nameField.MaxLength = 32767;
            this.nameField.Name = "nameField";
            this.nameField.PasswordChar = '\0';
            this.nameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameField.SelectedText = "";
            this.nameField.Size = new System.Drawing.Size(488, 27);
            this.nameField.TabIndex = 0;
            this.nameField.UseSelectable = true;
            // 
            // step2Label
            // 
            this.step2Label.Location = new System.Drawing.Point(33, 258);
            this.step2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.step2Label.Name = "step2Label";
            this.step2Label.Size = new System.Drawing.Size(564, 60);
            this.step2Label.TabIndex = 10;
            this.step2Label.Text = "2. Select additional settings. If you don\'t know, it\'s likely the pre-selected on" +
    "es so just leave the default choice.";
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(203, 53);
            this.verifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(211, 28);
            this.verifyButton.TabIndex = 2;
            this.verifyButton.Text = "Verify Authenticator";
            this.verifyButton.UseSelectable = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // codeProgress
            // 
            this.codeProgress.Location = new System.Drawing.Point(207, 683);
            this.codeProgress.Margin = new System.Windows.Forms.Padding(4);
            this.codeProgress.Maximum = 30;
            this.codeProgress.Minimum = 1;
            this.codeProgress.Name = "codeProgress";
            this.codeProgress.Size = new System.Drawing.Size(211, 10);
            this.codeProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.codeProgress.TabIndex = 13;
            this.codeProgress.Value = 1;
            this.codeProgress.Visible = false;
            // 
            // codeField
            // 
            this.codeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.codeField.Location = new System.Drawing.Point(207, 644);
            this.codeField.Margin = new System.Windows.Forms.Padding(4);
            this.codeField.Multiline = true;
            this.codeField.Name = "codeField";
            this.codeField.SecretMode = false;
            this.codeField.Size = new System.Drawing.Size(209, 31);
            this.codeField.SpaceOut = 3;
            this.codeField.TabIndex = 5;
            // 
            // step5Label
            // 
            this.step5Label.AutoSize = true;
            this.step5Label.Location = new System.Drawing.Point(37, 610);
            this.step5Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.step5Label.Name = "step5Label";
            this.step5Label.Size = new System.Drawing.Size(296, 19);
            this.step5Label.TabIndex = 11;
            this.step5Label.Text = "4. Verify the following code matches your service.";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // step4TimerLabel
            // 
            this.step4TimerLabel.Location = new System.Drawing.Point(31, 15);
            this.step4TimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.step4TimerLabel.Name = "step4TimerLabel";
            this.step4TimerLabel.Size = new System.Drawing.Size(564, 34);
            this.step4TimerLabel.TabIndex = 10;
            this.step4TimerLabel.Text = "3. Click the Verify button to check the first code.";
            // 
            // timeBasedRadio
            // 
            this.timeBasedRadio.AutoSize = true;
            this.timeBasedRadio.Checked = true;
            this.timeBasedRadio.Location = new System.Drawing.Point(248, 322);
            this.timeBasedRadio.Margin = new System.Windows.Forms.Padding(4);
            this.timeBasedRadio.Name = "timeBasedRadio";
            this.timeBasedRadio.Size = new System.Drawing.Size(85, 15);
            this.timeBasedRadio.TabIndex = 5;
            this.timeBasedRadio.TabStop = true;
            this.timeBasedRadio.Text = "Time-based";
            this.timeBasedRadio.UseSelectable = true;
            this.timeBasedRadio.CheckedChanged += new System.EventHandler(this.timeBasedRadio_CheckedChanged);
            // 
            // counterBasedRadio
            // 
            this.counterBasedRadio.AutoSize = true;
            this.counterBasedRadio.Location = new System.Drawing.Point(413, 322);
            this.counterBasedRadio.Margin = new System.Windows.Forms.Padding(4);
            this.counterBasedRadio.Name = "counterBasedRadio";
            this.counterBasedRadio.Size = new System.Drawing.Size(102, 15);
            this.counterBasedRadio.TabIndex = 6;
            this.counterBasedRadio.Text = "Counter-based";
            this.counterBasedRadio.UseSelectable = true;
            this.counterBasedRadio.CheckedChanged += new System.EventHandler(this.counterBasedRadio_CheckedChanged);
            // 
            // timeBasedPanel
            // 
            this.timeBasedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeBasedPanel.Controls.Add(this.step4TimerLabel);
            this.timeBasedPanel.Controls.Add(this.verifyButton);
            this.timeBasedPanel.Location = new System.Drawing.Point(7, 469);
            this.timeBasedPanel.Margin = new System.Windows.Forms.Padding(4);
            this.timeBasedPanel.Name = "timeBasedPanel";
            this.timeBasedPanel.Size = new System.Drawing.Size(619, 103);
            this.timeBasedPanel.TabIndex = 15;
            // 
            // counterBasedPanel
            // 
            this.counterBasedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.counterBasedPanel.Controls.Add(this.verifyCounterButton);
            this.counterBasedPanel.Controls.Add(this.counterField);
            this.counterBasedPanel.Controls.Add(this.step4CounterLabel);
            this.counterBasedPanel.Location = new System.Drawing.Point(7, 466);
            this.counterBasedPanel.Margin = new System.Windows.Forms.Padding(4);
            this.counterBasedPanel.Name = "counterBasedPanel";
            this.counterBasedPanel.Size = new System.Drawing.Size(619, 103);
            this.counterBasedPanel.TabIndex = 2;
            this.counterBasedPanel.Visible = false;
            // 
            // verifyCounterButton
            // 
            this.verifyCounterButton.Location = new System.Drawing.Point(272, 69);
            this.verifyCounterButton.Margin = new System.Windows.Forms.Padding(4);
            this.verifyCounterButton.Name = "verifyCounterButton";
            this.verifyCounterButton.Size = new System.Drawing.Size(211, 28);
            this.verifyCounterButton.TabIndex = 2;
            this.verifyCounterButton.Text = "Verify Authenticator";
            this.verifyCounterButton.UseSelectable = true;
            this.verifyCounterButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // counterField
            // 
            this.counterField.AllowDrop = true;
            this.counterField.CausesValidation = false;
            this.counterField.Location = new System.Drawing.Point(159, 71);
            this.counterField.Margin = new System.Windows.Forms.Padding(4);
            this.counterField.MaxLength = 32767;
            this.counterField.Name = "counterField";
            this.counterField.PasswordChar = '\0';
            this.counterField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.counterField.SelectedText = "";
            this.counterField.Size = new System.Drawing.Size(105, 25);
            this.counterField.TabIndex = 0;
            this.counterField.UseSelectable = true;
            // 
            // step4CounterLabel
            // 
            this.step4CounterLabel.Location = new System.Drawing.Point(31, 15);
            this.step4CounterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.step4CounterLabel.Name = "step4CounterLabel";
            this.step4CounterLabel.Size = new System.Drawing.Size(564, 53);
            this.step4CounterLabel.TabIndex = 10;
            this.step4CounterLabel.Text = "3. Enter the initial counter value if known. Click the Verify button that will sh" +
    "ow the last code that was used.";
            // 
            // hashField
            // 
            this.hashField.FormattingEnabled = true;
            this.hashField.ItemHeight = 23;
            this.hashField.Items.AddRange(new object[] {
            "HMAC-SHA1",
            "HMAC-SHA256",
            "HMAC-SHA512"});
            this.hashField.Location = new System.Drawing.Point(248, 353);
            this.hashField.Margin = new System.Windows.Forms.Padding(4);
            this.hashField.Name = "hashField";
            this.hashField.Size = new System.Drawing.Size(131, 29);
            this.hashField.TabIndex = 7;
            this.hashField.UseSelectable = true;
            // 
            // intervalField
            // 
            this.intervalField.AllowDrop = true;
            this.intervalField.CausesValidation = false;
            this.intervalField.Location = new System.Drawing.Point(248, 396);
            this.intervalField.Margin = new System.Windows.Forms.Padding(4);
            this.intervalField.MaxLength = 32767;
            this.intervalField.Name = "intervalField";
            this.intervalField.PasswordChar = '\0';
            this.intervalField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.intervalField.SelectedText = "";
            this.intervalField.Size = new System.Drawing.Size(128, 27);
            this.intervalField.TabIndex = 8;
            this.intervalField.UseSelectable = true;
            // 
            // labelTYpe
            // 
            this.labelTYpe.Location = new System.Drawing.Point(109, 319);
            this.labelTYpe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTYpe.Name = "labelTYpe";
            this.labelTYpe.Size = new System.Drawing.Size(96, 26);
            this.labelTYpe.TabIndex = 10;
            this.labelTYpe.Text = "Type";
            // 
            // hashLabel
            // 
            this.hashLabel.Location = new System.Drawing.Point(109, 358);
            this.hashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(96, 26);
            this.hashLabel.TabIndex = 10;
            this.hashLabel.Text = "Hash";
            // 
            // periodLabel
            // 
            this.periodLabel.Location = new System.Drawing.Point(109, 396);
            this.periodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(96, 26);
            this.periodLabel.TabIndex = 10;
            this.periodLabel.Text = "Interval";
            // 
            // digitsField
            // 
            this.digitsField.AllowDrop = true;
            this.digitsField.CausesValidation = false;
            this.digitsField.Location = new System.Drawing.Point(248, 431);
            this.digitsField.Margin = new System.Windows.Forms.Padding(4);
            this.digitsField.MaxLength = 32767;
            this.digitsField.Name = "digitsField";
            this.digitsField.PasswordChar = '\0';
            this.digitsField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.digitsField.SelectedText = "";
            this.digitsField.Size = new System.Drawing.Size(128, 27);
            this.digitsField.TabIndex = 9;
            this.digitsField.UseSelectable = true;
            // 
            // digitsLabel
            // 
            this.digitsLabel.Location = new System.Drawing.Point(109, 431);
            this.digitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.digitsLabel.Name = "digitsLabel";
            this.digitsLabel.Size = new System.Drawing.Size(96, 26);
            this.digitsLabel.TabIndex = 10;
            this.digitsLabel.Text = "Digits";
            // 
            // intervalLabelPost
            // 
            this.intervalLabelPost.Location = new System.Drawing.Point(389, 396);
            this.intervalLabelPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.intervalLabelPost.Name = "intervalLabelPost";
            this.intervalLabelPost.Size = new System.Drawing.Size(172, 26);
            this.intervalLabelPost.TabIndex = 10;
            this.intervalLabelPost.Text = "seconds";
            // 
            // dragImagePanel
            // 
            this.dragImagePanel.AllowDrop = true;
            this.dragImagePanel.BackColor = System.Drawing.Color.SandyBrown;
            this.dragImagePanel.Controls.Add(this.label_dragimage);
            this.dragImagePanel.Location = new System.Drawing.Point(248, 206);
            this.dragImagePanel.Margin = new System.Windows.Forms.Padding(4);
            this.dragImagePanel.Name = "dragImagePanel";
            this.dragImagePanel.Size = new System.Drawing.Size(168, 48);
            this.dragImagePanel.TabIndex = 17;
            this.dragImagePanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragPanel_DragDrop);
            this.dragImagePanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragPanel_DragEnter);
            this.dragImagePanel.DragLeave += new System.EventHandler(this.dragImagePanel_DragLeave);
            // 
            // label_dragimage
            // 
            this.label_dragimage.AutoSize = true;
            this.label_dragimage.Location = new System.Drawing.Point(28, 0);
            this.label_dragimage.Name = "label_dragimage";
            this.label_dragimage.Size = new System.Drawing.Size(110, 16);
            this.label_dragimage.TabIndex = 17;
            this.label_dragimage.Text = "Image drag-zone";
            // 
            // AddAuthenticator
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(628, 789);
            this.Controls.Add(this.dragImagePanel);
            this.Controls.Add(this.hashField);
            this.Controls.Add(this.counterBasedPanel);
            this.Controls.Add(this.timeBasedPanel);
            this.Controls.Add(this.counterBasedRadio);
            this.Controls.Add(this.timeBasedRadio);
            this.Controls.Add(this.codeProgress);
            this.Controls.Add(this.codeField);
            this.Controls.Add(this.step5Label);
            this.Controls.Add(this.intervalLabelPost);
            this.Controls.Add(this.digitsLabel);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.hashLabel);
            this.Controls.Add(this.labelTYpe);
            this.Controls.Add(this.step2Label);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.digitsField);
            this.Controls.Add(this.intervalField);
            this.Controls.Add(this.secretCodeField);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.step1Label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddAuthenticator";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Add Authenticator";
            this.Load += new System.EventHandler(this.AddAuthenticator_Load);
            this.timeBasedPanel.ResumeLayout(false);
            this.counterBasedPanel.ResumeLayout(false);
            this.dragImagePanel.ResumeLayout(false);
            this.dragImagePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel step1Label;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroTextBox secretCodeField;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroTextBox nameField;
        private MetroFramework.Controls.MetroLabel step2Label;
        private MetroFramework.Controls.MetroButton verifyButton;
        private System.Windows.Forms.ProgressBar codeProgress;
        private SecretTextBox codeField;
        private MetroFramework.Controls.MetroLabel step5Label;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel step4TimerLabel;
        private MetroFramework.Controls.MetroRadioButton timeBasedRadio;
        private MetroFramework.Controls.MetroRadioButton counterBasedRadio;
        private System.Windows.Forms.Panel timeBasedPanel;
        private System.Windows.Forms.Panel counterBasedPanel;
        private MetroFramework.Controls.MetroLabel step4CounterLabel;
        private MetroFramework.Controls.MetroTextBox counterField;
        private MetroFramework.Controls.MetroButton verifyCounterButton;
        private MetroFramework.Controls.MetroComboBox hashField;
    private MetroFramework.Controls.MetroTextBox intervalField;
    private MetroFramework.Controls.MetroLabel labelTYpe;
    private MetroFramework.Controls.MetroLabel hashLabel;
    private MetroFramework.Controls.MetroLabel periodLabel;
    private MetroFramework.Controls.MetroTextBox digitsField;
    private MetroFramework.Controls.MetroLabel digitsLabel;
    private MetroFramework.Controls.MetroLabel intervalLabelPost;
        private System.Windows.Forms.Panel dragImagePanel;
        private System.Windows.Forms.Label label_dragimage;
    }
}