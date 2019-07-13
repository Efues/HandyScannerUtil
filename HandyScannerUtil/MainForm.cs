using System;
using System.Linq;
using System.Windows.Forms;

using Efues.Utility;

namespace HandyScannerUtil
{
  public partial class MainForm : Form
  {
    private readonly PortManager _portManager;

    public MainForm()
    {
      InitializeComponent();
      _portManager = new PortManager(this.serialPort);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      var deviceComMap = _portManager.DeviceComNameMap;
      if (deviceComMap.Count() > 0)
      {
        comboBoxDevice.DataSource = new BindingSource(deviceComMap, null);
        comboBoxDevice.DisplayMember = "Key";
        comboBoxDevice.ValueMember = "Value";
      }
      else
      {
        comboBoxDevice.DataSource = null;
      }

      if(deviceComMap.Count() == 1)
      {
        buttonConnect_Click(this, null);
      }
    }

    private void buttonConnect_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.comboBoxDevice.SelectedValue is string selectedValue && selectedValue != null)
        {
          this._portManager.Connect(selectedValue);
          textBoxStatus.AppendText("Connected!");
          textBoxStatus.AppendText(Environment.NewLine);
          buttonConnect.Enabled = false;
        }
        else
        {
          textBoxStatus.AppendText("No device is selected.");
          textBoxStatus.AppendText(Environment.NewLine);
        }
      }
      catch (Exception exp)
      {
        textBoxStatus.AppendText("Error!");
        textBoxStatus.AppendText(Environment.NewLine);
        textBoxStatus.AppendText(exp.Message);
        textBoxStatus.AppendText(Environment.NewLine);
      }
    }

    private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
    {
      try
      {
        Response(this._portManager.Read());
      }
      catch (System.Exception exp)
      {
        textBoxStatus.AppendText("Error!");
        textBoxStatus.AppendText(Environment.NewLine);
        textBoxStatus.AppendText(exp.Message);
        textBoxStatus.AppendText(Environment.NewLine);
      }
    }

    #region MultiThreadHandle
    // 別スレッドからFormに変更を加えるための処理
    delegate void SetTextCallback(string text);
    private void Response(string readLine)
    {
      if (this.InvokeRequired)
      {
        SetTextCallback data = new SetTextCallback(Response);
        BeginInvoke(data, new object[] { readLine });
      }
      else
      {
        // Main処理開始
        Main(readLine);
      }
    }
    #endregion


    #region Main
    private void Main(string readLine)
    {
      try
      {
        textBoxStatus.AppendText("Scanned!...");
        textBoxStatus.AppendText(Environment.NewLine);
        textBoxStatus.AppendText(readLine);
        textBoxStatus.AppendText(Environment.NewLine);
      }
      catch (Exception exp)
      {
        textBoxStatus.AppendText(exp.Message);
        textBoxStatus.AppendText(Environment.NewLine);
      }
    }
    #endregion

    private void buttonClear_Click(object sender, EventArgs e)
    {
      textBoxStatus.Clear();
    }
  }
}
