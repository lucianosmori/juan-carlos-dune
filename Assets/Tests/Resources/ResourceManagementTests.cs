using NUnit.Framework;

[TestFixture]
public class ResourceManagementTests
{
    private ResourceManagement resourceManagement;

    [SetUp]
    public void SetUp()
    {
        resourceManagement = new ResourceManagement();
    }

    [Test]
    public void LoadResource_ValidResource_ReturnsResource()
    {
        var resource = resourceManagement.LoadResource("validResource");
        Assert.IsNotNull(resource);
    }

    [Test]
    public void LoadResource_InvalidResource_ReturnsNull()
    {
        var resource = resourceManagement.LoadResource("invalidResource");
        Assert.IsNull(resource);
    }

    [Test]
    public void UnloadResource_ValidResource_ResourceIsUnloaded()
    {
        resourceManagement.LoadResource("validResource");
        resourceManagement.UnloadResource("validResource");
        var resource = resourceManagement.GetResource("validResource");
        Assert.IsNull(resource);
    }

    [Test]
    public void GetResource_ResourceLoaded_ReturnsResource()
    {
        resourceManagement.LoadResource("validResource");
        var resource = resourceManagement.GetResource("validResource");
        Assert.IsNotNull(resource);
    }

    [Test]
    public void GetResource_ResourceNotLoaded_ReturnsNull()
    {
        var resource = resourceManagement.GetResource("nonExistentResource");
        Assert.IsNull(resource);
    }
}