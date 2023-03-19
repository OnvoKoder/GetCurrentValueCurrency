using Currency.Class.Enums;

namespace Currency.Class.Utility
{
    internal class Switcher
    {
        public CodeValute GetCodeValute(int index)
        {
            CodeValute code;
            switch (index)
            {
                case (int)CodeValute.AUD:
                    code = CodeValute.AUD; break;
                case (int)CodeValute.AZN:
                    code = CodeValute.AZN; break;
                case (int)CodeValute.GBP:
                    code = CodeValute.GBP; break;
                case (int)CodeValute.AMD:
                    code = CodeValute.AMD; break;
                case (int)CodeValute.BYN:
                    code = CodeValute.BYN; break;
                case (int)CodeValute.BGN:
                    code = CodeValute.BGN; break;
                case (int)CodeValute.BRL:
                    code = CodeValute.BRL; break;
                case (int)CodeValute.HUF:
                    code = CodeValute.HUF; break;
                case (int)CodeValute.VND:
                    code = CodeValute.VND; break;
                case (int)CodeValute.HKD:
                    code = CodeValute.HKD; break;
                case (int)CodeValute.GEL:
                    code = CodeValute.GEL; break;
                case (int)CodeValute.DKK:
                    code = CodeValute.DKK; break;
                case (int)CodeValute.AED:
                    code = CodeValute.AED; break;
                case (int)CodeValute.USD:
                    code = CodeValute.USD; break;
                case (int)CodeValute.EUR:
                    code = CodeValute.EUR; break;
                case (int)CodeValute.EGP:
                    code = CodeValute.EGP; break;
                case (int)CodeValute.INR:
                    code = CodeValute.INR; break;
                case (int)CodeValute.IDR:
                    code = CodeValute.IDR; break;
                case (int)CodeValute.KZT:
                    code = CodeValute.KZT; break;
                case (int)CodeValute.CAD:
                    code = CodeValute.CAD; break;
                case (int)CodeValute.QAR:
                    code = CodeValute.QAR; break;
                case (int)CodeValute.KGS:
                    code = CodeValute.KGS; break;
                case (int)CodeValute.CNY:
                    code = CodeValute.CNY; break;
                case (int)CodeValute.MDL:
                    code = CodeValute.MDL; break;
                case (int)CodeValute.NZD:
                    code = CodeValute.NZD; break;
                case (int)CodeValute.NOK:
                    code = CodeValute.NOK; break;
                case (int)CodeValute.PLN:
                    code = CodeValute.PLN; break;
                case (int)CodeValute.RON:
                    code = CodeValute.RON; break;
                case (int)CodeValute.XDR:
                    code = CodeValute.XDR; break;
                case (int)CodeValute.SGD:
                    code = CodeValute.SGD; break;
                case (int)CodeValute.TJS:
                    code = CodeValute.TJS; break;
                case (int)CodeValute.THB:
                    code = CodeValute.THB; break;
                case (int)CodeValute.TRY:
                    code = CodeValute.TRY; break;
                case (int)CodeValute.TMT:
                    code = CodeValute.TMT; break;
                case (int)CodeValute.UZS:
                    code = CodeValute.UZS; break;
                case (int)CodeValute.UAH:
                    code = CodeValute.UAH; break;
                case (int)CodeValute.CZK:
                    code = CodeValute.CZK; break;
                case (int)CodeValute.SEK:
                    code = CodeValute.SEK; break;
                case (int)CodeValute.CHF:
                    code = CodeValute.CHF; break;
                case (int)CodeValute.RSD:
                    code = CodeValute.RSD; break;
                case (int)CodeValute.ZAR:
                    code = CodeValute.ZAR; break;
                case (int)CodeValute.KRW:
                    code = CodeValute.KRW; break;
                case (int)CodeValute.JPY:
                    code = CodeValute.JPY; break;
                default:
                    code = CodeValute.ALL; break;
            }
            return code;
        }
    }
}
