using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpecTestProj2.Library.Pages
{
    public class HomePage
    {
        Actions.Actions actions = new Actions.Actions();

        #region Control Properties
        private string SearchTextBox_Name = "q_Name";
        private string SearchButton_ClassName = "vh79eN_ClassName";
        #endregion

        #region PageObject Methods
        public void PerformSearch(string searchString)
        {
            actions.SetText(SearchTextBox_Name, searchString);
            actions.ClickElement(SearchButton_ClassName);
        }
        #endregion
    }
}
