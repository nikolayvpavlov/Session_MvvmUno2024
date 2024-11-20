using AcmeServices.ViewModels;
using Microsoft.AspNetCore.Components;

namespace AcmeBlazor.Components.Pages
{
    public partial class Relations
    {
        [Inject]
        public RelationsSearchViewModel RelationsViewModel { get; set; }

        public async Task SearchRelationsAsync()
        {
            await RelationsViewModel.SearchDataAsync();
        }
    }
}
