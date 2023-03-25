using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kaikei
{
    /// <summary>
    /// 独自の画面処理を実装したクラス
    /// </summary>
    public class WindowUtil
    {
        /// <summary>
        /// コンストラクタ
        /// インスタンス生成を禁止する
        /// </summary>
        private WindowUtil()
        {
            // 処理なし
        }

        /// <summary>
        /// 独自のダイアログを出力する
        /// </summary>
        /// <param name="dialogType"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool? ShowDialog(DialogType dialogType, String message, Window target)
        {
            MessageDialog dialog = new MessageDialog();
            dialog.MessageBox.Text = message;
            dialog.MessageBox.FontSize = 20;
            // 必ず親ウィンドウの中央にダイアログを表示させる
            dialog.Owner = target;
            dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            // ダイアログタイプによって表示レイアウトを変更する
            switch (dialogType)
            {
                case DialogType.CONFIRM:
                    dialog.Title = "確認";
                    dialog.CenterPntBtn.Visibility = Visibility.Hidden;
                    dialog.LeftPntBtn.Visibility = Visibility.Visible;
                    dialog.CancelBtn.Visibility = Visibility.Visible;
                    
                    break;

                case DialogType.ERROR:
                    dialog.Title = "エラー";
                    dialog.CenterPntBtn.Visibility = Visibility.Visible;
                    dialog.LeftPntBtn.Visibility = Visibility.Hidden;
                    dialog.CancelBtn.Visibility = Visibility.Hidden;
                    break;

                default:
                    throw new NotSupportedException();
            }

            return dialog.ShowDialog();
        }

        /// <summary>
        /// ダイアログのどのボタンが押下されたかを判定する。
        /// </summary>
        /// <returns></returns>
        public bool CheckDialogBtnEvent()
        {
            return false;
        }
    }
}