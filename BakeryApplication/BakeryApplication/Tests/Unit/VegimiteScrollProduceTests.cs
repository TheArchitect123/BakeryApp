using System;
using BakeryApplication.Helpers;
using BakeryApplication.ViewModels;
using Xunit;

namespace BakeryApplication.Tests.Unit
{
    public class VegimiteScrollProduceTests
    {
        [Fact]
        public void CroissantProduceTests_IsCombination_17_98()
        {
            Assert.Equal("$17.98", new ApplicationManager()._container.Resolve<ProduceInputOutputViewModel>()
                .GetCostOfPackages(Common.ProduceType.Croissant, 10, DoublesHelper.MB11Components()));
        }
    }
}
