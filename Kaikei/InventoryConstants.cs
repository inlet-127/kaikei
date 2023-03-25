using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 棚卸資産で扱う識別子を定義するクラス
    /// </summary>
    public class InventoryConstants : IColumnIdentifier<InventoryConstants>
    {

        /// <summary>
        /// 項目名
        /// </summary>
        private readonly String identifierName;

        /// <summary>
        /// 識別子
        /// </summary>
        private readonly String identifierCode;

        /// <summary>
        /// 棚卸資産で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<InventoryConstants> INVENTORY_IDENTIFIER_SET = new HashSet<InventoryConstants>()
        {
            INVENTORY_SUBJECTS,
            ITEM,
            QUANTITY,
            UNIT,
            UNIT_PRICE,
            INVENTORY_PERIOD_END_HIGH,
            INVENTORY_SUMMARY
        };

        /// <summary>
        /// 科目(※棚卸資産)
        /// </summary>
        public static readonly InventoryConstants INVENTORY_SUBJECTS = new InventoryConstants(NameColumnIdentifierConstants.SUBJECTS, CodeColumnIdentifierConstants.SUBJECTS_TN01);

        /// <summary>
        /// 品目
        /// </summary>
        public static readonly InventoryConstants ITEM = new InventoryConstants(NameColumnIdentifierConstants.ITEM, CodeColumnIdentifierConstants.ITEM);

        /// <summary>
        /// 数量
        /// </summary>
        public static readonly InventoryConstants QUANTITY = new InventoryConstants(NameColumnIdentifierConstants.QUANTITY, CodeColumnIdentifierConstants.QUANTITY);

        /// <summary>
        /// 単位
        /// </summary>
        public static readonly InventoryConstants UNIT = new InventoryConstants(NameColumnIdentifierConstants.UNIT, CodeColumnIdentifierConstants.UNIT);

        /// <summary>
        /// 単価
        /// </summary>
        public static readonly InventoryConstants UNIT_PRICE = new InventoryConstants(NameColumnIdentifierConstants.UNIT_PRICE, CodeColumnIdentifierConstants.UNIT_PRICE);

        /// <summary>
        /// 期末現在高(※棚卸資産)
        /// </summary>
        public static readonly InventoryConstants INVENTORY_PERIOD_END_HIGH = new InventoryConstants(NameColumnIdentifierConstants.PERIOD_END_HIGH, CodeColumnIdentifierConstants.PERIOD_END_HIGH_TN06);

        /// <summary>
        /// 摘要(※棚卸資産)
        /// </summary>
        public static readonly InventoryConstants INVENTORY_SUMMARY = new InventoryConstants(NameColumnIdentifierConstants.SUMMARY, CodeColumnIdentifierConstants.SUMMARY_TN07);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private InventoryConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 棚卸資産で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>棚卸資産で扱う識別子の一覧</returns>
        public HashSet<InventoryConstants> GetColumnIdentifiers()
        {
            return INVENTORY_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 棚卸資産で固定
            return ImportCategoryConstants.INVENTORY;
        }

        /// <summary>
        /// 項目名を取得する
        /// </summary>
        /// <returns>項目名</returns>
        public string GetIdentifierName()
        {
            return identifierName;
        }

        /// <summary>
        /// 識別子を取得する
        /// </summary>
        /// <returns>項目名</returns>
        public string GetIdentifierCode()
        {
            return identifierCode;
        }

    }
}
