namespace Mhl.Ui.Dialog
{
    /// <summary>
    /// OKダイアログインターフェース
    /// </summary>
    public interface IDialogOk
    {
        void Open();

        void Close();

        bool IsProcessing();
    }
}