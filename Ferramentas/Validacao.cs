using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class Validacao
    {     
        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;            
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
            cnpj = cnpj.Trim();
            if (cnpj == "00000000000000" || cnpj == "11111111111111" || cnpj == "22222222222222" || cnpj == "33333333333333" || cnpj == "44444444444444"
             || cnpj == "55555555555555" || cnpj == "66666666666666" || cnpj == "77777777777777" || cnpj == "88888888888888" || cnpj == "99999999999999")         
                return false;
            
            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();        
            return cnpj.EndsWith(digito);
        }
        public static bool IsCpf(string cpf)
        {          
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",","");

            if (cpf == "00000000000" || cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" || cpf == "44444444444" ||
                cpf == "55555555555" || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999")
                return false;

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;            
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito +=  resto.ToString();
            return cpf.EndsWith(digito);         
        }


        public static bool IsEmail(string email)
        {
            //string stregex = "^[a-zA-Z0-9_\\.\\-]+@((\\[[a-zA-Z0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?$";
            //Regex re = new Regex(stregex);
            //if (!re.IsMatch(email))
            //{
            //    return false;
            //}

            if (!email.StartsWith("@") && email.Contains("@"))
            {
                if (!email.EndsWith("@.com") && email.EndsWith(".com") || !email.EndsWith("@.br") && email.EndsWith(".br") || !email.EndsWith("@.net") && email.EndsWith(".net") 
                    || !email.EndsWith("@.org") && email.EndsWith(".org") || !email.EndsWith("@.co") && email.EndsWith(".co") || !email.EndsWith("@.co.uk") && email.EndsWith(".co.uk") 
                    || !email.EndsWith("@.info") && email.EndsWith(".info") || !email.EndsWith("@.biz") && email.EndsWith(".biz") || !email.EndsWith("@.eu") && email.EndsWith(".eu") 
                    || !email.EndsWith("@.pt") && email.EndsWith(".pt") || !email.EndsWith("@.es") && email.EndsWith(".es"))                  
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsCep(string cep)
        {
            //string stregex = "[0-9]{5}-[0-9]{3}";
            //return System.Text.RegularExpressions.Regex.IsMatch(cep, stregex);
            cep = cep.Trim();
            cep = cep.Replace("-", "");
            if (cep.Length == 8)
            {
                return true;
            }
            return false;
        }

        public static bool IsCel(string cel)
        {
            cel = cel.Trim();
            cel = cel.Replace("(", "").Replace(")","").Replace("-", "");

            if (cel.Length == 11)
            {
                return true;
            }
            return false;
        }

        public static bool IsFone(string fone)
        {
            fone = fone.Trim();
            fone = fone.Replace("(", "").Replace(")", "").Replace("-", "");           

            if (fone.Length == 10)
            {
                return true;
            }
            return false;
        }  
    }
}
