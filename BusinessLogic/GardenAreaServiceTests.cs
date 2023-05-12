using csharp_personal_project.BusinessLogic;
using Moq;

namespace csharp_personal_project.tests.BusinessLogic
{
    public class GardenAreaServiceTests
	{
        private GardenAreaService _underTestService;
        private Mock<ISurfaceCalculator> _surfaceCalculator;

        [SetUp]
        public void Setup()
        {
            _surfaceCalculator = new Mock<ISurfaceCalculator>();
            _underTestService = new GardenAreaService(_surfaceCalculator.Object);
        }

        [Test]
        public void GivenGardenAreaService_WhenGetGardenAreaIsCalledWithValidData_ThenAMetricAreaIsReturned()
        {
            var result = _underTestService.GetGardenArea();
            Assert.AreEqual(8, result.SurfaceArea);
        }
    }
}