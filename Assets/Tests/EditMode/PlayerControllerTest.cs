using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using JuanCarlosDune.Scripts;

public class PlayerControllerTest
{
    private GameObject player;
    private PlayerController playerController;

    [SetUp]
    public void SetUp()
    {
        // Create a new GameObject and add the PlayerController component
        player = new GameObject();
        playerController = player.AddComponent<PlayerController>();
    }

    [TearDown]
    public void TearDown()
    {
        // Clean up after each test
        Object.DestroyImmediate(player);
    }

    [Test]
    public void PlayerController_MoveSpeed_DefaultValue()
    {
        // Test that the default moveSpeed value is 5
        Assert.AreEqual(5f, playerController.moveSpeed);
    }

    // A Test behaves as an ordinary method
    [Test]
    public void PlayerControllerTestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PlayerControllerTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
