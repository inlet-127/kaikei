using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 支払手形で扱う識別子を定義するクラス
    /// </summary>
    public class BillsPayableConstants : IColumnIdentifier<BillsPayableConstants>
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
        /// 支払手形で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<BillsPayableConstants> BILLS_PAYABLE_IDENTIFIER_SET = new HashSet<BillsPayableConstants>()
        {
            PAYMENT_DESTINATION,
            YEAR_OF_REFERENCE,
            MONTH_OF_REFERENCE,
            DAY_OF_REFERENCE,
            PAYMENT_TERM_YEAR,
            PAYMENT_TERM_MONTH,
            PAYMENT_TERM_DAY,
            BILLS_PAYABLE_PAYMENT_BANK_NAME,
            BILLS_PAYABLE_BRANCH_NAME,
            BILLS_PAYABLE_AMOUNT_OF_MONEY,
            BILLS_PAYABLE_SUMMARY
        };

        /// <summary>
        /// 支払先
        /// </summary>
        public static readonly BillsPayableConstants PAYMENT_DESTINATION = new BillsPayableConstants(NameColumnIdentifierConstants.PAYMENT_DESTINATION, CodeColumnIdentifierConstants.PAYMENT_DESTINATION);

        /// <summary>
        /// 振出年月日（年）
        /// </summary>
        public static readonly BillsPayableConstants YEAR_OF_REFERENCE = new BillsPayableConstants(NameColumnIdentifierConstants.YEAR_OF_REFERENCE, CodeColumnIdentifierConstants.YEAR_OF_REFERENCE);

        /// <summary>
        /// 振出年月日（月）
        /// </summary>
        public static readonly BillsPayableConstants MONTH_OF_REFERENCE = new BillsPayableConstants(NameColumnIdentifierConstants.MONTH_OF_REFERENCE, CodeColumnIdentifierConstants.MONTH_OF_REFERENCE);

        /// <summary>
        /// 振出年月日（日）
        /// </summary>
        public static readonly BillsPayableConstants DAY_OF_REFERENCE = new BillsPayableConstants(NameColumnIdentifierConstants.DAY_OF_REFERENCE, CodeColumnIdentifierConstants.DAY_OF_REFERENCE);

        /// <summary>
        /// 支払期日（年）
        /// </summary>
        public static readonly BillsPayableConstants PAYMENT_TERM_YEAR = new BillsPayableConstants(NameColumnIdentifierConstants.PAYMENT_TERM_YEAR, CodeColumnIdentifierConstants.PAYMENT_TERM_YEAR);

        /// <summary>
        /// 支払期日（月）
        /// </summary>
        public static readonly BillsPayableConstants PAYMENT_TERM_MONTH = new BillsPayableConstants(NameColumnIdentifierConstants.PAYMENT_TERM_MONTH, CodeColumnIdentifierConstants.PAYMENT_TERM_MONTH);

        /// <summary>
        /// 支払期日（日）
        /// </summary>
        public static readonly BillsPayableConstants PAYMENT_TERM_DAY = new BillsPayableConstants(NameColumnIdentifierConstants.PAYMENT_TERM_DAY, CodeColumnIdentifierConstants.PAYMENT_TERM_DAY);

        /// <summary>
        /// 支払先銀行名(※支払手形)
        /// </summary>
        public static readonly BillsPayableConstants BILLS_PAYABLE_PAYMENT_BANK_NAME = new BillsPayableConstants(NameColumnIdentifierConstants.PAYMENT_BANK_NAME, CodeColumnIdentifierConstants.PAYMENT_BANK_NAME_ST08);

        /// <summary>
        /// 支店名(※支店名)
        /// </summary>
        public static readonly BillsPayableConstants BILLS_PAYABLE_BRANCH_NAME = new BillsPayableConstants(NameColumnIdentifierConstants.BRANCH_NAME, CodeColumnIdentifierConstants.BRANCH_NAME_ST09);

        /// <summary>
        /// 金額(※支払手形)
        /// </summary>
        public static readonly BillsPayableConstants BILLS_PAYABLE_AMOUNT_OF_MONEY = new BillsPayableConstants(NameColumnIdentifierConstants.AMOUNT_OF_MONEY, CodeColumnIdentifierConstants.AMOUNT_OF_MONEY_ST10);

        /// <summary>
        /// 摘要(※支払手形)
        /// </summary>
        public static readonly BillsPayableConstants BILLS_PAYABLE_SUMMARY = new BillsPayableConstants(NameColumnIdentifierConstants.SUMMARY, CodeColumnIdentifierConstants.SUMMARY_ST11);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private BillsPayableConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 支払手形で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>支払手形で扱う識別子の一覧</returns>
        public HashSet<BillsPayableConstants> GetColumnIdentifiers()
        {
            return BILLS_PAYABLE_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 支払手形で固定
            return ImportCategoryConstants.BILLS_PAYABLE;
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
