using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialTool.Models
{
    public class Population
    {
        public static ObservableCollection<Person> _People = new ObservableCollection<Person>();

        public static ObservableCollection<Person> GetPeople()
        {
            return _People;
        }

        public static void AddPerson(Person person)
        {
            if (person != null && !_People.Any(p => p.Id == person.Id))
            {
                _People.Add(person);
            }
        }
    }
}
