namespace Mhl.Ui.Dialog
{
    /// <summary>
    /// ダイアログの結果
    /// </summary>
    public enum DialogResult : int
    {
        None,           // なし
        DialogCanceled, // ダイアログがキャンセルされた
        Ok,             // Okが選択された
        Yes,            // はいが選択された
        No,             // いいえが選択された
        Cancel,         // キャンセルが選択された
    };
}