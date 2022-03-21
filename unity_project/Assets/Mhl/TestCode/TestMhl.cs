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
            UnityEngine.Debug.Log("TestMhl end");
        }
    }
}
