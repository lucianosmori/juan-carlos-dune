using NUnit.Framework;
using Assets.Scripts.Navigation;

namespace Tests.Navigation
{
    public class PlanetNavigationTests
    {
        private PlanetNavigation planetNavigation;

        [SetUp]
        public void Setup()
        {
            planetNavigation = new PlanetNavigation();
        }

        [Test]
        public void NavigateToPlanet_ValidPlanet_ChangesCurrentPlanet()
        {
            string targetPlanet = "Mars";
            planetNavigation.NavigateToPlanet(targetPlanet);
            Assert.AreEqual(targetPlanet, planetNavigation.GetCurrentPlanet());
        }

        [Test]
        public void GetCurrentPlanet_NoNavigation_ReturnsDefaultPlanet()
        {
            Assert.AreEqual("Earth", planetNavigation.GetCurrentPlanet());
        }

        [Test]
        public void NavigateToPlanet_InvalidPlanet_DoesNotChangeCurrentPlanet()
        {
            string initialPlanet = planetNavigation.GetCurrentPlanet();
            planetNavigation.NavigateToPlanet("InvalidPlanet");
            Assert.AreEqual(initialPlanet, planetNavigation.GetCurrentPlanet());
        }
    }
}