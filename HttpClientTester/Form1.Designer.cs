namespace HttpClientTester;

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
        txtUrl = new TextBox();
        lblUrl = new Label();
        tabControl1 = new TabControl();
        tpSettings = new TabPage();
        grpHeader = new GroupBox();
        txtUserAgent = new TextBox();
        lblUserAgent = new Label();
        cmbHttpMethod = new ComboBox();
        lblHttpMethod = new Label();
        tpResult = new TabPage();
        label1 = new Label();
        txtResult = new Label();
        lstResult = new ListBox();
        button1 = new Button();
        statusBar1 = new StatusStrip();
        tslStatus = new ToolStripStatusLabel();
        tabControl1.SuspendLayout();
        tpSettings.SuspendLayout();
        grpHeader.SuspendLayout();
        tpResult.SuspendLayout();
        statusBar1.SuspendLayout();
        SuspendLayout();
        // 
        // txtUrl
        // 
        txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtUrl.Location = new Point(68, 12);
        txtUrl.Name = "txtUrl";
        txtUrl.Size = new Size(866, 23);
        txtUrl.TabIndex = 0;
        // 
        // lblUrl
        // 
        lblUrl.AutoSize = true;
        lblUrl.Location = new Point(16, 15);
        lblUrl.Name = "lblUrl";
        lblUrl.Size = new Size(34, 15);
        lblUrl.TabIndex = 1;
        lblUrl.Text = "URL :";
        // 
        // tabControl1
        // 
        tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabControl1.Controls.Add(tpSettings);
        tabControl1.Controls.Add(tpResult);
        tabControl1.Location = new Point(12, 98);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(926, 478);
        tabControl1.TabIndex = 0;
        // 
        // tpSettings
        // 
        tpSettings.Controls.Add(grpHeader);
        tpSettings.Controls.Add(cmbHttpMethod);
        tpSettings.Controls.Add(lblHttpMethod);
        tpSettings.Location = new Point(4, 24);
        tpSettings.Name = "tpSettings";
        tpSettings.Padding = new Padding(3);
        tpSettings.Size = new Size(918, 450);
        tpSettings.TabIndex = 1;
        tpSettings.Text = "Settings";
        tpSettings.UseVisualStyleBackColor = true;
        // 
        // grpHeader
        // 
        grpHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grpHeader.Controls.Add(txtUserAgent);
        grpHeader.Controls.Add(lblUserAgent);
        grpHeader.Location = new Point(22, 66);
        grpHeader.Name = "grpHeader";
        grpHeader.Size = new Size(876, 378);
        grpHeader.TabIndex = 4;
        grpHeader.TabStop = false;
        grpHeader.Text = " Header ";
        // 
        // txtUserAgent
        // 
        txtUserAgent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtUserAgent.Location = new Point(105, 22);
        txtUserAgent.Name = "txtUserAgent";
        txtUserAgent.Size = new Size(754, 23);
        txtUserAgent.TabIndex = 1;
        txtUserAgent.Text = "\r\nMozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36";
        // 
        // lblUserAgent
        // 
        lblUserAgent.AutoSize = true;
        lblUserAgent.Location = new Point(17, 25);
        lblUserAgent.Name = "lblUserAgent";
        lblUserAgent.Size = new Size(71, 15);
        lblUserAgent.TabIndex = 0;
        lblUserAgent.Text = "User Agent :";
        // 
        // cmbHttpMethod
        // 
        cmbHttpMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbHttpMethod.FormattingEnabled = true;
        cmbHttpMethod.Items.AddRange(new object[] { "GET", "POST" });
        cmbHttpMethod.Location = new Point(110, 22);
        cmbHttpMethod.Name = "cmbHttpMethod";
        cmbHttpMethod.Size = new Size(248, 23);
        cmbHttpMethod.TabIndex = 3;
        // 
        // lblHttpMethod
        // 
        lblHttpMethod.AutoSize = true;
        lblHttpMethod.Location = new Point(22, 25);
        lblHttpMethod.Name = "lblHttpMethod";
        lblHttpMethod.Size = new Size(82, 15);
        lblHttpMethod.TabIndex = 2;
        lblHttpMethod.Text = "Http Method :";
        // 
        // tpResult
        // 
        tpResult.Controls.Add(label1);
        tpResult.Controls.Add(txtResult);
        tpResult.Controls.Add(lstResult);
        tpResult.Location = new Point(4, 24);
        tpResult.Name = "tpResult";
        tpResult.Padding = new Padding(3);
        tpResult.Size = new Size(918, 450);
        tpResult.TabIndex = 0;
        tpResult.Text = "Result";
        tpResult.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label1.AutoSize = true;
        label1.Location = new Point(19, 417);
        label1.Name = "label1";
        label1.Size = new Size(415, 15);
        label1.TabIndex = 2;
        label1.Text = "Note: For copy row content to clipboard, select row and press (CTRL+C) keys.";
        // 
        // txtResult
        // 
        txtResult.AutoSize = true;
        txtResult.Location = new Point(19, 19);
        txtResult.Name = "txtResult";
        txtResult.Size = new Size(304, 15);
        txtResult.TabIndex = 1;
        txtResult.Text = "The result of executing the command is displayed below";
        // 
        // lstResult
        // 
        lstResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lstResult.FormattingEnabled = true;
        lstResult.ItemHeight = 15;
        lstResult.Location = new Point(19, 51);
        lstResult.Name = "lstResult";
        lstResult.ScrollAlwaysVisible = true;
        lstResult.Size = new Size(879, 349);
        lstResult.TabIndex = 0;
        lstResult.KeyDown += lstResult_KeyDown;
        lstResult.Leave += lstResult_Leave;
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        button1.Location = new Point(16, 50);
        button1.Name = "button1";
        button1.Size = new Size(918, 34);
        button1.TabIndex = 2;
        button1.Text = "Test URL";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // statusBar1
        // 
        statusBar1.Items.AddRange(new ToolStripItem[] { tslStatus });
        statusBar1.Location = new Point(0, 595);
        statusBar1.Name = "statusBar1";
        statusBar1.Size = new Size(950, 22);
        statusBar1.TabIndex = 3;
        statusBar1.Text = "statusBar1";
        // 
        // tslStatus
        // 
        tslStatus.Name = "tslStatus";
        tslStatus.Size = new Size(39, 17);
        tslStatus.Text = "Ready";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(950, 617);
        Controls.Add(statusBar1);
        Controls.Add(button1);
        Controls.Add(lblUrl);
        Controls.Add(txtUrl);
        Controls.Add(tabControl1);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Http Client Tester - v1.0.2";
        Load += Form1_Load;
        tabControl1.ResumeLayout(false);
        tpSettings.ResumeLayout(false);
        tpSettings.PerformLayout();
        grpHeader.ResumeLayout(false);
        grpHeader.PerformLayout();
        tpResult.ResumeLayout(false);
        tpResult.PerformLayout();
        statusBar1.ResumeLayout(false);
        statusBar1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtUrl;
    private Label lblUrl;
    private TabControl tabControl1;
    private TabPage tpResult;
    private ListBox lstResult;
    private TabPage tpSettings;
    private TextBox txtUserAgent;
    private Label lblUserAgent;
    private Label txtResult;
    private ComboBox cmbHttpMethod;
    private Label lblHttpMethod;
    private GroupBox grpHeader;
    private Button button1;
    private StatusStrip statusBar1;
    private ToolStripStatusLabel tslStatus;
    private Label label1;
}
