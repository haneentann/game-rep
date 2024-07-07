using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DirectionTest
{

    [UnityTest]
    public IEnumerator PlayerInitializationTestWithEnumeratorPasses()
    {
        // Arrange
        GameObject player = new GameObject();
        BirdScript bird = player.AddComponent<BirdScript>();

        // Act
        yield return null; // Wait for a frame

        // Assert
        Assert.IsNotNull(bird);
    }
    [UnityTest]
    public IEnumerator DirectionTestWithEnumeratorPasses()
    {
        // Create a GameObject for the LogicScript and tag it since the start method in birdscripts assumes one exists
        GameObject logicGameObject = new GameObject();
        logicGameObject.tag = "Logic";
        LogicScript logic = logicGameObject.AddComponent<LogicScript>();

        // Create the player GameObject and add the BirdScript component
        GameObject player = new GameObject();
        BirdScript bird = player.AddComponent<BirdScript>();

        // Yield to skip a frame, allowing the Start() method to run
        yield return null;

        // Your test logic here

        // For example, verify that the logic component is correctly assigned
        Assert.IsNotNull(bird.logic);
    }
}
