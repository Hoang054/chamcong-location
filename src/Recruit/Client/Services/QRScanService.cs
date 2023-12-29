using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using QRCoder;
using Recruit.Server.Models;
using Recruit.Shared.ViewModels;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Http;
using System.Net.Http.Json;

namespace Recruit.Client.Services
{
    public class QRScanService : IQRScanService
    {
        private readonly NavigationManager _navigationManager;
        private readonly HttpClient httpClient;

        public QRScanService(NavigationManager navigationManager, HttpClient httpClient)
        {
            _navigationManager = navigationManager;
            this.httpClient = httpClient;
        }

        public async Task<int> changeStatus(double PsnPrkID, int TrangThai)
        {
            var url = _navigationManager.Uri;
            var urlRequest = $"/NgayCong/UpdateScan/{PsnPrkID}/{TrangThai}";
            return await httpClient.GetFromJsonAsync<int>(urlRequest);
        }

        public async Task<string> createQRCode()
        {
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    var url = _navigationManager.Uri;
                    var data = url.ToLower().Replace("/qrscan", "/SelectStatus");

                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                    //QRCode qrCode = new QRCode(qrCodeData);
                    BitmapByteQRCode qrCodeImage = new BitmapByteQRCode(qrCodeData);
                    //Bitmap qrCodeImage = qrCode.GetGraphic(20); // Adjust the size of the QR code by changing the parameter
                    byte[] qrCodeBytes = qrCodeImage.GetGraphic(10);
                    // Save the QR code as an image file

                    //return "data:image/png;base64," + Convert.ToBase64String(qrCodeBytes.ToArray());
                    return "data:image/png;base64," + Convert.ToBase64String(qrCodeBytes.ToArray());
                    
                }

            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
