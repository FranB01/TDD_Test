using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;
using NinjaFrog;

public class NinjaFrogMovementTest
{
    private GameObject NinjaFrog;
    private GameObject Ground;
    private GameObject Coin;

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene("SampleScene");
        Debug.Log("Scene Loaded");
    }
    [UnityTest]
    public IEnumerator NinjaFrogFall()
    {
        yield return new WaitForSeconds(2);
        NinjaFrog = GameObject.Find("NinjaFrog");
        Ground = GameObject.Find("Ground");
        Assert.That(NinjaFrog.transform.position.y > Ground.transform.position.y);

    }

    [UnityTest]
    public IEnumerator NinjaFrogCoin()
    {
        yield return new WaitForSeconds(2);
        NinjaFrog = GameObject.Find("NinjaFrog");
        Coin = GameObject.Find("Coin");
        Assert.That(NinjaFrog.GetComponent<NinjaFrogMovement>().stats.coins == 1);
    }


    [TearDown]
    public void TearDown()
    {
        EditorSceneManager.UnloadSceneAsync("SampleScene");
    }
}
