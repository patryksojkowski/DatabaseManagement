using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagement.ViewModel.Tabs
{
    public class AddTabViewModel : ViewModelBase
    {
        public AddTabViewModel()
        {
            Countries = new Data.DataAccess().GetCountries();
        }

        public string Name { get; set; }


        private string lastname;
        public string Lastname
        {
            get {
                return lastname;
            }
            set {
                lastname = value;
                RaisePropertyChanged(nameof(Lastname));
            }
        }

        private string country;
        public string Country
        {
            get {
                return country;
            }
            set {
                country = value;
                Cities = new Data.DataAccess().GetCitiesByCountry(value);
                RaisePropertyChanged(nameof(Country));
            }
        }

        private string city;
        public string City
        {
            get {
                return city;
            }
            set {
                city = value;
                RaisePropertyChanged(nameof(City));
            }
        }

        private DateTime birthdate;
        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                birthdate = value;
                RaisePropertyChanged(nameof(Birthdate));
            }
        }

        private List<string> countries;
        public List<string> Countries
        {
            get {
                return countries;
            }
            set {
                (countries = value).Sort();
                Country = countries.First();
                RaisePropertyChanged(nameof(Countries));
            }
        }
        private List<string> cities;
        public List<string> Cities
        {
            get {
                return cities;
            }
            set {
                (cities = value).Sort();
                City = cities.First();
                RaisePropertyChanged(nameof(Cities));
            }
        }



    }
}
