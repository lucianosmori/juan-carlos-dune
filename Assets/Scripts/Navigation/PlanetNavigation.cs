using System.Collections.Generic;

public class PlanetNavigation
{
    private List<string> planets;
    private int currentPlanetIndex;

    public PlanetNavigation(List<string> initialPlanets)
    {
        planets = initialPlanets;
        currentPlanetIndex = 0;
    }

    public void NavigateToPlanet(int planetIndex)
    {
        if (planetIndex >= 0 && planetIndex < planets.Count)
        {
            currentPlanetIndex = planetIndex;
            // Logic to navigate to the selected planet
        }
    }

    public string GetCurrentPlanet()
    {
        return planets[currentPlanetIndex];
    }
}