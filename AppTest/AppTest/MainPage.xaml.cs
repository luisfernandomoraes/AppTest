using Acr.UserDialogs;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;
using Rg.Plugins.Popup.Services;

namespace AppTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnScanner(object sender, EventArgs evt)
        {
            string scannerResult;
            var scanner = new ZXing.Mobile.MobileBarcodeScanner();
            scanner.AutoFocus();
            scanner.TopText = "Aproxime o QRCode";

            var resultQrCode = await scanner.Scan();
            if (resultQrCode != null)
            {
                scannerResult = resultQrCode.Text;
                await DisplayAlert("APP", "QR Lido: " + scannerResult, "Ok");
            }
        }

        public async void OnPopup(object sender, EventArgs evt)
        {
            var page = new MyPopupPage();

            //await Navigation.PushPopupAsync(page);
            await PopupNavigation.PushAsync(page);

        }
    }
}
