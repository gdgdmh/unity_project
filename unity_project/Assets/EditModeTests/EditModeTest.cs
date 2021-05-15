using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EditModeTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void EditModeTestSimplePasses()
    {
        // Use the Assert class to test conditions
        int abc = 0;
        int def = 0;
        Assert.AreEqual(abc, def);
    }
}
