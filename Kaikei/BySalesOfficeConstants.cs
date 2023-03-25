using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 売上高等の事業所別で扱う識別子を定義するクラス
    /// </summary>
    public class BySalesOfficeConstants : IColumnIdentifier<BySalesOfficeConstants>
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
        /// 売上高等の事業所別で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<BySalesOfficeConstants> BY_SALES_OFFICE_IDENTIFIER_SET = new HashSet<BySalesOfficeConstants>()
        {
            NAME_OF_ESTABLISHMENT,
            LOCATION,
            NAME_OF_RESPONSIBLE_PERSON,
            SALES_BY_ESTABLISHMENT_RELATIONSHIP,
            SOURCE_PAYMENT_NOTICE,
            BUISINESS_CONTENTS,
            AMOUNT_OF_SALES,
            YEAR_END_INVENTORY_VALUE,
            NUMBER_OF_EMPLOYEES,
            BUILDING_TOTAL_AREA,
            SALES_BY_ESTABLISHMENT_SUMMARY
        };

        /// <summary>
        /// 事業所の名称
        /// </summary>
        public static readonly BySalesOfficeConstants NAME_OF_ESTABLISHMENT = new BySalesOfficeConstants(NameColumnIdentifierConstants.NAME_OF_ESTABLISHMENT, CodeColumnIdentifierConstants.NAME_OF_ESTABLISHMENT);

        /// <summary>
        /// 所在地
        /// </summary>
        public static readonly BySalesOfficeConstants LOCATION = new BySalesOfficeConstants(NameColumnIdentifierConstants.LOCATION, CodeColumnIdentifierConstants.LOCATION);

        /// <summary>
        /// 責任者氏名
        /// </summary>
        public static readonly BySalesOfficeConstants NAME_OF_RESPONSIBLE_PERSON = new BySalesOfficeConstants(NameColumnIdentifierConstants.NAME_OF_RESPONSIBLE_PERSON, NameColumnIdentifierConstants.NAME_OF_RESPONSIBLE_PERSON);

        /// <summary>
        /// 関係(※売上高等の事業所別)
        /// </summary>
        public static readonly BySalesOfficeConstants SALES_BY_ESTABLISHMENT_RELATIONSHIP = new BySalesOfficeConstants(NameColumnIdentifierConstants.RELATIONSHIP, CodeColumnIdentifierConstants.RELATIONSHIP_UAG04);

        /// <summary>
        /// 源泉納付署
        /// </summary>
        public static readonly BySalesOfficeConstants SOURCE_PAYMENT_NOTICE = new BySalesOfficeConstants(NameColumnIdentifierConstants.SOURCE_PAYMENT_NOTICE, CodeColumnIdentifierConstants.SOURCE_PAYMENT_NOTICE);

        /// <summary>
        /// 事業等内容
        /// </summary>
        public static readonly BySalesOfficeConstants BUISINESS_CONTENTS = new BySalesOfficeConstants(NameColumnIdentifierConstants.BUISINESS_CONTENTS, CodeColumnIdentifierConstants.BUISINESS_CONTENTS);

        /// <summary>
        /// 売上高
        /// </summary>
        public static readonly BySalesOfficeConstants AMOUNT_OF_SALES = new BySalesOfficeConstants(NameColumnIdentifierConstants.AMOUNT_OF_SALES, CodeColumnIdentifierConstants.AMOUNT_OF_SALES);

        /// <summary>
        /// 期末棚卸高
        /// </summary>
        public static readonly BySalesOfficeConstants YEAR_END_INVENTORY_VALUE = new BySalesOfficeConstants(NameColumnIdentifierConstants.YEAR_END_INVENTORY_VALUE, CodeColumnIdentifierConstants.YEAR_END_INVENTORY_VALUE);

        /// <summary>
        /// 従業員数
        /// </summary>
        public static readonly BySalesOfficeConstants NUMBER_OF_EMPLOYEES = new BySalesOfficeConstants(NameColumnIdentifierConstants.NUMBER_OF_EMPLOYEES, CodeColumnIdentifierConstants.NUMBER_OF_EMPLOYEES);

        /// <summary>
        /// 建物延面積
        /// </summary>
        public static readonly BySalesOfficeConstants BUILDING_TOTAL_AREA = new BySalesOfficeConstants(NameColumnIdentifierConstants.BUILDING_TOTAL_AREA, CodeColumnIdentifierConstants.BUILDING_TOTAL_AREA);

        /// <summary>
        /// 摘要(※売上高等の事業所別)
        /// </summary>
        public static readonly BySalesOfficeConstants SALES_BY_ESTABLISHMENT_SUMMARY = new BySalesOfficeConstants(NameColumnIdentifierConstants.SUMMARY, CodeColumnIdentifierConstants.SUMMARY_UAG11);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private BySalesOfficeConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 売上高等の事業所別で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>売上高等の事業所別で扱う識別子の一覧</returns>
        public HashSet<BySalesOfficeConstants> GetColumnIdentifiers()
        {
            return BY_SALES_OFFICE_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 売上高等の事業所別で固定
            return ImportCategoryConstants.BY_SALES_OFFICE;
        }

        /// <summary>
        /// 項目名を取得する
        /// </summary>
        /// <returns>項目名</returns>
        public string GetIdentifierName()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 識別子を取得する
        /// </summary>
        /// <returns>項目名</returns>
        public string GetIdentifierCode()
        {
            throw new NotImplementedException();
        }

    }
}
