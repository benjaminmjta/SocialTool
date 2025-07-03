using SocialTool.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialTool.ViewModels.Control
{
    public class BaseTaxViewModel : BaseViewModel
    {
        public BaseTaxViewModel() 
        {
            IsActive = true;
            Limit = "1500";
            Total = "15";
        }

        private bool _isActive;

        private string _limit;

        private string _total;

        public bool IsActive
        {
            get { return _isActive; }
            set {
                _isActive = value;
                Calculations.BaseTaxActive = value;
                OnPropertyChanged();
            }
        }

        public string Limit
        {
            get { return _limit; }
            set {
                _limit = value;
                OnPropertyChanged();
            }
        }

        public string Total
        {
            get { return _total; }
            set {
                _total = (int.TryParse(value, out int result) ? result : 0).ToString();
                Calculations.BaseTaxPercentage = int.Parse(_total);
                OnPropertyChanged();
            }
        }
    }
}
