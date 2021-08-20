using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mhl.Test
{

    public class TestParameter
    {
        private int param = 0;

        public TestParameter()
        {
            param = 0;
        }

        public void Set(int param)
        {
            this.param = param;
        }

        public int Get()
        {
            return param;
        }

    }
}