using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestPlayModeABC
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestPlayModeABCSimplePasses()
    {
        // Use the Assert class to test conditions
        float aaa = 1.0f;
        float bbb = 1.0f;
        Assert.AreEqual(aaa, bbb);
    }
}
