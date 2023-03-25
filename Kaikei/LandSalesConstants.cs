using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 土地の売上高等で扱う識別子を定義するクラス
    /// </summary>
    public class LandSalesConstants : IColumnIdentifier<LandSalesConstants>
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
        /// 土地の売上高等で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<LandSalesConstants> LAND_SALES_IDENTIFIER_SET = new HashSet<LandSalesConstants>()
        {
            LAND_SALES_DIVISION,
            PRODUCT_LOCATION,
            GROUND,
            TOTAL_EREA,
            YEAR_OF_SALES,
            MONTH_OF_SALES,
            PRODUCT_ACQUISITION_YEAR_NUMBER,
            PRODUCT_ACQUISITION_YEAR,
            SALES_DESTINATION,
            SALES_ADDRESS,
            SALES_AREA,
            SALES_AMOUNT,
            BROKERAGE_FEE
        };

        /// <summary>
        /// 区分(※土地の売上高等)
        /// </summary>
        public static readonly LandSalesConstants LAND_SALES_DIVISION = new LandSalesConstants(NameColumnIdentifierConstants.DIVISION, CodeColumnIdentifierConstants.DIVISION_TOU01);

        /// <summary>
        /// 商品の所在地
        /// </summary>
        public static readonly LandSalesConstants PRODUCT_LOCATION = new LandSalesConstants(NameColumnIdentifierConstants.PRODUCT_LOCATION, CodeColumnIdentifierConstants.PRODUCT_LOCATION);

        /// <summary>
        /// 地目
        /// </summary>
        public static readonly LandSalesConstants GROUND = new LandSalesConstants(NameColumnIdentifierConstants.GROUND, CodeColumnIdentifierConstants.GROUND);

        /// <summary>
        /// 総面積
        /// </summary>
        public static readonly LandSalesConstants TOTAL_EREA = new LandSalesConstants(NameColumnIdentifierConstants.TOTAL_EREA, CodeColumnIdentifierConstants.TOTAL_EREA);

        /// <summary>
        /// 売上年月（年）
        /// </summary>
        public static readonly LandSalesConstants YEAR_OF_SALES = new LandSalesConstants(NameColumnIdentifierConstants.YEAR_OF_SALES, CodeColumnIdentifierConstants.YEAR_OF_SALES);

        /// <summary>
        /// 売上年月（月）
        /// </summary>
        public static readonly LandSalesConstants MONTH_OF_SALES = new LandSalesConstants(NameColumnIdentifierConstants.MONTH_OF_SALES, CodeColumnIdentifierConstants.MONTH_OF_SALES);

        /// <summary>
        /// 商品取得年（年号）
        /// </summary>
        public static readonly LandSalesConstants PRODUCT_ACQUISITION_YEAR_NUMBER = new LandSalesConstants(NameColumnIdentifierConstants.PRODUCT_ACQUISITION_YEAR_NUMBER, CodeColumnIdentifierConstants.PRODUCT_ACQUISITION_YEAR_NUMBER);

        /// <summary>
        /// 商品取得年（年）
        /// </summary>
        public static readonly LandSalesConstants PRODUCT_ACQUISITION_YEAR = new LandSalesConstants(NameColumnIdentifierConstants.PRODUCT_ACQUISITION_YEAR, CodeColumnIdentifierConstants.PRODUCT_ACQUISITION_YEAR);

        /// <summary>
        /// 売上先
        /// </summary>
        public static readonly LandSalesConstants SALES_DESTINATION = new LandSalesConstants(NameColumnIdentifierConstants.SALES_DESTINATION, CodeColumnIdentifierConstants.SALES_DESTINATION);

        /// <summary>
        /// 売上先住所
        /// </summary>
        public static readonly LandSalesConstants SALES_ADDRESS = new LandSalesConstants(NameColumnIdentifierConstants.SALES_ADDRESS, CodeColumnIdentifierConstants.SALES_ADDRESS);

        /// <summary>
        /// 売上面積
        /// </summary>
        public static readonly LandSalesConstants SALES_AREA = new LandSalesConstants(NameColumnIdentifierConstants.SALES_AREA, CodeColumnIdentifierConstants.SALES_AREA);

        /// <summary>
        /// 売上金額
        /// </summary>
        public static readonly LandSalesConstants SALES_AMOUNT = new LandSalesConstants(NameColumnIdentifierConstants.SALES_AMOUNT, CodeColumnIdentifierConstants.SALES_AMOUNT);

        /// <summary>
        /// 仲介手数料
        /// </summary>
        public static readonly LandSalesConstants BROKERAGE_FEE = new LandSalesConstants(NameColumnIdentifierConstants.BROKERAGE_FEE, CodeColumnIdentifierConstants.BROKERAGE_FEE);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private LandSalesConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 土地の売上高等で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>土地の売上高等で扱う識別子の一覧</returns>
        public HashSet<LandSalesConstants> GetColumnIdentifiers()
        {
            return LAND_SALES_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 土地の売上高等で固定
            return ImportCategoryConstants.LAND_SALES;
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