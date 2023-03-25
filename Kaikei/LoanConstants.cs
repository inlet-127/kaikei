using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 貸付金で扱う識別子を定義するクラス
    /// </summary>
    public class LoanConstants : IColumnIdentifier<LoanConstants>
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
        /// 貸付金で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<LoanConstants> LOAN_IDENTIFIER_SET = new HashSet<LoanConstants>()
        {
            LENDER,
            LOAN_LOCATION,
            LOAN_RELATIONSHIP,
            LOAN_PERIOD_END_HIGH,
            INTEREST_INCOME_AMOUNT,
            INTEREST,
            REASON_FOR_LOAN,
            LOAN_CONTENTS_OF_COLLATERAL
        };

        /// <summary>
        /// 貸付先
        /// </summary>
        public static readonly LoanConstants LENDER = new LoanConstants(NameColumnIdentifierConstants.LENDER, CodeColumnIdentifierConstants.LENDER);

        /// <summary>
        /// 貸付先所在地
        /// </summary>
        public static readonly LoanConstants LOAN_LOCATION = new LoanConstants(NameColumnIdentifierConstants.LOAN_LOCATION, CodeColumnIdentifierConstants.LOAN_LOCATION);

        /// <summary>
        /// 関係(※貸付金)
        /// </summary>
        public static readonly LoanConstants LOAN_RELATIONSHIP = new LoanConstants(NameColumnIdentifierConstants.RELATIONSHIP, CodeColumnIdentifierConstants.RELATIONSHIP_KT03);

        /// <summary>
        /// 期末現在高(※貸付金)
        /// </summary>
        public static readonly LoanConstants LOAN_PERIOD_END_HIGH = new LoanConstants(NameColumnIdentifierConstants.PERIOD_END_HIGH, CodeColumnIdentifierConstants.PERIOD_END_HIGH_KT04);

        /// <summary>
        /// 受取利息額
        /// </summary>
        public static readonly LoanConstants INTEREST_INCOME_AMOUNT = new LoanConstants(NameColumnIdentifierConstants.INTEREST_INCOME_AMOUNT, CodeColumnIdentifierConstants.INTEREST_INCOME_AMOUNT);

        /// <summary>
        /// 利率
        /// </summary>
        public static readonly LoanConstants INTEREST = new LoanConstants(NameColumnIdentifierConstants.INTEREST, NameColumnIdentifierConstants.INTEREST);

        /// <summary>
        /// 貸付理由
        /// </summary>
        public static readonly LoanConstants REASON_FOR_LOAN = new LoanConstants(NameColumnIdentifierConstants.REASON_FOR_LOAN, CodeColumnIdentifierConstants.REASON_FOR_LOAN);

        /// <summary>
        /// 担保の内容
        /// </summary>
        public static readonly LoanConstants LOAN_CONTENTS_OF_COLLATERAL = new LoanConstants(NameColumnIdentifierConstants.CONTENTS_OF_COLLATERAL, CodeColumnIdentifierConstants.CONTENTS_OF_COLLATERAL_KT08);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private LoanConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 貸付金で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>貸付金で扱う識別子の一覧</returns>
        public HashSet<LoanConstants> GetColumnIdentifiers()
        {
            return LOAN_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 貸付金で固定
            return ImportCategoryConstants.LOAN;
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
