using System;
using BakeryApplication.Helpers;
using BakeryApplication.ViewModels;
using Xunit;

namespace BakeryApplication.Tests.Unit
{
    public class CroissantProduceTests
    {
        [Fact]
        public void CroissantProduceTests_IsCombination_25_85()
        {
            Assert.Equal("$25.85", new ApplicationManager()._container.Resolve<ProduceInputOutputViewModel>()
                .GetCostOfPackages(Common.ProduceType.Croissant, 13, DoublesHelper.MB11Components()));
        }
    }
}
