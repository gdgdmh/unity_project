using System.Collections.Generic;

namespace Mhl.System.Test
{
    public class UnitTestExecuteList
    {
        private List<Mhl.System.Test.UnitTestBase> unitTestList = new List<Mhl.System.Test.UnitTestBase>(); // ユニットテスト実行リスト

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public UnitTestExecuteList()
        {
        }

        /// <summary>
        /// ユニットテストオブジェクト追加
        /// </summary>
        /// <param name="unitTestBase">ユニットテストに追加するオブジェクト</param>
        public void Add(Mhl.System.Test.UnitTestBase unitTestBase)
        {
            unitTestList.Add(unitTestBase);
        }

        /// <summary>
        /// ユニットテストオブジェクトを一括削除
        /// </summary>
        public void Clear()
        {
            unitTestList.Clear();
        }

        /// <summary>
        /// ユニットテスト実行
        /// </summary>
        /// <returns></returns>
        public bool UnitTest()
        {
            bool success = true;
            try
            {
                // 順次テストを実行
                for (int i = 0; i < unitTestList.Count; ++i)
                {
                    unitTestList[i].UnitTest();
                }
            }
            catch (global::System.Exception e)
            {
                // ユニットテスト失敗
                UnityEngine.Debug.Log(e.ToString());
                UnityEngine.Debug.Log("UnitTestExecuteList failure");
                success = false;
            }
            if (success)
            {
                UnityEngine.Debug.Log("UnitTestExecuteList success");
            }
            return success;
        }
    }
}