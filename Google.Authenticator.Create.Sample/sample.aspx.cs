using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Google.Authenticator.Create.Sample
{
    public partial class sample : System.Web.UI.Page
    {
        private static string AccountSecretKey { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            //建立一把用戶的私鑰
            if (string.IsNullOrEmpty(AccountSecretKey)) {

                AccountSecretKey = Guid.NewGuid().ToString("N").Substring(0, 10);
            }
            ltlAccountSecretKey.Text = AccountSecretKey;


            //產生QR Code.
            var tfa = new TwoFactorAuthenticator();
            var setupInfo = tfa.GenerateSetupCode("DONMA BLOG", "sample@donma.com", AccountSecretKey, 300, 300);
            //用內建的API 產生
            ltlQRCode.Text = "<img src='" + setupInfo.QrCodeSetupImageUrl + "' />";
            
            ltlQRCodeContent.Text = "otpauth://totp/"+"sample@donma.com"+"?secret="+ setupInfo.ManualEntryKey+ "&issuer="+ "DONMA BLOG";

            //ltlQRCode.Text = "<img src='https://chart.googleapis.com/chart?cht=qr&chl=" + Server.UrlEncode(ltlQRCodeContent.Text) + "&chs=300x300&chld=L|0' />";
        }

        protected void btnValid_Click(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            //第一個參數是你當初產生QRcode 所產生的Secret code 
            //第二個參數是用戶輸入的純數字Code
            var result = tfa.ValidateTwoFactorPIN(AccountSecretKey, txtUserType.Text);
            ltlResult.Text = result ? "SUCCESS!!" : "FAIL!!";
        }
    }
}