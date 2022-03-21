
namespace Mhl.System.Test
{
    /// <summary>
    /// ユニットテストインターフェース
    /// </summary>
    public interface IUnitTestable
    {
        /// <summary>
        /// ユニットテストを実行
        /// 失敗時には
        /// throw new global::System.Exception(); などで例外を出すこと
        /// </summary>
        void UnitTest();
    }
}