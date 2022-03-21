using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mhl.TestCode.List.System.Random.Integer
{
    /// <summary>
    /// RandomIntSystemテストコード
    /// </summary>
    public class TestRandomIntSystem : Mhl.System.Test.IUnitTestable
    {
        static readonly int TEST_TASK_COUNT = 100; // テストで実行する回数

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TestRandomIntSystem()
        {
        }

        /// <summary>
        /// ユニットテスト
        /// </summary>
        public void UnitTest()
        {
            TestMin0Max0();
            TestMin0Max100();
        }

        /// <summary>
        /// 最小値0の最大値0でテスト
        /// </summary>
        private void TestMin0Max0()
        {
            Mhl.System.Random.Integer.RandIntSystem rand = new Mhl.System.Random.Integer.RandIntSystem();
            const int Min = 0;
            const int Max = 0;
            for (int i = 0; i < TEST_TASK_COUNT; ++i)
            {
                int result = rand.GetRange(Min, Max);
                //UnityEngine.Debug.Log("result=" + result);
                UnityEngine.Debug.Assert(result == 0);
            }
        }

        /// <summary>
        /// 最小値0の最大値100でテスト
        /// </summary>
        private void TestMin0Max100()
        {
            Mhl.System.Random.Integer.RandIntSystem rand = new Mhl.System.Random.Integer.RandIntSystem();
            const int Min = 0;
            const int Max = 100;
            for (int i = 0; i < TEST_TASK_COUNT; ++i)
            {
                int result = rand.GetRange(Min, Max);
                //UnityEngine.Debug.Log("result=" + result);
                UnityEngine.Debug.Assert((Min <= result) && (result <= Max));
            }
        }
    }
}