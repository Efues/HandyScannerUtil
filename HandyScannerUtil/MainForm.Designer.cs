namespace HandyScannerUtil
{
  partial class MainForm
  {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.comboBoxDevice = new System.Windows.Forms.ComboBox();
      this.buttonConnect = new System.Windows.Forms.Button();
      this.serialPort = new System.IO.Ports.SerialPort(this.components);
      this.groupBoxStatus = new System.Windows.Forms.GroupBox();
      this.buttonClear = new System.Windows.Forms.Button();
      this.textBoxStatus = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBoxStatus.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.comboBoxDevice);
      this.groupBox1.Controls.Add(this.buttonConnect);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(776, 107);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Scanner";
      // 
      // comboBoxDevice
      // 
      this.comboBoxDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxDevice.FormattingEnabled = true;
      this.comboBoxDevice.Location = new System.Drawing.Point(7, 24);
      this.comboBoxDevice.Name = "comboBoxDevice";
      this.comboBoxDevice.Size = new System.Drawing.Size(760, 26);
      this.comboBoxDevice.TabIndex = 3;
      // 
      // buttonConnect
      // 
      this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonConnect.Location = new System.Drawing.Point(591, 62);
      this.buttonConnect.Name = "buttonConnect";
      this.buttonConnect.Size = new System.Drawing.Size(177, 30);
      this.buttonConnect.TabIndex = 2;
      this.buttonConnect.Text = "Connect";
      this.buttonConnect.UseVisualStyleBackColor = true;
      this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
      // 
      // serialPort
      // 
      this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
      // 
      // groupBoxStatus
      // 
      this.groupBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxStatus.Controls.Add(this.textBoxStatus);
      this.groupBoxStatus.Controls.Add(this.buttonClear);
      this.groupBoxStatus.Location = new System.Drawing.Point(12, 125);
      this.groupBoxStatus.Name = "groupBoxStatus";
      this.groupBoxStatus.Size = new System.Drawing.Size(776, 347);
      this.groupBoxStatus.TabIndex = 2;
      this.groupBoxStatus.TabStop = false;
      this.groupBoxStatus.Text = "Status";
      // 
      // buttonClear
      // 
      this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonClear.Location = new System.Drawing.Point(591, 310);
      this.buttonClear.Name = "buttonClear";
      this.buttonClear.Size = new System.Drawing.Size(176, 31);
      this.buttonClear.TabIndex = 0;
      this.buttonClear.Text = "Clear";
      this.buttonClear.UseVisualStyleBackColor = true;
      this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
      // 
      // textBoxStatus
      // 
      this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxStatus.Location = new System.Drawing.Point(7, 24);
      this.textBoxStatus.Multiline = true;
      this.textBoxStatus.Name = "textBoxStatus";
      this.textBoxStatus.Size = new System.Drawing.Size(760, 280);
      this.textBoxStatus.TabIndex = 1;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 484);
      this.Controls.Add(this.groupBoxStatus);
      this.Controls.Add(this.groupBox1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBoxStatus.ResumeLayout(false);
      this.groupBoxStatus.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ComboBox comboBoxDevice;
    private System.Windows.Forms.Button buttonConnect;
    private System.IO.Ports.SerialPort serialPort;
    private System.Windows.Forms.GroupBox groupBoxStatus;
    private System.Windows.Forms.TextBox textBoxStatus;
    private System.Windows.Forms.Button buttonClear;
  }
}

