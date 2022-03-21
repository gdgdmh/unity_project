
namespace Mhl.System.Test
{
    /// <summary>
    /// ユニットテスト基底クラス
    /// </summary>
    public class UnitTestBase
    {
        private IUnitTestable unitTestable; // ユニットテストインターフェース

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="unitTestable">ユニットテストインターフェース</param>
        public UnitTestBase(Mhl.System.Test.IUnitTestable unitTestable)
        {
            this.unitTestable = unitTestable;
        }

        /// <summary>
        /// ユニットテストを実行
        /// </summary>
        public void UnitTest()
        {
            unitTestable.UnitTest();
        }
    }
}