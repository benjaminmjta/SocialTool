using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialTool.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
		private BaseViewModel _controlViewModel = new ControlViewModel();

		public BaseViewModel ControlViewModel
		{
			get { return _controlViewModel; }
			private set { _controlViewModel = value; }
		}

	}
}
