using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 受取手形で扱う識別子を定義するクラス
    /// </summary>
    public class BillsRecivableConstants : IColumnIdentifier<BillsRecivableConstants>
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
        /// 受取手形で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<BillsRecivableConstants> BILLS_RECIVABLE_IDENTIFIER_SET = new HashSet<BillsRecivableConstants>()
        {
            DIVISION,
            PICKER,
            YEAR_OF_WRITING,
            MONTH_OF_WRITING,
            DAY_OF_WRITING,
            PAYMENT_YEAR,
            PAYMENT_MONTH,
            PAYMENT_DAY,
            PAYMENT_BANK_NAME,
            PAYMENT_BANK__BRANCH_NAME,
            AMOUNT_OF_MONEY,
            DISCOUNTED_BANK_NAME,
            DISCOUNTED_BANK_BRANCH_NAME,
            BILLS_RECIVABLE_SUMMARY
        };

        /// <summary>
        /// 区分
        /// </summary>
        public static readonly BillsRecivableConstants DIVISION = new BillsRecivableConstants(NameColumnIdentifierConstants.DIVISION, CodeColumnIdentifierConstants.DIVISION_UT01);

        /// <summary>
        /// 振出人
        /// </summary>
        public static readonly BillsRecivableConstants PICKER = new BillsRecivableConstants(NameColumnIdentifierConstants.PICKER, CodeColumnIdentifierConstants.PICKER);

        /// <summary>
        /// 振出年
        /// </summary>
        public static readonly BillsRecivableConstants YEAR_OF_WRITING = new BillsRecivableConstants(NameColumnIdentifierConstants.YEAR_OF_WRITING, CodeColumnIdentifierConstants.YEAR_OF_WRITING);

        /// <summary>
        /// 振出月
        /// </summary>
        public static readonly BillsRecivableConstants MONTH_OF_WRITING = new BillsRecivableConstants(NameColumnIdentifierConstants.MONTH_OF_WRITING, CodeColumnIdentifierConstants.MONTH_OF_WRITING);

        /// <summary>
        /// 振出日
        /// </summary>
        public static readonly BillsRecivableConstants DAY_OF_WRITING = new BillsRecivableConstants(NameColumnIdentifierConstants.DAY_OF_WRITING, CodeColumnIdentifierConstants.DAY_OF_WRITING);

        /// <summary>
        /// 支払年
        /// </summary>
        public static readonly BillsRecivableConstants PAYMENT_YEAR = new BillsRecivableConstants(NameColumnIdentifierConstants.PAYMENT_YEAR, CodeColumnIdentifierConstants.PAYMENT_YEAR);

        /// <summary>
        /// 支払月
        /// </summary>
        public static readonly BillsRecivableConstants PAYMENT_MONTH = new BillsRecivableConstants(NameColumnIdentifierConstants.PAYMENT_MONTH, CodeColumnIdentifierConstants.PAYMENT_MONTH);

        /// <summary>
        /// 支払日
        /// </summary>
        public static readonly BillsRecivableConstants PAYMENT_DAY = new BillsRecivableConstants(NameColumnIdentifierConstants.PAYMENT_DAY, CodeColumnIdentifierConstants.PAYMENT_DAY);

        /// <summary>
        /// 支払銀行名
        /// </summary>
        public static readonly BillsRecivableConstants PAYMENT_BANK_NAME = new BillsRecivableConstants(NameColumnIdentifierConstants.PAYMENT_BANK_NAME, CodeColumnIdentifierConstants.PAYMENT_BANK_NAME_UT09);

        /// <summary>
        /// 支払銀行支店名
        /// </summary>
        public static readonly BillsRecivableConstants PAYMENT_BANK__BRANCH_NAME = new BillsRecivableConstants(NameColumnIdentifierConstants.PAYMENT_BANK__BRANCH_NAME, CodeColumnIdentifierConstants.PAYMENT_BANK__BRANCH_NAME);

        /// <summary>
        /// 金額
        /// </summary>
        public static readonly BillsRecivableConstants AMOUNT_OF_MONEY = new BillsRecivableConstants(NameColumnIdentifierConstants.AMOUNT_OF_MONEY, CodeColumnIdentifierConstants.AMOUNT_OF_MONEY_UT11);

        /// <summary>
        /// 割引銀行名
        /// </summary>
        public static readonly BillsRecivableConstants DISCOUNTED_BANK_NAME = new BillsRecivableConstants(NameColumnIdentifierConstants.DISCOUNTED_BANK_NAME, CodeColumnIdentifierConstants.DISCOUNTED_BANK_NAME);

        /// <summary>
        /// 割引銀行支店名
        /// </summary>
        public static readonly BillsRecivableConstants DISCOUNTED_BANK_BRANCH_NAME = new BillsRecivableConstants(NameColumnIdentifierConstants.DISCOUNTED_BANK_BRANCH_NAME, CodeColumnIdentifierConstants.DISCOUNTED_BANK_BRANCH_NAME);

        /// <summary>
        /// 摘要(※受取手形)
        /// </summary>
        public static readonly BillsRecivableConstants BILLS_RECIVABLE_SUMMARY = new BillsRecivableConstants(NameColumnIdentifierConstants.SUMMARY, CodeColumnIdentifierConstants.SUMMARY_UT14);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private BillsRecivableConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
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

        /// <summary>
        /// 受取手形で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>預貯金で扱う識別子の一覧</returns>
        public HashSet<BillsRecivableConstants> GetColumnIdentifiers()
        {
            return BILLS_RECIVABLE_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 受取手形で固定
            return ImportCategoryConstants.BILLS_RECIVABLE;
        }
    }
}