using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mhl.TestCode
{
    public class TestMhl : MonoBehaviour
    {
        public TestMhl()
        {
        }

        public void Start()
        {
            Task();
        }

        public void Task()
        {
            UnityEngine.Debug.Log("TestMhl start");
            TestRandomIntSystem();
            UnityEngine.Debug.Log("TestMhl end");
        }

        public void TestRandomIntSystem()
        {
            Mhl.TestCode.List.System.Random.Integer.TestRandomIntSystem t = new TestCode.List.System.Random.Integer.TestRandomIntSystem();
            UnityEngine.Debug.Assert(t != null);
            t.UnitTest();
        }
    }
}
