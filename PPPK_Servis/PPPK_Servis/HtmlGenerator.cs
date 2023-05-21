using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPK_Servis
{
    public static class HtmlGenerator
    {

        public static void HtmlGeneratorr(Vozilo vozilo)
        {
            string htmlString = "";

            StringBuilder htmlBuilder = new StringBuilder();

            htmlBuilder.Append("<html>");
            htmlBuilder.Append("<head>");
            htmlBuilder.Append("<title>");
            htmlBuilder.Append("</title>");
            htmlBuilder.Append("</head>");
            htmlBuilder.Append("<body>");
            htmlBuilder.Append("Vehicle:");
            htmlBuilder.Append("</br>");
            htmlBuilder.Append($"{vozilo.IDVozilo}");
            htmlBuilder.Append("</br>");
            htmlBuilder.Append($"{vozilo.MarkaVozila}");
            htmlBuilder.Append("</br>");
            htmlBuilder.Append($"{vozilo.TipVozila}");
            htmlBuilder.Append("</br>");
            htmlBuilder.Append($"{vozilo.InicijalnoStanjeKilometara}");
            htmlBuilder.Append("</br>");
            htmlBuilder.Append("Item: ");
            htmlBuilder.Append("</br>");
            foreach (var servis in vozilo.Servis)
            {
                htmlBuilder.Append($"{servis.Item.ItemName}");
                htmlBuilder.Append("</br>");
            }
            htmlBuilder.Append("</body>");
            htmlBuilder.Append("</html>");
            htmlString = htmlBuilder.ToString();
            if (!File.Exists("html.html"))
            {
                File.Create("html.html").Close();
            }
            File.WriteAllText("html.html", htmlString);
        }

    }
}
