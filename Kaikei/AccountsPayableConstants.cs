using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 買掛金・未払金で扱う識別子を定義するクラス
    /// </summary>
    class AccountsPayableConstants : IColumnIdentifier<AccountsPayableConstants>
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
        /// 買掛金・未払金で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<AccountsPayableConstants> ACCOUNTS_PAYABLE_IDENTIFIER_SET = new HashSet<AccountsPayableConstants>()
        {
            ACCOUNTS_PAYABLE_SUBJECTS,
            ACCOUNTS_PAYABLE_CUSTOMER_NAME,
            ACCOUNTS_PAYABLE_CUSTOMER_LOCATION,
            ACCOUNTS_PAYABLE_PERIOD_END_HIGH,
            ACCOUNTS_PAYABLE_SUMMARY
        };

        /// <summary>
        /// 科目(※買掛金)
        /// </summary>
        public static readonly AccountsPayableConstants ACCOUNTS_PAYABLE_SUBJECTS = new AccountsPayableConstants(NameColumnIdentifierConstants.SUBJECTS, CodeColumnIdentifierConstants.SUBJECTS_MH01);

        /// <summary>
        /// 相手先名称（氏名）(※買掛金)
        /// </summary>
        public static readonly AccountsPayableConstants ACCOUNTS_PAYABLE_CUSTOMER_NAME = new AccountsPayableConstants(NameColumnIdentifierConstants.CUSTOMER_NAME, CodeColumnIdentifierConstants.CUSTOMER_NAME_MH02);

        /// <summary>
        /// 相手先所在地（住所）(※買掛金)
        /// </summary>
        public static readonly AccountsPayableConstants ACCOUNTS_PAYABLE_CUSTOMER_LOCATION = new AccountsPayableConstants(NameColumnIdentifierConstants.CUSTOMER_LOCATION, CodeColumnIdentifierConstants.CUSTOMER_LOCATION_MH03);

        /// <summary>
        /// 期末現在高(※買掛金)
        /// </summary>
        public static readonly AccountsPayableConstants ACCOUNTS_PAYABLE_PERIOD_END_HIGH = new AccountsPayableConstants(NameColumnIdentifierConstants.PERIOD_END_HIGH, CodeColumnIdentifierConstants.PERIOD_END_HIGH_MS04);

        /// <summary>
        /// 摘要(※買掛金)
        /// </summary>
        public static readonly AccountsPayableConstants ACCOUNTS_PAYABLE_SUMMARY = new AccountsPayableConstants(NameColumnIdentifierConstants.SUMMARY, CodeColumnIdentifierConstants.SUMMARY_MH05);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private AccountsPayableConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 買掛金・未払金で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>買掛金・未収入金で扱う識別子の一覧</returns>
        public HashSet<AccountsPayableConstants> GetColumnIdentifiers()
        {
            return ACCOUNTS_PAYABLE_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 買掛金・未払金で固定
            return ImportCategoryConstants.ACCOUNTS_PAYABLE;
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