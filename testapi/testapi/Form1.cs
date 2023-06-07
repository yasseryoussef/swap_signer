using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace testapi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static HttpClient _httpclient = new HttpClient();
        string txt = @"{
  ""issuer"": {
    ""address"": {
      ""branchID"": ""0"",
      ""country"": ""EG"",
      ""governate"": ""CAIRO"",
      ""regionCity"": ""CAIRO"",
      ""street"": "" ع 4 م عباد الرحمن خلف نادي الصيد المقطم القاهره"",
      ""buildingNumber"": ""123"",
      ""postalCode"": ""12345"",
      ""floor"": ""1"",
      ""room"": ""1"",
      ""landmark"": ""1"",
      ""additionalInformation"": ""1""
    },
    ""type"": ""B"",
    ""id"": ""616063652"",
    ""name"": ""سواب سوليوشنز للتطبيقات الذكيه""
  },
  ""receiver"": {
    ""address"": {
      ""country"": ""EG"",
      ""governate"": ""CAIRO"",
      ""regionCity"": ""CAIRO"",
      ""street"": ""1"",
      ""buildingNumber"": ""123"",
      ""postalCode"": ""12345"",
      ""floor"": ""1"",
      ""room"": ""1"",
      ""landmark"": ""1"",
      ""additionalInformation"": ""1""
    },
    ""type"": ""P"",
    ""id"": ""29204211800414"",
    ""name"": ""على جمال عبده ابراهيم""
  },
  ""documentType"": ""I"",
  ""documentTypeVersion"": ""1.0"",
  ""dateTimeIssued"": ""2023-06-07T00:00:00Z"",
  ""taxpayerActivityCode"": ""6920"",
  ""internalID"": ""i-8536/20121418/2/2023/6/6"",
  ""invoiceLines"": [
    {
      ""description"": ""Venous Doppler for one L L"",
      ""itemType"": ""GS1"",
      ""itemCode"": ""10007601"",
      ""unitType"": ""EA"",
      ""quantity"": 1,
      ""internalCode"": ""2602"",
      ""salesTotal"": 128,
      ""total"": 128,
      ""valueDifference"": 0,
      ""totalTaxableFees"": 0,
      ""netTotal"": 128,
      ""itemsDiscount"": 0,
      ""unitValue"": {
        ""currencySold"": ""EGP"",
        ""amountEGP"": 128
      },
      ""discount"": {
        ""rate"": 0,
        ""amount"": 0
      },
      ""taxableItems"": [
        {
          ""taxType"": ""T1"",
          ""amount"": 0,
          ""subType"": ""V009"",
          ""rate"": 0
        }
      ]
    }
  ],
  ""totalDiscountAmount"": 0,
  ""totalSalesAmount"": 128,
  ""netAmount"": 128,
  ""taxTotals"": [
    {
      ""taxType"": ""T1"",
      ""amount"": 0
    }
  ],
  ""totalAmount"": 128,
  ""extraDiscountAmount"": 0,
  ""totalItemsDiscountAmount"": 0

}
 ";
        string recipt = @"{
  ""header"": {
    ""dateTimeIssued"": ""2023-06-06T21:00:00Z"",
    ""receiptNumber"": ""addv recipt no"",
    ""uuid"": """",
    ""previousUUID"": ""417ac8138a1a0dc5d982b5b4e97f45f1143120fe6e2bbba4d554f8cf15205db0"",
    ""referenceOldUUID"": """",
    ""currency"": ""EGP"",
    ""sOrderNameCode"": """",
    ""orderdeliveryMode"": """",
    ""grossWeight"": 0,
    ""exchangeRate"": 0,
    ""netWeight"": 0
  },
  ""documentType"": {
    ""receiptType"": ""s"",
    ""typeVersion"": ""1.2""
  },
  ""seller"": {
    ""rin"": ""fill your rin"",
    ""companyTradeName"": ""سواب سوليوشنز للتطبيقات الذكيه"",
    ""branchCode"": ""0"",
    ""branchAddress"": {
      ""country"": ""EG"",
      ""governate"": ""cairo"",
      ""regionCity"": ""cairo"",
      ""street"": ""11"",
      ""buildingNumber"": ""1"",
      ""postalCode"": ""1"",
      ""floor"": ""1"",
      ""room"": ""1"",
      ""landmark"": """",
      ""additionalInformation"": """"
    },
    ""deviceSerialNumber"": ""your pos serial"",
    ""syndicateLicenseNumber"": """",
    ""activityCode"": ""your activity code""
  },
  ""buyer"": {
    ""type"": ""P"",
    ""id"": """",
    ""name"": ""يسب"",
    ""mobileNumber"": """",
    ""paymentNumber"": """"
  },
  ""itemData"": [
    {
      ""description"": ""خامة 1"",
      ""itemType"": ""GS1"",
      ""itemCode"": ""4895224123774"",
      ""unitType"": ""EA"",
      ""quantity"": 2.00000,
      ""unitPrice"": 114.0000,
      ""internalCode"": ""000001004"",
      ""totalSale"": 228.0000,
      ""total"": 259.9200,
      ""valueDifference"": 0,
      ""netSale"": 228.0000,
      ""commercialDiscountData"": [
        {
          ""amount"": 0.0000,
          ""description"": ""مزاج امي كده""
        }
      ],
      ""itemDiscountData"": [],
      ""taxableItems"": [
        {
          ""taxType"": ""T1"",
          ""amount"": 31.9200,
          ""subType"": ""V009"",
          ""rate"": 14.00
        }
      ]
    }
  ],
  ""totalCommercialDiscount"": 0.0000,
  ""totalSales"": 228.0000,
  ""netAmount"": 228.0000,
  ""feesAmount"": 0,
  ""extraReceiptDiscountData"": [],
  ""taxTotals"": [
    {
      ""taxType"": ""T1"",
      ""amount"": 31.9200
    }
  ],
  ""totalAmount"": 259.9200,
  ""paymentMethod"": ""C""
}";

        string txt2 = @"{
  ""issuer"": {
    ""address"": {
      ""branchID"": ""0"",
      ""country"": ""EG"",
      ""governate"": ""Cairo"",
      ""regionCity"": ""Golf"",
      ""street"": "" ع 4 م عباد الرحمن خلف نادي الصيد المقطم القاهره"",
      ""buildingNumber"": ""2025"",
      ""postalCode"": ""12345"",
      ""floor"": ""1"",
      ""room"": ""1111"",
      ""landmark"": ""5"",
      ""additionalInformation"": """"
    },
    ""type"": ""B"",
    ""id"": ""616063652"",
    ""name"": ""سواب سوليوشنز للتطبيقات الذكيه""
  },
  ""receiver"": {
    ""address"": {
      ""branchID"": ""0"",
      ""country"": ""EG"",
      ""governate"": ""cairo"",
      ""regionCity"": ""القاهرة"",
      ""street"": ""5"",
      ""buildingNumber"": ""5"",
      ""postalCode"": """",
      ""floor"": ""5"",
      ""room"": ""5"",
      ""landmark"": """",
      ""additionalInformation"": """"
    },
    ""type"": ""P"",
    ""id"": """",
    ""name"": ""يسب""
  },
  ""documentType"": ""I"",
  ""documentTypeVersion"": ""1.0"",
  ""dateTimeIssued"": ""2023-06-07T00:00:00Z"",
  ""taxpayerActivityCode"": ""6920"",
  ""internalID"": ""sn-24*3836_envent"",
  ""purchaseOrderReference"": """",
  ""purchaseOrderDescription"": """",
  ""salesOrderReference"": """",
  ""salesOrderDescription"": """",
  ""proformaInvoiceNumber"": """",
  ""payment"": {
    ""bankName"": ""QNB"",
    ""bankAddress"": ""test address"",
    ""bankAccountNo"": ""10025573260-38"",
    ""bankAccountIBAN"": ""EG500037014608181002557326038"",
    ""swiftCode"": ""QNBAEGCXXXX"",
    ""terms"": """"
  },
  ""delivery"": {
    ""approach"": """",
    ""packaging"": """",
    ""dateValidity"": """"
  },
  ""invoiceLines"": [
    {
      ""description"": ""خامة 1"",
      ""itemType"": ""GS1"",
      ""itemCode"": ""4895224123774"",
      ""unitType"": ""EA"",
      ""quantity"": 2.00000,
      ""internalCode"": ""000001004"",
      ""salesTotal"": 228.0000,
      ""total"": 259.9200,
      ""valueDifference"": 0.0000,
      ""totalTaxableFees"": 0.0000,
      ""netTotal"": 228.0000,
      ""itemsDiscount"": 0.0,
      ""unitValue"": {
        ""currencySold"": ""EGP"",
        ""amountEGP"": 114.0000,
        ""amountSold"": 0.0,
        ""currencyExchangeRate"": 0
      },
      ""discount"": {
        ""rate"": 0.0000,
        ""amount"": 0.0000
      },
      ""taxableItems"": [
        {
          ""taxType"": ""T1"",
          ""amount"": 31.9200,
          ""subType"": ""V009"",
          ""rate"": 14.0
        }
      ]
    }
  ],
  ""totalDiscountAmount"": 0.0000,
  ""totalSalesAmount"": 228.0000,
  ""netAmount"": 228.0000,
  ""taxTotals"": [
    {
      ""taxType"": ""T1"",
      ""amount"": 31.9200
    }
  ],
  ""totalAmount"": 259.9200,
  ""extraDiscountAmount"": 0,
  ""totalItemsDiscountAmount"": 0
}";
         string BaseUrl = "https://api.preprod.invoicing.eta.gov.eg";
           string   tokenurl = "https://id.preprod.eta.gov.eg/connect/token";
        public  string GetBearerToken()
        {
            String token = "";

            _httpclient.DefaultRequestHeaders.Clear();

            using (var request = new HttpRequestMessage(HttpMethod.Post, tokenurl))
            {

                //  cli.DefaultRequestHeaders.Add("Accept", "application/json");

                request.Headers.TryAddWithoutValidation("cache-control", "no-cache");
                request.Headers.TryAddWithoutValidation("content-type", "application/x-www-form-urlencoded");
                request.Headers.TryAddWithoutValidation("User-Agent", "swap_erp");





                Dictionary<string, string> para = new Dictionary<string, string>();
                para.Add("client_id", "client id");
                para.Add("client_secret", "client secrit");
                para.Add("grant_type", "client_credentials");


                request.Content = new FormUrlEncodedContent(para);

                HttpResponseMessage response = _httpclient.SendAsync(request).Result;

                string apiResponse = response.Content.ReadAsStringAsync().Result;
                token = JObject.Parse(apiResponse)["access_token"].ToString();
                string jj = token;
                return token;

            }





            return "";
        }
      

        async Task<string> sigen_recipt()
        {
            string uri = $@"http://localhost:5111/api/SigenRecipt";







            _httpclient.DefaultRequestHeaders.Clear();
            _httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            _httpclient.DefaultRequestHeaders.TryAddWithoutValidation("cache-control", "no-cache");

            //  request.AddHeader("Cookie", "75fd0698a2e84d6b8a3cb94ae54530f3=054e7d0fb7353830e763d83ee8bd30d6");
            _httpclient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var cont = new StringContent(recipt, Encoding.UTF8, "application/json");
            var res = await _httpclient.PostAsync(uri, cont);

            string apiResponse = await res.Content.ReadAsStringAsync();



            string json = JsonConvert.DeserializeObject(apiResponse).ToString();
            MessageBox.Show(json);
            return json;
        }


        async Task<string> sigen()
        {
            string na = "certficat name or serial";
            string pin = "token pin password";


            // if using certficate by serial number then use_serial =1 if you r using certficate by name then user serial must be = 0 
            int use_serial = 1;

            string uri = $@"http://localhost:5111/api/signdoc?UseSerial={use_serial}&&TokenName={na}&&TokenPin={pin}";




            // using httpclient for consuming api requset


            _httpclient.DefaultRequestHeaders.Clear();
            _httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            _httpclient.DefaultRequestHeaders.TryAddWithoutValidation("cache-control", "no-cache");
            _httpclient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var cont = new StringContent(txt, Encoding.UTF8, "application/json");
            var res = await _httpclient.PostAsync(uri, cont);

            string apiResponse = await res.Content.ReadAsStringAsync();

            // deserialize respone to be in json formate for sending to Eta
            string json = JsonConvert.DeserializeObject(apiResponse).ToString();

            return json;
        }
        private async void button1_Click(object sender, EventArgs e)
        {

            await sendinvoice();

        }
        private async Task sendinvoice()
        {
            /* async task for sending invoice using restsharp */

            
               string  tok = GetBearerToken();

            string data = await sigen();

            var client = new RestClient(BaseUrl + "/api/v1.0/documentsubmissions");

            var request = new RestRequest(Method.POST);
            request.AddHeader("authorization", @"Bearer " + tok);
            request.AddHeader("cache-control", "no-cache");

            //  request.AddHeader("Cookie", "75fd0698a2e84d6b8a3cb94ae54530f3=054e7d0fb7353830e763d83ee8bd30d6");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("User-Agent", "swap-erp");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Connection", "keep-alive");
          

            
            string d = "";
          
            IRestResponse result = client.Execute(request.AddJsonBody(data));
            if (result.Content != "")
            {
                JObject o = JObject.Parse(result.Content);
            }

        }

        private async  void button2_Click(object sender, EventArgs e)
        {
            await sigen_recipt();
        }
    }
}
