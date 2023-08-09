using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.History
{
    public class HtmlSideGenerator
    {
        private string NameDisplayed = "History";
        private DatabaseHandling dbHandler;
        private List<HistoryElement> historyElements;

        public HtmlSideGenerator() 
        {
            LoadData();
        }

        public HtmlSideGenerator(string name)
        {
            NameDisplayed = name;

            LoadData();
        }

        private async void LoadData()
        {
            dbHandler = new DatabaseHandling();
            var data = await dbHandler.GetAllEncryptedOperationsAsync();
            if (data is not null) historyElements = data;
        }

        public string Get()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }
    }
}
