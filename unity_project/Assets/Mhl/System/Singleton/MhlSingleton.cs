using System.Collections.Generic;

namespace Mhl.System.Singleton
{
    /// <summary>
    /// シングルトンベースクラス
    /// デフォルトコンストラクタで生成可能なクラスに対してシングルトンで扱う
    /// </summary>
    /// <typeparam name="Type">シングルトンにするクラス</typeparam>
    public class MhlSingleton<Type> where Type : class, new()
    {
        static private bool initializeFlag = false;
        static private Type singletonObject = null;

        public static Type GetInstance()
        {
            if (!initializeFlag)
            {
                Create();
            }
            return singletonObject;
        }

        private static void Create()
        {
            singletonObject = new Type();
            // クリーンアップ関数に登録

        }

        private static void Cleanup()
        {
            singletonObject = null;
        }
    }
}