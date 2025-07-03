using SocialTool.Logic;
using SocialTool.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialTool.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
		private BaseViewModel _controlViewModel;

		public BaseViewModel ControlViewModel
		{
			get { return _controlViewModel; }
			private set { _controlViewModel = value; }
		}

		private BaseViewModel _personalViewModel;

		public BaseViewModel PersonalViewModel
		{
			get { return _personalViewModel; }
			set { _personalViewModel = value; }
		}

		public MainViewModel() 
		{
			this._personalViewModel = new PersonalViewModel();
			this._controlViewModel = new ControlViewModel();
			Population.Populate();
		}

	}
}
