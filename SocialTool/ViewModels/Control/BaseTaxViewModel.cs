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
            _isActive = true;
            _limit = "1500";
            _total = "15";
        }

        private bool _isActive;

        private string _limit;

        private string _total;

        public bool IsActive
        {
            get { return _isActive; }
            set {
                _isActive = value;
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
                _total = value;
                OnPropertyChanged();
            }
        }
    }
}
