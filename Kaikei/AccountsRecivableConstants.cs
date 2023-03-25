using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 売掛金・未収入金で扱う識別子を定義するクラス
    /// </summary>
    class AccountsRecivableConstants : IColumnIdentifier<AccountsRecivableConstants>
    {
        /// <summary>
        /// 項目名
        /// </summary>
        private String identifierName;

        /// <summary>
        /// 識別子
        /// </summary>
        private String identifierCode;

        /// <summary>
        /// 売掛金・未収入金で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<AccountsRecivableConstants> ACCOUNTS_RECIVABLE_IDENTIFIER_SET = new HashSet<AccountsRecivableConstants>()
        {
            ACCOUNTS_RECIVABLE_SUBJECTS,
            ACCOUNTS_RECIVABLE_CUSTOMER_NAME,
            ACCOUNTS_RECIVABLE_CUSTOMER_LOCATION,
            ACCOUNTS_RECIVABLE_PERIOD_END_HIGH,
            ACCOUNTS_RECIVABLE_SUMMARY
        };

        /// <summary>
        /// 科目
        /// </summary>
        public static readonly AccountsRecivableConstants ACCOUNTS_RECIVABLE_SUBJECTS = new AccountsRecivableConstants(NameColumnIdentifierConstants.SUBJECTS, CodeColumnIdentifierConstants.SUBJECTS_UR01);

        /// <summary>
        /// 相手先名称(氏名)
        /// </summary>
        public static readonly AccountsRecivableConstants ACCOUNTS_RECIVABLE_CUSTOMER_NAME = new AccountsRecivableConstants(NameColumnIdentifierConstants.CUSTOMER_NAME, CodeColumnIdentifierConstants.CUSTOMER_NAME_UR02);

        /// <summary>
        /// 相手先所在地(住所)
        /// </summary>
        public static readonly AccountsRecivableConstants ACCOUNTS_RECIVABLE_CUSTOMER_LOCATION = new AccountsRecivableConstants(NameColumnIdentifierConstants.CUSTOMER_LOCATION, CodeColumnIdentifierConstants.CUSTOMER_LOCATION_UR03);

        /// <summary>
        /// 期末現在高(※売掛金・未収入金)
        /// </summary>
        public static readonly AccountsRecivableConstants ACCOUNTS_RECIVABLE_PERIOD_END_HIGH = new AccountsRecivableConstants(NameColumnIdentifierConstants.PERIOD_END_HIGH, CodeColumnIdentifierConstants.PERIOD_END_HIGH_UR04);

        /// <summary>
        /// 摘要(※売掛金・未収入金)
        /// </summary>
        public static readonly AccountsRecivableConstants ACCOUNTS_RECIVABLE_SUMMARY = new AccountsRecivableConstants(NameColumnIdentifierConstants.SUMMARY, CodeColumnIdentifierConstants.SUMMARY_UR05);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private AccountsRecivableConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 売掛金・未収入金で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>売掛金・未収入金で扱う識別子の一覧</returns>
        public HashSet<AccountsRecivableConstants> GetColumnIdentifiers()
        {
            return ACCOUNTS_RECIVABLE_IDENTIFIER_SET;
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
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 売掛金・未収入金で固定
            return ImportCategoryConstants.ACCOUNTS_RECEIVABLE;
        }
    }
}