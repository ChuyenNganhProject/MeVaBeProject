using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using RestSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.IO;

namespace MeVaBeProject
{
    public partial class frmQRCodeThanhToan : Form
    {
        private decimal tongTien;
        public frmQRCodeThanhToan(decimal tongTien)
        {
            InitializeComponent();
            this.tongTien = tongTien;
            this.Load += FrmQRCodeThanhToan_Load;
            this.btnDong.Click += BtnDong_Click;
            this.btnXacNhan.Click += BtnXacNhan_Click;
            this.btnTaoMaQR.Click += BtnTaoMaQR_Click;
        }

        private void BtnTaoMaQR_Click(object sender, EventArgs e)
        {
            //  "accountNo": 113366668888,
            //  "accountName": "QUY VAC XIN PHONG CHONG COVID",
            //  "acqId": 970415,
            //  "amount": 79000,
            //  "addInfo": "Ung Ho Quy Vac Xin",
            //  "format": "text",
            //  "template": "compact"
            var apiRequest = new APIRequest();
            apiRequest.acqId = Convert.ToInt32(cboNganHang.SelectedValue.ToString());
            apiRequest.accountNo = long.Parse(txtSoTaiKhoan.Text);
            apiRequest.accountName = txtTenTaiKhoan.Text;
            apiRequest.amount = (int)this.tongTien;
            apiRequest.format = "text";
            apiRequest.template = cboTemplate.Text;

            var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            // dùng restsharp cho request api
            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            var content = response.Content;
            var dataResult = JsonConvert.DeserializeObject<APIRespone>(content);

            var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
            pbQRCode.Image = image;
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmQRCodeThanhToan_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRowJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRowJson);

                cboNganHang.DataSource = listBankData.data;
                cboNganHang.DisplayMember = "custom_name";
                cboNganHang.ValueMember = "bin";
                cboTemplate.SelectedIndex = 0;
                cboNganHang.SelectedValue = "970416";
                txtSoTien.Text = tongTien.ToString("N0").Replace(",", ".");
            }
        }
    }
}
