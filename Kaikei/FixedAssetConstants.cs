using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 固定資産で扱う識別子を定義するクラス
    /// </summary>
    public class FixedAssetConstants : IColumnIdentifier<FixedAssetConstants>
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
        /// 固定資産で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<FixedAssetConstants> FIXED_ASSET_IDENTIFIER_SET = new HashSet<FixedAssetConstants>()
        {
            TYPE_CONSTRUCTION,
            PROPERTY_LOCATION,
            USE,
            AREA,
            FIXED_ASSET_PERIOD_END_HIGH,
            FIXED_ASSET_YEAR_OF_CHANGE,
            FIXED_ASSET_MONTH_OF_CHANGE,
            FIXED_ASSET_DAY_OF_CHANGE,
            FIXED_ASSET_REASON_OF_TRANSFER,
            PRICE,
            PREVIOUS_BOOK_VALUE,
            PROPERTY_ACQUISITION_YEAR_NUMBER,
            PROPERTY_ACQUISITION_YEAR,
            PROPERTY_ACQUISITION_MONTH,
            FIXED_ASSET_BUSINESS_PARTNER_NAME,
            FIXED_ASSET_BUSINESS_PARTNER_LOCATION
        };

        /// <summary>
        /// 種類・構造
        /// </summary>
        public static readonly FixedAssetConstants TYPE_CONSTRUCTION = new FixedAssetConstants(NameColumnIdentifierConstants.TYPE_CONSTRUCTION, CodeColumnIdentifierConstants.TYPE_CONSTRUCTION);

        /// <summary>
        /// 物件の所在地
        /// </summary>
        public static readonly FixedAssetConstants PROPERTY_LOCATION = new FixedAssetConstants(NameColumnIdentifierConstants.PROPERTY_LOCATION, CodeColumnIdentifierConstants.PROPERTY_LOCATION);

        /// <summary>
        /// 用途
        /// </summary>
        public static readonly FixedAssetConstants USE = new FixedAssetConstants(NameColumnIdentifierConstants.USE, CodeColumnIdentifierConstants.USE);

        /// <summary>
        /// 面積
        /// </summary>
        public static readonly FixedAssetConstants AREA = new FixedAssetConstants(NameColumnIdentifierConstants.AREA, CodeColumnIdentifierConstants.AREA);

        /// <summary>
        /// 期末現在高(固定資産)
        /// </summary>
        public static readonly FixedAssetConstants FIXED_ASSET_PERIOD_END_HIGH = new FixedAssetConstants(NameColumnIdentifierConstants.PERIOD_END_HIGH, CodeColumnIdentifierConstants.PERIOD_END_HIGH_KS05);

        /// <summary>
        /// 異動年月日（年）(※固定資産)
        /// </summary>
        public static readonly FixedAssetConstants FIXED_ASSET_YEAR_OF_CHANGE = new FixedAssetConstants(NameColumnIdentifierConstants.YEAR_OF_CHANGE, CodeColumnIdentifierConstants.YEAR_OF_CHANGE_KS06);

        /// <summary>
        /// 異動年月日（月）(※固定資産)
        /// </summary>
        public static readonly FixedAssetConstants FIXED_ASSET_MONTH_OF_CHANGE = new FixedAssetConstants(NameColumnIdentifierConstants.MONTH_OF_CHANGE, CodeColumnIdentifierConstants.MONTH_OF_CHANGE_KS07);

        /// <summary>
        /// 異動年月日（日）(※固定資産)
        /// </summary>
        public static readonly FixedAssetConstants FIXED_ASSET_DAY_OF_CHANGE = new FixedAssetConstants(NameColumnIdentifierConstants.DAY_OF_CHANGE, CodeColumnIdentifierConstants.DAY_OF_CHANGE_KS08);

        /// <summary>
        /// 異動事由(※固定資産)
        /// </summary>
        public static readonly FixedAssetConstants FIXED_ASSET_REASON_OF_TRANSFER = new FixedAssetConstants(NameColumnIdentifierConstants.REASON_OF_TRANSFER, CodeColumnIdentifierConstants.REASON_OF_TRANSFER_KS09);

        /// <summary>
        /// 価格
        /// </summary>
        public static readonly FixedAssetConstants PRICE = new FixedAssetConstants(NameColumnIdentifierConstants.PRICE, CodeColumnIdentifierConstants.PRICE);

        /// <summary>
        /// 直前帳簿価額
        /// </summary>
        public static readonly FixedAssetConstants PREVIOUS_BOOK_VALUE = new FixedAssetConstants(NameColumnIdentifierConstants.PREVIOUS_BOOK_VALUE, CodeColumnIdentifierConstants.PREVIOUS_BOOK_VALUE);

        /// <summary>
        /// 物件取得年月（年号）
        /// </summary>
        public static readonly FixedAssetConstants PROPERTY_ACQUISITION_YEAR_NUMBER = new FixedAssetConstants(NameColumnIdentifierConstants.PROPERTY_ACQUISITION_YEAR_NUMBER, CodeColumnIdentifierConstants.PROPERTY_ACQUISITION_YEAR_NUMBER);

        /// <summary>
        /// 物件取得年月（年）
        /// </summary>
        public static readonly FixedAssetConstants PROPERTY_ACQUISITION_YEAR = new FixedAssetConstants(NameColumnIdentifierConstants.PROPERTY_ACQUISITION_YEAR, CodeColumnIdentifierConstants.PROPERTY_ACQUISITION_YEAR);

        /// <summary>
        /// 物件取得年月（月）
        /// </summary>
        public static readonly FixedAssetConstants PROPERTY_ACQUISITION_MONTH = new FixedAssetConstants(NameColumnIdentifierConstants.PROPERTY_ACQUISITION_MONTH, CodeColumnIdentifierConstants.PROPERTY_ACQUISITION_MONTH);

        /// <summary>
        /// 取引先の名称（氏名）(※固定資産)
        /// </summary>
        public static readonly FixedAssetConstants FIXED_ASSET_BUSINESS_PARTNER_NAME = new FixedAssetConstants(NameColumnIdentifierConstants.BUSINESS_PARTNER_NAME, CodeColumnIdentifierConstants.BUSINESS_PARTNER_NAME_KS15);

        /// <summary>
        /// 取引先の所在地（住所）(※固定資産)
        /// </summary>
        public static readonly FixedAssetConstants FIXED_ASSET_BUSINESS_PARTNER_LOCATION = new FixedAssetConstants(NameColumnIdentifierConstants.BUSINESS_PARTNER_LOCATION, CodeColumnIdentifierConstants.BUSINESS_PARTNER_LOCATION_KS16);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private FixedAssetConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 固定資産で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>固定資産で扱う識別子の一覧</returns>
        public HashSet<FixedAssetConstants> GetColumnIdentifiers()
        {
            return FIXED_ASSET_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            return ImportCategoryConstants.FIXED_ASSET;
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
