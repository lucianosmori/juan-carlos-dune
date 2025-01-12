using NUnit.Framework;

[TestFixture]
public class PlanetaryEventsTests
{
    private PlanetaryEvents planetaryEvents;

    [SetUp]
    public void SetUp()
    {
        planetaryEvents = new PlanetaryEvents();
    }

    [Test]
    public void SubscribeToEvent_ShouldAddSubscriber()
    {
        // Arrange
        Action eventAction = () => { };

        // Act
        planetaryEvents.SubscribeToEvent("TestEvent", eventAction);

        // Assert
        Assert.IsTrue(planetaryEvents.HasSubscriber("TestEvent", eventAction));
    }

    [Test]
    public void UnsubscribeFromEvent_ShouldRemoveSubscriber()
    {
        // Arrange
        Action eventAction = () => { };
        planetaryEvents.SubscribeToEvent("TestEvent", eventAction);

        // Act
        planetaryEvents.UnsubscribeFromEvent("TestEvent", eventAction);

        // Assert
        Assert.IsFalse(planetaryEvents.HasSubscriber("TestEvent", eventAction));
    }

    [Test]
    public void TriggerEvent_ShouldInvokeSubscribers()
    {
        // Arrange
        bool wasTriggered = false;
        Action eventAction = () => { wasTriggered = true; };
        planetaryEvents.SubscribeToEvent("TestEvent", eventAction);

        // Act
        planetaryEvents.TriggerEvent("TestEvent");

        // Assert
        Assert.IsTrue(wasTriggered);
    }
}