namespace Mhl.Ui.Dialog
{
    /// <summary>
    /// YesNoダイアログインターフェース
    /// </summary>
    public interface IDialogYesNo
    {
        /// <summary>
        /// ダイアログタイトルテキストを設定
        /// </summary>
        /// <param name="title">ダイアログタイトルに表示するテキスト</param>
        void SetTitle(string title);

        /// <summary>
        /// ダイアログ本文テキストの設定
        /// </summary>
        /// <param name="text">ダイアログ本文に表示するテキスト</param>
        void SetText(string text);

        /// <summary>
        /// ダイアログを表示する
        /// </summary>
        /// <returns>trueならダイアログが表示を開始した
        /// falseならすでに表示されているなどで表示開始できなかった
        /// </returns>
        bool Open();

        /// <summary>
        /// ダイアログを閉じる
        /// </summary>
        /// <returns>trueならダイアログが非表示を開始した
        /// falseなら表示していないなどで非表示を開始できなかった
        /// </returns>
        bool Close();

        /// <summary>
        /// ダイアログ処理中か
        /// </summary>
        /// <returns>trueなら処理中 falseなら処理をしていない</returns>
        bool IsProcessing();

        /// <summary>
        /// ダイアログの結果を取得する
        /// </summary>
        /// <returns>ダイアログの結果</returns>
        DialogResult GetResult();
    }
}