using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// データ読み込み時に必要な定義情報を扱うクラスで実装するインターフェース
    /// </summary>
    interface IColumnIdentifier<T> where T : IColumnIdentifier<T>
    {
        /// <summary>
        /// 項目名を取得する
        /// </summary>
        /// <returns>項目名</returns>
        String GetIdentifierName();

        /// <summary>
        /// 識別子を取得する
        /// </summary>
        /// <returns>識別子</returns>
        String GetIdentifierCode();

        /// <summary>
        /// カテゴリ毎の識別子を一括取得する
        /// </summary>
        /// <returns>カテゴリ毎の識別子</returns>
        HashSet<T> GetColumnIdentifiers();

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        ImportCategoryConstants GetDataFormatCategory();

    }
}
