using AcmeServices.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeServices.ViewModels
{
    public class RelationsSearchViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private RelationsService RelationsService { get; set; }

        public ObservableCollection<Relation> Data { get; set; }

        public string SearchString { get; set; }

        private bool isLoading;
        public bool IsLoading
        {
            get
            {
                return isLoading;
            }
            set
            {
                if (isLoading != value)
                {
                    isLoading = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsLoading)));
                }
            }
        }

        private bool dataVisible;
        public bool DataVisible
        {
            get
            {
                return dataVisible;
            }
            set
            {
                if (dataVisible != value)
                {
                    dataVisible = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DataVisible)));
                }
            }
        }

        public RelationsSearchViewModel()
        {
            RelationsService = new RelationsService();
            Data = new ObservableCollection<Relation>();
        }

        public async Task SearchDataAsync ()
        {
            IsLoading = true;
            try
            {
                Data.Clear();
                var data = await RelationsService.GetRelationsAsync(SearchString);
                foreach (var relation in data)
                {
                    Data.Add(relation);
                }
                DataVisible = true;
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
