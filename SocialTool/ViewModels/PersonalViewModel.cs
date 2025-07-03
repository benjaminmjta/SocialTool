using SocialTool.Commands;
using SocialTool.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SocialTool.ViewModels
{
    class PersonalViewModel : BaseViewModel
    {
		private string _ownTake;

		public string OwnTake
		{
			get { return _ownTake; }
            set
            {
                _ownTake = value;
                OnPropertyChanged();
            }
        }

        private string _ownGet;

        public string OwnGet
        {
            get { return _ownGet; }
            set
            {
                _ownGet = value;
                OnPropertyChanged();
            }
        }

		private string _ownIncome;

		public string OwnIncome
		{
			get { return _ownIncome; }
			set 
			{
                _ownIncome = (int.TryParse(value, out int result) ? result : 0).ToString();
                OnPropertyChanged();
			}
		}

        private string _ownNetIncome;

        public string OwnNetIncome
        {
            get { return _ownNetIncome; }
            set
            {
                _ownNetIncome = value;
                OnPropertyChanged();
            }
        }

        public ICommand CalculateCmd { get; set; }

		private bool CanCalculate(object obj)
		{
			return true;
		}

		private void Calculate(object obj)
		{
			string tempget = string.Empty;
			string temptake = string.Empty;
			string tempnetinc = string.Empty;
			Calculations.CalculatePersonalIncome(OwnIncome, ref tempget, ref temptake, ref tempnetinc);
			OwnGet = tempget;
			OwnTake = temptake;
			OwnNetIncome = tempnetinc;
		} 

        public PersonalViewModel()
		{
			this._ownIncome = "18900";
			CalculateCmd = new RelayCommand(Calculate, CanCalculate);
		}

	}
}
