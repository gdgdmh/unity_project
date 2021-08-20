
/// <summary>
/// シングルトン用の終了処理
/// </summary>
public class MhlSingletonFinalizer
{
    /// <summary>
    /// 終了処理用のDelegate
    /// </summary>
    public delegate void Finalize();

    private const int FinalizeSize = 64;

    private static int size = 0;
    private static Finalize[] finalizes = new Finalize[FinalizeSize];

    /// <summary>
    /// 初期化
    /// </summary>
    /// <returns>falseなら初期化できなかった(登録済み)</returns>
    static bool Initialize()
    {
        if (size != 0)
        {
            // 既に登録されている
            return false;
        }
        for (int i = 0; i < FinalizeSize; ++i)
        {
            finalizes[i] = null;
        }
        return true;
    }

    /// <summary>
    /// 終了処理
    /// </summary>
    static void FinalizeProcess()
    {
        for (int i = FinalizeSize - 1; i >= 0; --i)
        {
            if (finalizes[i] != null)
            {
                finalizes[i] = null;
            }
        }
        size = 0;
    }

    /// <summary>
    /// 終了処理の登録
    /// </summary>
    /// <param name="addFunction">追加する終了処理関数</param>
    /// <returns>trueなら登録成功 falseなら登録失敗</returns>
    static bool Add(MhlSingletonFinalizer.Finalize addFunction)
    {
        if (size < 0)
        {
            return false;
        }
        if (size >= FinalizeSize)
        {
            return false;
        }
        finalizes[size] = addFunction;
        ++size;
        return true;
    }

    /// <summary>
    /// 終了処理実行(実行後は登録が削除される)
    /// </summary>
    static void Execute()
    {
        for (int i = FinalizeSize - 1; i >= 0; --i)
        {
            if (finalizes[i] != null)
            {
                finalizes[i]();
            }
        }
    }
}
