using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 有価証券で扱う識別子を定義するクラス
    /// </summary>
    public class SecuritiesConstants : IColumnIdentifier<SecuritiesConstants>
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
        private static readonly HashSet<SecuritiesConstants> SECURITIES_IDENTIFIER_SET = new HashSet<SecuritiesConstants>()
        {
            SECURITIES_DIVISION,
            BRAND_NAME,
            FINAL_QUANTITY,
            FINAL_QUANTITY_UNIT,
            PRE_MARKET_VALUE_BOOK_VALUE,
            SECURITIES_AMOUNT_OF_MONEY,
            SECURITIES_YEAR_OF_CHANGE,
            SECURITIES_MONTH_OF_CHANGE,
            SECURITIES_DAY_OF_CHANGE,
            SECURITIES_REASON_OF_TRANSFER,
            CHANGE_DUARING_THE_TERM_AND_QUANTITY,
            QUANTITY_UNIT,
            CHANGE_DUARING_THE_TERM_AND_AMOUNT_OF_MONEY,
            SECURITIES_BUSINESS_PARTNER_NAME,
            SECURITIES_BUSINESS_PARTNER_LOCATION,
            SECURITIES_SUMMARY
        };

        /// <summary>
        /// 区分(※有価証券)
        /// </summary>
        public static readonly SecuritiesConstants SECURITIES_DIVISION = new SecuritiesConstants(NameColumnIdentifierConstants.DIVISION, CodeColumnIdentifierConstants.DIVISION_YS01);

        /// <summary>
        /// 種類・銘柄
        /// </summary>
        public static readonly SecuritiesConstants BRAND_NAME = new SecuritiesConstants(NameColumnIdentifierConstants.BRAND_NAME, CodeColumnIdentifierConstants.BRAND_NAME);

        /// <summary>
        /// 期末数量
        /// </summary>
        public static readonly SecuritiesConstants FINAL_QUANTITY = new SecuritiesConstants(NameColumnIdentifierConstants.FINAL_QUANTITY, CodeColumnIdentifierConstants.FINAL_QUANTITY);

        /// <summary>
        /// 期末数量（単位）
        /// </summary>
        public static readonly SecuritiesConstants FINAL_QUANTITY_UNIT = new SecuritiesConstants(NameColumnIdentifierConstants.FINAL_QUANTITY_UNIT, CodeColumnIdentifierConstants.FINAL_QUANTITY_UNIT);

        /// <summary>
        /// 時価評価前薄価
        /// </summary>
        public static readonly SecuritiesConstants PRE_MARKET_VALUE_BOOK_VALUE = new SecuritiesConstants(NameColumnIdentifierConstants.PRE_MARKET_VALUE_BOOK_VALUE, CodeColumnIdentifierConstants.PRE_MARKET_VALUE_BOOK_VALUE);

        /// <summary>
        /// 金額(※有価証券)
        /// </summary>
        public static readonly SecuritiesConstants SECURITIES_AMOUNT_OF_MONEY = new SecuritiesConstants(NameColumnIdentifierConstants.AMOUNT_OF_MONEY, CodeColumnIdentifierConstants.AMOUNT_OF_MONEY_YS06);

        /// <summary>
        /// 異動年月日（年）(※有価証券)
        /// </summary>
        public static readonly SecuritiesConstants SECURITIES_YEAR_OF_CHANGE = new SecuritiesConstants(NameColumnIdentifierConstants.YEAR_OF_CHANGE, CodeColumnIdentifierConstants.YEAR_OF_CHANGE_YS07);

        /// <summary>
        /// 異動年月日（月）(※有価証券)
        /// </summary>
        public static readonly SecuritiesConstants SECURITIES_MONTH_OF_CHANGE = new SecuritiesConstants(NameColumnIdentifierConstants.MONTH_OF_CHANGE, CodeColumnIdentifierConstants.MONTH_OF_CHANGE_YS08);

        /// <summary>
        /// 異動年月日（日）(※有価証券)
        /// </summary>
        public static readonly SecuritiesConstants SECURITIES_DAY_OF_CHANGE = new SecuritiesConstants(NameColumnIdentifierConstants.DAY_OF_CHANGE, CodeColumnIdentifierConstants.DAY_OF_CHANGE_YS09);

        /// <summary>
        /// 異動事由
        /// </summary>
        public static readonly SecuritiesConstants SECURITIES_REASON_OF_TRANSFER = new SecuritiesConstants(NameColumnIdentifierConstants.REASON_OF_TRANSFER, CodeColumnIdentifierConstants.REASON_OF_TRANSFER_YS10);

        /// <summary>
        /// 期中異動・数量
        /// </summary>
        public static readonly SecuritiesConstants CHANGE_DUARING_THE_TERM_AND_QUANTITY = new SecuritiesConstants(NameColumnIdentifierConstants.CHANGE_DUARING_THE_TERM_AND_QUANTITY, CodeColumnIdentifierConstants.CHANGE_DUARING_THE_TERM_AND_QUANTITY);

        /// <summary>
        /// 数量（単位）
        /// </summary>
        public static readonly SecuritiesConstants QUANTITY_UNIT = new SecuritiesConstants(NameColumnIdentifierConstants.QUANTITY_UNIT, CodeColumnIdentifierConstants.QUANTITY_UNIT);

        /// <summary>
        /// 期中異動（金額）
        /// </summary>
        public static readonly SecuritiesConstants CHANGE_DUARING_THE_TERM_AND_AMOUNT_OF_MONEY = new SecuritiesConstants(NameColumnIdentifierConstants.CHANGE_DUARING_THE_TERM_AND_AMOUNT_OF_MONEY, CodeColumnIdentifierConstants.CHANGE_DUARING_THE_TERM_AND_AMOUNT_OF_MONEY);

        /// <summary>
        /// 取引先の名称（氏名）(※有価証券)
        /// </summary>
        public static readonly SecuritiesConstants SECURITIES_BUSINESS_PARTNER_NAME = new SecuritiesConstants(NameColumnIdentifierConstants.BUSINESS_PARTNER_NAME, CodeColumnIdentifierConstants.BUSINESS_PARTNER_NAME_YS14);

        /// <summary>
        /// 取引先の所在地（住所）(※有価証券)
        /// </summary>
        public static readonly SecuritiesConstants SECURITIES_BUSINESS_PARTNER_LOCATION = new SecuritiesConstants(NameColumnIdentifierConstants.BUSINESS_PARTNER_LOCATION, CodeColumnIdentifierConstants.BUSINESS_PARTNER_LOCATION_YS15);

        /// <summary>
        /// 摘要(※有価証券)
        /// </summary>
        public static readonly SecuritiesConstants SECURITIES_SUMMARY = new SecuritiesConstants(NameColumnIdentifierConstants.SUMMARY, CodeColumnIdentifierConstants.SUMMARY_YS16);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private SecuritiesConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 有価証券で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>有価証券で扱う識別子の一覧</returns>
        public HashSet<SecuritiesConstants> GetColumnIdentifiers()
        {
            return SECURITIES_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 有価証券で固定
            return ImportCategoryConstants.SECURITIES;
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