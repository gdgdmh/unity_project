using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Mhl_Test_TestParameter
{
    // A Test behaves as an ordinary method
    [Test]
    public void Mhl_Test_TestParameterDefaultValue()
    {
        Mhl.Test.TestParameter param = new Mhl.Test.TestParameter();
        const int Value = 0;
        Assert.AreEqual(param.Get(), Value);
    }

    [Test]
    public void Mhl_Test_TestParameterSet1()
    {
        Mhl.Test.TestParameter param = new Mhl.Test.TestParameter();
        const int Value = 1;
        param.Set(Value);
        Assert.AreEqual(param.Get(), Value);
    }

    [Test]
    public void Mhl_Test_TestParameterSet1234567()
    {
        Mhl.Test.TestParameter param = new Mhl.Test.TestParameter();
        const int Value = 1234567;
        param.Set(Value);
        Assert.AreEqual(param.Get(), Value);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator Mhl_Test_TestParameterWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
