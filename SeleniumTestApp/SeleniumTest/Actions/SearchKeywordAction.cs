using SeleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Actions
{
    public class SearchKeywordAction
    {
        public void ClickSearchButton(GoogleSearch googleSearch, string keyword)
        {
            googleSearch.SearchTextBox.SendKeys(keyword);
            googleSearch.SearchButton.Submit();
        }
      
        public int TotalLinkButtons()
        {
            int count = 0;
            return count;
        }
    }
}
