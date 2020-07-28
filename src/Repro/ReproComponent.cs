using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Extensions.Configuration;
using MvvmBlazor.Components;
using MvvmBlazor.ViewModel;
using System.Collections.ObjectModel;

namespace Repro
{
    public class ReproComponent : MvvmComponentBase
    {
        private readonly TestModel Model = new TestModel();

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            Bind(Model, t => t.Counts);

            Model.Counts.Add(1);

            base.BuildRenderTree(builder);
        }

        private class TestModel : ViewModelBase
        {
            public ObservableCollection<int> Counts { get; } = new ObservableCollection<int>();
        }
    }
}
