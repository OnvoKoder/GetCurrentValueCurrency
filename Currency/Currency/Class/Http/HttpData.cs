using Currency.Class.Enums;
using Currency.Class.Patterns;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Currency.Class.Http
{
    class HttpData
    {
        private static ExchangeData currency = new ExchangeData();
        private List<string> data = new List<string>();
        static HttpData() => currency = GetCurrency();
        public List<string> GetNameCurrencyInCmb()
        {
            data.Clear();
            data.Add("Все");
            data.Add(currency.Valute.AUD.Name);
            data.Add(currency.Valute.AZN.Name);
            data.Add(currency.Valute.GBP.Name);
            data.Add(currency.Valute.AMD.Name);
            data.Add(currency.Valute.BYN.Name);
            data.Add(currency.Valute.BGN.Name);
            data.Add(currency.Valute.BRL.Name);
            data.Add(currency.Valute.HUF.Name);
            data.Add(currency.Valute.VND.Name);
            data.Add(currency.Valute.HKD.Name);
            data.Add(currency.Valute.GEL.Name);
            data.Add(currency.Valute.DKK.Name);
            data.Add(currency.Valute.AED.Name);
            data.Add(currency.Valute.USD.Name);
            data.Add(currency.Valute.EUR.Name);
            data.Add(currency.Valute.EGP.Name);
            data.Add(currency.Valute.INR.Name);
            data.Add(currency.Valute.IDR.Name);
            data.Add(currency.Valute.KZT.Name);
            data.Add(currency.Valute.CAD.Name);
            data.Add(currency.Valute.QAR.Name);
            data.Add(currency.Valute.KGS.Name);
            data.Add(currency.Valute.CNY.Name);
            data.Add(currency.Valute.MDL.Name);
            data.Add(currency.Valute.NZD.Name);
            data.Add(currency.Valute.NOK.Name);
            data.Add(currency.Valute.PLN.Name);
            data.Add(currency.Valute.RON.Name);
            data.Add(currency.Valute.XDR.Name);
            data.Add(currency.Valute.SGD.Name);
            data.Add(currency.Valute.TJS.Name);
            data.Add(currency.Valute.THB.Name);
            data.Add(currency.Valute.TRY.Name);
            data.Add(currency.Valute.TMT.Name);
            data.Add(currency.Valute.UZS.Name);
            data.Add(currency.Valute.UAH.Name);
            data.Add(currency.Valute.CZK.Name);
            data.Add(currency.Valute.SEK.Name);
            data.Add(currency.Valute.CHF.Name);
            data.Add(currency.Valute.RSD.Name);
            data.Add(currency.Valute.ZAR.Name);
            data.Add(currency.Valute.KRW.Name);
            data.Add(currency.Valute.JPY.Name);
            return data;
        }
        public List<string> GetCodeCurrencyInCmb()
        {
            data.Clear();
            data.Add("Все");
            data.Add(currency.Valute.AUD.CharCode);
            data.Add(currency.Valute.AZN.CharCode);
            data.Add(currency.Valute.GBP.CharCode);
            data.Add(currency.Valute.AMD.CharCode);
            data.Add(currency.Valute.BYN.CharCode);
            data.Add(currency.Valute.BGN.CharCode);
            data.Add(currency.Valute.BRL.CharCode);
            data.Add(currency.Valute.HUF.CharCode);
            data.Add(currency.Valute.VND.CharCode);
            data.Add(currency.Valute.HKD.CharCode);
            data.Add(currency.Valute.GEL.CharCode);
            data.Add(currency.Valute.DKK.CharCode);
            data.Add(currency.Valute.AED.CharCode);
            data.Add(currency.Valute.USD.CharCode);
            data.Add(currency.Valute.EUR.CharCode);
            data.Add(currency.Valute.EGP.CharCode);
            data.Add(currency.Valute.INR.CharCode);
            data.Add(currency.Valute.IDR.CharCode);
            data.Add(currency.Valute.KZT.CharCode);
            data.Add(currency.Valute.CAD.CharCode);
            data.Add(currency.Valute.QAR.CharCode);
            data.Add(currency.Valute.KGS.CharCode);
            data.Add(currency.Valute.CNY.CharCode);
            data.Add(currency.Valute.MDL.CharCode);
            data.Add(currency.Valute.NZD.CharCode);
            data.Add(currency.Valute.NOK.CharCode);
            data.Add(currency.Valute.PLN.CharCode);
            data.Add(currency.Valute.RON.CharCode);
            data.Add(currency.Valute.XDR.CharCode);
            data.Add(currency.Valute.SGD.CharCode);
            data.Add(currency.Valute.TJS.CharCode);
            data.Add(currency.Valute.THB.CharCode);
            data.Add(currency.Valute.TRY.CharCode);
            data.Add(currency.Valute.TMT.CharCode);
            data.Add(currency.Valute.UZS.CharCode);
            data.Add(currency.Valute.UAH.CharCode);
            data.Add(currency.Valute.CZK.CharCode);
            data.Add(currency.Valute.SEK.CharCode);
            data.Add(currency.Valute.CHF.CharCode);
            data.Add(currency.Valute.RSD.CharCode);
            data.Add(currency.Valute.ZAR.CharCode);
            data.Add(currency.Valute.KRW.CharCode);
            data.Add(currency.Valute.JPY.CharCode);
            return data;
        }
        public List<string> GetCurrentCurrency(CodeValute valute)
        {
            List<string> result = new List<string>();
            switch (valute)
            {
                case CodeValute.ALL:
                    result.Add(MakeResult(currency.Valute.AUD));
                    result.Add(MakeResult(currency.Valute.AZN));
                    result.Add(MakeResult(currency.Valute.GBP));
                    result.Add(MakeResult(currency.Valute.AMD));
                    result.Add(MakeResult(currency.Valute.BYN));
                    result.Add(MakeResult(currency.Valute.BGN));
                    result.Add(MakeResult(currency.Valute.BRL));
                    result.Add(MakeResult(currency.Valute.HUF));
                    result.Add(MakeResult(currency.Valute.VND));
                    result.Add(MakeResult(currency.Valute.HKD));
                    result.Add(MakeResult(currency.Valute.GEL));
                    result.Add(MakeResult(currency.Valute.DKK));
                    result.Add(MakeResult(currency.Valute.AED));
                    result.Add(MakeResult(currency.Valute.USD));
                    result.Add(MakeResult(currency.Valute.EUR));
                    result.Add(MakeResult(currency.Valute.EGP));
                    result.Add(MakeResult(currency.Valute.INR));
                    result.Add(MakeResult(currency.Valute.IDR));
                    result.Add(MakeResult(currency.Valute.KZT));
                    result.Add(MakeResult(currency.Valute.CAD));
                    result.Add(MakeResult(currency.Valute.QAR));
                    result.Add(MakeResult(currency.Valute.KGS));
                    result.Add(MakeResult(currency.Valute.CNY));
                    result.Add(MakeResult(currency.Valute.MDL));
                    result.Add(MakeResult(currency.Valute.NZD));
                    result.Add(MakeResult(currency.Valute.NOK));
                    result.Add(MakeResult(currency.Valute.PLN));
                    result.Add(MakeResult(currency.Valute.RON));
                    result.Add(MakeResult(currency.Valute.XDR));
                    result.Add(MakeResult(currency.Valute.SGD));
                    result.Add(MakeResult(currency.Valute.TJS));
                    result.Add(MakeResult(currency.Valute.THB));
                    result.Add(MakeResult(currency.Valute.TRY));
                    result.Add(MakeResult(currency.Valute.TMT));
                    result.Add(MakeResult(currency.Valute.UZS));
                    result.Add(MakeResult(currency.Valute.UAH));
                    result.Add(MakeResult(currency.Valute.CZK));
                    result.Add(MakeResult(currency.Valute.SEK));
                    result.Add(MakeResult(currency.Valute.CHF));
                    result.Add(MakeResult(currency.Valute.RSD));
                    result.Add(MakeResult(currency.Valute.ZAR));
                    result.Add(MakeResult(currency.Valute.KRW));
                    result.Add(MakeResult(currency.Valute.JPY)); break; 
                case CodeValute.AUD:
                    result.Add(MakeResult(currency.Valute.AUD)); break;
                case CodeValute.AZN:
                    result.Add(MakeResult(currency.Valute.AZN)); break;
                case CodeValute.GBP:
                    result.Add(MakeResult(currency.Valute.GBP)); break;
                case CodeValute.AMD:
                    result.Add(MakeResult(currency.Valute.AMD)); break;
                case CodeValute.BYN:
                    result.Add(MakeResult(currency.Valute.BYN)); break;
                case CodeValute.BGN:
                    result.Add(MakeResult(currency.Valute.BGN)); break;
                case CodeValute.BRL:
                    result.Add(MakeResult(currency.Valute.BRL)); break;
                case CodeValute.HUF:
                    result.Add(MakeResult(currency.Valute.HUF)); break;
                case CodeValute.VND:
                    result.Add(MakeResult(currency.Valute.VND)); break;
                case CodeValute.HKD:
                    result.Add(MakeResult(currency.Valute.HKD)); break;
                case CodeValute.GEL:
                    result.Add(MakeResult(currency.Valute.GEL)); break;
                case CodeValute.DKK:
                    result.Add(MakeResult(currency.Valute.DKK)); break;
                case CodeValute.AED:
                    result.Add(MakeResult(currency.Valute.AED)); break;
                case CodeValute.USD:
                    result.Add(MakeResult(currency.Valute.USD)); break;
                case CodeValute.EUR:
                    result.Add(MakeResult(currency.Valute.EUR)); break;
                case CodeValute.EGP:
                    result.Add(MakeResult(currency.Valute.EGP)); break;
                case CodeValute.INR:
                    result.Add(MakeResult(currency.Valute.INR)); break;
                case CodeValute.IDR:
                    result.Add(MakeResult(currency.Valute.IDR)); break;
                case CodeValute.KZT:
                    result.Add(MakeResult(currency.Valute.KZT)); break;
                case CodeValute.CAD:
                    result.Add(MakeResult(currency.Valute.CAD)); break;
                case CodeValute.QAR:
                    result.Add(MakeResult(currency.Valute.QAR)); break;
                case CodeValute.KGS:
                    result.Add(MakeResult(currency.Valute.KGS)); break;
                case CodeValute.CNY:
                    result.Add(MakeResult(currency.Valute.CNY)); break;
                case CodeValute.MDL:
                    result.Add(MakeResult(currency.Valute.MDL)); break;
                case CodeValute.NZD:
                    result.Add(MakeResult(currency.Valute.NZD)); break;
                case CodeValute.NOK:
                    result.Add(MakeResult(currency.Valute.NOK)); break;
                case CodeValute.PLN:
                    result.Add(MakeResult(currency.Valute.PLN)); break;
                case CodeValute.RON:
                    result.Add(MakeResult(currency.Valute.RON)); break;
                case CodeValute.XDR:
                    result.Add(MakeResult(currency.Valute.XDR)); break;
                case CodeValute.SGD:
                    result.Add(MakeResult(currency.Valute.SGD)); break;
                case CodeValute.TJS:
                    result.Add(MakeResult(currency.Valute.TJS)); break;
                case CodeValute.THB:
                    result.Add(MakeResult(currency.Valute.THB)); break;
                case CodeValute.TRY:
                    result.Add(MakeResult(currency.Valute.TRY)); break;
                case CodeValute.TMT:
                    result.Add(MakeResult(currency.Valute.TMT)); break;
                case CodeValute.UZS:
                    result.Add(MakeResult(currency.Valute.UZS)); break;
                case CodeValute.UAH:
                    result.Add(MakeResult(currency.Valute.UAH)); break;
                case CodeValute.CZK:
                    result.Add(MakeResult(currency.Valute.CZK)); break;
                case CodeValute.SEK:
                    result.Add(MakeResult(currency.Valute.SEK)); break;
                case CodeValute.CHF:
                    result.Add(MakeResult(currency.Valute.CHF)); break;
                case CodeValute.RSD:
                    result.Add(MakeResult(currency.Valute.RSD)); break;
                case CodeValute.ZAR:
                    result.Add(MakeResult(currency.Valute.ZAR)); break;
                case CodeValute.KRW:
                    result.Add(MakeResult(currency.Valute.KRW)); break;
                case CodeValute.JPY:
                    result.Add(MakeResult(currency.Valute.JPY)); break;
            }
            return result;
        }
        private string MakeResult(CurrentCurrency current)
        {
            string result = "";
            result = $"Время: {currency.TimeStamp}{Environment.NewLine}Название валюты: {current.Name}{Environment.NewLine}Код валюты: {current.CharCode}{Environment.NewLine}Цена: {current.Value}{Environment.NewLine}Номинал: {current.Nominal}";
            return result;
        }
        private static ExchangeData GetCurrency()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.cbr-xml-daily.ru/daily_json.js");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string result;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                result = reader.ReadToEnd();
            ExchangeData exchanges = JsonConvert.DeserializeObject<ExchangeData>(result);
            return exchanges;
        }
    }
}
