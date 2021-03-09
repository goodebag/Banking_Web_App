using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanking.Presentation.Services;
using WebBanking.Rest.Models;

namespace WebBanking.Presentation.Pages
{
    public class TransferDetailsBase : ComponentBase
    {
        [Inject]
        public IOperationServices GetOperations { get; set; }
        public Transfer transfer { get; set; } = new Transfer();
        [Parameter]
        public string Id { get; set; }
        public List<Bank> Banks { get; set; } = new List<Bank>();

        protected override async Task OnInitializedAsync()
        {
            transfer = await GetOperations.GetTransfer(int.Parse(Id));
            Banks = Enum.GetValues(typeof(Bank))
                            .Cast<Bank>()
                            .ToList();
        }

    }
}
