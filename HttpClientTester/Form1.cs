#nullable disable

using System.Net.Http.Headers;
using System.Windows.Forms;

namespace HttpClientTester;

public partial class Form1 : Form
{
    private ProductInfoHeaderValue productValue;
    private ProductInfoHeaderValue commentValue;
    private HttpClient httpClient;

    public Form1()
    {
        InitializeComponent();
    }


    private void Form1_Load(object sender, EventArgs e)
    {
        cmbHttpMethod.SelectedIndex = 0;
        tslStatus.Text = "Ready.";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        tslStatus.Text = "Working ...";

        if (!string.IsNullOrWhiteSpace(txtUrl.Text))
        {
            if (!string.IsNullOrWhiteSpace(txtUserAgent.Text))
            {
                try
                {
                    var httpClient = new HttpClient();
                    var request = new HttpRequestMessage(HttpMethod.Get, txtUrl.Text);

                    request.Headers.TryAddWithoutValidation("User-Agent", txtUserAgent.Text);

                    lstResult.Items.Add(httpClient.Send(request));
                }
                catch (Exception ex)
                {
                    lstResult.Items.Add($"Exception occured :\r\n{ex.Message}");
                }

                tabControl1.SelectedTab = tabControl1.TabPages["tpResult"];
            }
            else
            {
                MessageBox.Show("Field 'User Agent' cannot be empty.");
            }
        }
        else
        {
            MessageBox.Show("Field 'URL' cannot be empty.");
        }

        tslStatus.Text = "Ready.";
    }

    private void lstResult_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control == true && e.KeyCode == Keys.C)
        {

            string s = lstResult.SelectedItem.ToString();
            Clipboard.SetData(DataFormats.StringFormat, s);
            tslStatus.Text = "Selected row copied to Clipboard.";
        }
    }

    private void lstResult_Leave(object sender, EventArgs e)
    {
        tslStatus.Text = "Ready.";
    }
}
