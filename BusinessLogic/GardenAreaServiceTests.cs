using csharp_personal_project.BusinessLogic;
using Moq;

namespace csharp_personal_project.tests.BusinessLogic
{
    public class GardenAreaServiceTests
	{
        private GardenAreaService _underTestService;

        [SetUp]
        public void Setup()
        {
			MetricSurfaceCalculator metricSurfaceCalculator = new MetricSurfaceCalculator();
            _underTestService = new GardenAreaService(metricSurfaceCalculator);
        }

        [Test]
        public void GivenGardenAreaService_WhenGetGardenAreaIsCalledWithValidData_ThenAMetricAreaIsReturned()
        {
            var result = _underTestService.GetGardenArea();
			System.Diagnostics.Debug.WriteLine("result.SurfaceArea: ", result.SurfaceArea);

			Assert.That(result.SurfaceArea, Is.EqualTo(8));
        }
    }
}