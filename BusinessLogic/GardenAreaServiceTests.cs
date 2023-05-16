using csharp_personal_project.BusinessLogic;
using Moq;

namespace csharp_personal_project.tests.BusinessLogic
{
    public class GardenAreaServiceTests
	{
        private Mock<MetricSurfaceCalculator> _metricSurfaceCalculator;
		private Mock<ImperialSurfaceCalculator> _imperialSurfaceCalculator;
		private GardenAreaService? _underTest;

		[SetUp]
        public void Setup()
        {
			_metricSurfaceCalculator = new Mock<MetricSurfaceCalculator>();
			_imperialSurfaceCalculator = new Mock<ImperialSurfaceCalculator>();
		}

        [Test]
        public void GivenGardenAreaService_WhenGetGardenAreaIsCalledWithValidData_ThenAMetricAreaIsReturned()
        {
			_underTest = new GardenAreaService(_metricSurfaceCalculator.Object);
			var result = _underTest.GetGardenArea(2,4);

			Assert.That(result.SurfaceArea, Is.EqualTo(8));
        }

		[Test]
		public void GivenGardenAreaService_WhenGetGardenAreaIsCalledWithValidData_ThenAnImperialAreaIsReturned()
		{
			_underTest = new GardenAreaService(_imperialSurfaceCalculator.Object);
			var result = _underTest.GetGardenArea(2,4);

			Assert.That(result.SurfaceArea, Is.EqualTo(86.111199999999997));
		}
	}
}