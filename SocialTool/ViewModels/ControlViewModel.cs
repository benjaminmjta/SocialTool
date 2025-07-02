using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialTool.ViewModels.Control;

namespace SocialTool.ViewModels
{
    public class ControlViewModel : BaseViewModel
    {
		private BaseTaxViewModel _baseTaxViewModel = new BaseTaxViewModel();

		public BaseTaxViewModel BaseTaxViewModel
		{
			get { return _baseTaxViewModel; }
			private set { _baseTaxViewModel = value; }
		}

	}
}
