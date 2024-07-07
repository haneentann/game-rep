using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

[TestFixture]
public class TestBird
{
    [Test]
    public void BirdShouldBeAlive()
    {
        //Arrange
        var gameO = new GameObject();
        var bird = gameO.AddComponent<BirdScript>();

        //Act -- NA

        //Verify
        Assert.IsTrue(bird.birdIsAlive);

    }
    // A Test behaves as an ordinary method
    [Test]
    public void BirdShouldIncreaseLevel()
    {
        //Arrange
/*        var gameO = new GameObject();
        var bird = gameO.AddComponent<BirdScript>();

        //Act
        bird.increaseLevel();


        //Asert
        Assert.AreEqual(2, bird.level);*/




        /*Assert.AreEqual(true, bird.birdIsAlive);
        Assert.IsTrue(bird.birdIsAlive);//: Verifies that a condition is true.
        Assert.IsFalse(!bird.birdIsAlive);//: Verifies that a condition is false.
        Assert.IsNull(bird);//: Verifies that an object is null.
        Assert.IsNotNull(bird);//: Verifies that an object is not null.*/
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestBirdWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
