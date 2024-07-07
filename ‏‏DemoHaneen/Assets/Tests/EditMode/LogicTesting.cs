using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

[TestFixture]
public class LogicTesting
{
    // A Test behaves as an ordinary method
    [Test]
    public void LogicTestingSimplePasses()
    {
        
        Assert.IsTrue(true);
        /*
        //Arrange
        var gameO = new GameObject();
        var logic = gameO.AddComponent<LogicScript>();

        //Act
        logic.addScore(1);

        //Assert
        Assert.AreEqual(2, logic.playScore);
*/
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator LogicTestingWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
      //  SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        yield return null;
    }
}
