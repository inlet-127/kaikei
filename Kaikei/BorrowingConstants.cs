using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 借入金で扱う識別子を定義するクラス
    /// </summary>
    public class BorrowingConstants : IColumnIdentifier<BorrowingConstants>
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
        /// 借入金で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<BorrowingConstants> BORROWING_IDENTIFIER_SET = new HashSet<BorrowingConstants>()
        {
            BORROWING_DIVISION,
            BORROWER,
            BORROWING_ADDRESS,
            BORROWING_RELATIONSHIP,
            BORROWING_PERIOD_END_HIGH,
            BORROWING_INTEREST_PAID,
            BORROWING_INTEREST_RATE,
            BORROWING_REASON_FOR_BORROWING,
            BORROWING_CONTENTS_OF_COLLATERAL
        };

        /// <summary>
        /// 区分(※借入金)
        /// </summary>
        public static readonly BorrowingConstants BORROWING_DIVISION = new BorrowingConstants(NameColumnIdentifierConstants.DIVISION, CodeColumnIdentifierConstants.DIVISION_SK01);

        /// <summary>
        /// 借入先
        /// </summary>
        public static readonly BorrowingConstants BORROWER = new BorrowingConstants(NameColumnIdentifierConstants.BORROWER, CodeColumnIdentifierConstants.BORROWER);

        /// <summary>
        /// 所在地（住所）(※借入金)
        /// </summary>
        public static readonly BorrowingConstants BORROWING_ADDRESS = new BorrowingConstants(NameColumnIdentifierConstants.ADDRESS, CodeColumnIdentifierConstants.ADDRESS_SK03);

        /// <summary>
        /// 関係(※借入金)
        /// </summary>
        public static readonly BorrowingConstants BORROWING_RELATIONSHIP = new BorrowingConstants(NameColumnIdentifierConstants.RELATIONSHIP, CodeColumnIdentifierConstants.RELATIONSHIP_SK04);

        /// <summary>
        /// 期末現在高(※借入金)
        /// </summary>
        public static readonly BorrowingConstants BORROWING_PERIOD_END_HIGH = new BorrowingConstants(NameColumnIdentifierConstants.PERIOD_END_HIGH, CodeColumnIdentifierConstants.PERIOD_END_HIGH_SK05);

        /// <summary>
        /// 支払利子額(※借入金)
        /// </summary>
        public static readonly BorrowingConstants BORROWING_INTEREST_PAID = new BorrowingConstants(NameColumnIdentifierConstants.INTEREST_PAID, CodeColumnIdentifierConstants.INTEREST_PAID);

        /// <summary>
        /// 利率(※借入金)
        /// </summary>
        public static readonly BorrowingConstants BORROWING_INTEREST_RATE = new BorrowingConstants(NameColumnIdentifierConstants.INTEREST_RATE, CodeColumnIdentifierConstants.INTEREST_RATE);

        /// <summary>
        /// 借入理由(※借入金)
        /// </summary>
        public static readonly BorrowingConstants BORROWING_REASON_FOR_BORROWING = new BorrowingConstants(NameColumnIdentifierConstants.REASON_FOR_BORROWING, CodeColumnIdentifierConstants.REASON_FOR_BORROWING);

        /// <summary>
        /// 担保の内容(※借入金)
        /// </summary>
        public static readonly BorrowingConstants BORROWING_CONTENTS_OF_COLLATERAL = new BorrowingConstants(NameColumnIdentifierConstants.CONTENTS_OF_COLLATERAL, CodeColumnIdentifierConstants.CONTENTS_OF_COLLATERAL_SK09);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private BorrowingConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 借入金で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>借入金で扱う識別子の一覧</returns>
        public HashSet<BorrowingConstants> GetColumnIdentifiers()
        {
            return BORROWING_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 借入金で固定
            return ImportCategoryConstants.BORROWING;
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
