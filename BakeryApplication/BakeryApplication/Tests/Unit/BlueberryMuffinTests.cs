
using BakeryApplication.Helpers;
using BakeryApplication.ViewModels;
using Moq;
using Xunit;

namespace BakeryApplication.Tests.Unit
{
    public class BlueberryMuffinTests
    {
        [Fact]
        public void BlueberryMuffinTests_IsCombination_54_8()
        { 
            Assert.Equal("$54.8", new ApplicationManager()._container.Resolve<ProduceInputOutputViewModel>()
                .GetCostOfPackages(Common.ProduceType.BlueberryMuffin, 14, DoublesHelper.MB11Components()));
        }
    }
}
