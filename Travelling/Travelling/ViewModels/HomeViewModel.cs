using System;
using System.Collections.Generic;
using System.Text;
using Travelling.Models;

namespace Travelling.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private List<JourneyInfo> journeyList;   //comment

        public List<JourneyInfo> JourneyList
        {
            get { return journeyList; }
            set { SetProperty(ref journeyList, value); }
        }


    }
}
