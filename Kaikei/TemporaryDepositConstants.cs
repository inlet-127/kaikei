using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 仮受金で扱う識別子を定義するクラス
    /// </summary>
    public class TemporaryDepositConstants : IColumnIdentifier<TemporaryDepositConstants>
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
        /// 仮受金で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<TemporaryDepositConstants> TEMPORARY_DEPOSIT_IDENTIFIER_SET = new HashSet<TemporaryDepositConstants>()
        {
            TEMPORARY_DEPOSIT_SUBJECT,
            TEMPORARY_DEPOSIT_NAME,
            TEMPORARY_DEPOSIT_ADDRESS,
            TEMPORARY_DEPOSIT_RELATIONSHIP,
            TEMPORARY_DEPOSIT_PERIOD_END_HIGH,
            TEMPORARY_DEPOSIT_TRANSACTION_CONTENT
        };

        /// <summary>
        /// 科目(※仮受金)
        /// </summary>
        public static readonly TemporaryDepositConstants TEMPORARY_DEPOSIT_SUBJECT = new TemporaryDepositConstants(NameColumnIdentifierConstants.SUBJECTS, CodeColumnIdentifierConstants.SUBJECTS_RU01);

        /// <summary>
        /// 名称（氏名）(※仮受金)
        /// </summary>
        public static readonly TemporaryDepositConstants TEMPORARY_DEPOSIT_NAME = new TemporaryDepositConstants(NameColumnIdentifierConstants.NAME, CodeColumnIdentifierConstants.NAME);

        /// <summary>
        /// 所在地（住所）(※仮受金)
        /// </summary>
        public static readonly TemporaryDepositConstants TEMPORARY_DEPOSIT_ADDRESS = new TemporaryDepositConstants(NameColumnIdentifierConstants.ADDRESS, CodeColumnIdentifierConstants.ADDRESS_RU03);

        /// <summary>
        /// 関係(※仮受金)
        /// </summary>
        public static readonly TemporaryDepositConstants TEMPORARY_DEPOSIT_RELATIONSHIP = new TemporaryDepositConstants(NameColumnIdentifierConstants.RELATIONSHIP, CodeColumnIdentifierConstants.RELATIONSHIP_RU04);

        /// <summary>
        /// 期末現在高(※仮受金)
        /// </summary>
        public static readonly TemporaryDepositConstants TEMPORARY_DEPOSIT_PERIOD_END_HIGH = new TemporaryDepositConstants(NameColumnIdentifierConstants.PERIOD_END_HIGH, CodeColumnIdentifierConstants.PERIOD_END_HIGH_RU05);

        /// <summary>
        /// 取引の内容(※仮受金)
        /// </summary>
        public static readonly TemporaryDepositConstants TEMPORARY_DEPOSIT_TRANSACTION_CONTENT = new TemporaryDepositConstants(NameColumnIdentifierConstants.TRANSACTION_CONTENT, CodeColumnIdentifierConstants.TRANSACTION_CONTENT_RU06);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private TemporaryDepositConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 仮受金で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>仮受金で扱う識別子の一覧</returns>
        public HashSet<TemporaryDepositConstants> GetColumnIdentifiers()
        {
            return TEMPORARY_DEPOSIT_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 仮受金で固定
            return ImportCategoryConstants.TEMPORARY_DEPOSIT;
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
