using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 全識別子(コード)の定義クラス
    /// (※)種別ごとに定義場所の変更を検討中
    /// </summary>
   public class CodeColumnIdentifierConstants
    {
        /// <summary>
        /// 金融機関名
        /// </summary>
        public static readonly String FINANTIAL_INSTITUTION_NAME = "YK01";

        /// <summary>
        /// 支店名(YK02)
        /// </summary>
        public static readonly String BRANCH_NAME_YK02 = "YK02";

        /// <summary>
        /// 預貯金種類
        /// </summary>
        public static readonly String DEPOSIT_TYPE = "YK03";

        /// <summary>
        /// 口座番号
        /// </summary>
        public static readonly String ACCOUNT_NUMBER = "YK04";

        /// <summary>
        /// 期末現在高
        /// </summary>
        public static readonly String PERIOD_END_HIGH = "YK05";

        /// <summary>
        /// 摘要(YK06)
        /// </summary>
        public static readonly String SUMMARY_YK06 = "YK06";

        /// <summary>
        /// 区分
        /// </summary>
        public static readonly String DIVISION_UT01 = "UT01";

        /// <summary>
        /// 振出人
        /// </summary>
        public static readonly String PICKER = "UT02";

        /// <summary>
        /// 振出年
        /// </summary>
        public static readonly String YEAR_OF_WRITING = "UT03";

        /// <summary>
        /// 振出月
        /// </summary>
        public static readonly String MONTH_OF_WRITING = "UT04";

        /// <summary>
        /// 振出日
        /// </summary>
        public static readonly String DAY_OF_WRITING = "UT05";

        /// <summary>
        /// 支払年
        /// </summary>
        public static readonly String PAYMENT_YEAR = "UT06";

        /// <summary>
        /// 支払月
        /// </summary>
        public static readonly String PAYMENT_MONTH = "UT07";

        /// <summary>
        /// 支払日
        /// </summary>
        public static readonly String PAYMENT_DAY = "UT08";

        /// <summary>
        /// 支払銀行名(UT09)
        /// </summary>
        public static readonly String PAYMENT_BANK_NAME_UT09 = "UT09";

        /// <summary>
        /// 支払銀行支店名
        /// </summary>
        public static readonly String PAYMENT_BANK__BRANCH_NAME = "UT10";

        /// <summary>
        /// 金額(UT11)
        /// </summary>
        public static readonly String AMOUNT_OF_MONEY_UT11 = "UT11";

        /// <summary>
        /// 割引銀行名
        /// </summary>
        public static readonly String DISCOUNTED_BANK_NAME = "UT12";

        /// <summary>
        /// 割引銀行支店名
        /// </summary>
        public static readonly String DISCOUNTED_BANK_BRANCH_NAME = "UT13";

        /// <summary>
        /// 摘要(UT14)
        /// </summary>
        public static readonly String SUMMARY_UT14 = "UT14";

        /// <summary>
        /// 科目(UR01)
        /// </summary>
        public static readonly String SUBJECTS_UR01 = "UR01";

        /// <summary>
        /// 相手先名称(UR02)
        /// </summary>
        public static readonly String CUSTOMER_NAME_UR02 = "UR02";

        /// <summary>
        /// 相手先所在地(UR03)
        /// </summary>
        public static readonly String CUSTOMER_LOCATION_UR03 = "UR03";

        /// <summary>
        /// 期末現在高(UR04)
        /// </summary>
        public static readonly String PERIOD_END_HIGH_UR04 = "UR04";

        /// <summary>
        /// 摘要(UR05)
        /// </summary>
        public static readonly String SUMMARY_UR05 = "UR05";

        /// <summary>
        /// 科目(RB01)
        /// </summary>
        public static readonly String SUBJECTS_RB01 = "RB01";

        /// <summary>
        /// 相手先名称(RB02)
        /// </summary>
        public static readonly String CUSTOMER_NAME_RB02 = "RB02";

        /// <summary>
        /// 相手先所在地(RB03)
        /// </summary>
        public static readonly String CUSTOMER_LOCATION_RB03 = "RB03";

        /// <summary>
        /// 関係(RB04)
        /// </summary>
        public static readonly String RELATIONSHIP_RB04 = "RB04";

        /// <summary>
        /// 期末現在高(RB05)
        /// </summary>
        public static readonly String PERIOD_END_HIGH_RB05 = "RB05";

        /// <summary>
        /// 取引の内容(RB06)
        /// </summary>
        public static readonly String TRANSACTION_CONTENT_RB06 = "RB06";

        /// <summary>
        /// 貸付先
        /// </summary>
        public static readonly String LENDER = "KT01";

        /// <summary>
        /// 貸付先所在地
        /// </summary>
        public static readonly String LOAN_LOCATION = "KT02";

        /// <summary>
        /// 関係(KT03)
        /// </summary>
        public static readonly String RELATIONSHIP_KT03 = "KT03";

        /// <summary>
        /// 期末現在高(KT04)
        /// </summary>
        public static readonly String PERIOD_END_HIGH_KT04 = "KT04";
        
        /// <summary>
        /// 受取利息額
        /// </summary>
        public static readonly String INTEREST_INCOME_AMOUNT = "KT05";

        /// <summary>
        /// 利息額
        /// </summary>
        public static readonly String INTEREST = "KT06";

        /// <summary>
        /// 貸付理由
        /// </summary>
        public static readonly String REASON_FOR_LOAN = "KT07";

        /// <summary>
        /// 担保の内容(KT08)
        /// </summary>
        public static readonly String CONTENTS_OF_COLLATERAL_KT08 = "KT08";

        /// <summary>
        /// 科目(TN01)
        /// </summary>
        public static readonly String SUBJECTS_TN01 = "TN01";

        /// <summary>
        /// 品目
        /// </summary>
        public static readonly String ITEM = "TN02";

        /// <summary>
        /// 数量
        /// </summary>
        public static readonly String QUANTITY = "TN03";

        /// <summary>
        /// 単位
        /// </summary>
        public static readonly String UNIT = "TN04";

        /// <summary>
        /// 単価
        /// </summary>
        public static readonly String UNIT_PRICE = "TN05";

        /// <summary>
        /// 期末現在高(TN06)
        /// </summary>
        public static readonly String PERIOD_END_HIGH_TN06 = "TN06";

        /// <summary>
        /// 摘要(TN07)
        /// </summary>
        public static readonly String SUMMARY_TN07 = "TN07";

        /// <summary>
        /// 区分(YS01)
        /// </summary>
        public static readonly String DIVISION_YS01 = "YS01";

        /// <summary>
        /// 銘柄(YS02)
        /// </summary>
        public static readonly String BRAND_NAME = "YS02";

        /// <summary>
        /// 期末数量
        /// </summary>
        public static readonly String FINAL_QUANTITY = "YS03";

        /// <summary>
        /// 期末数量（単位）
        /// </summary>
        public static readonly String FINAL_QUANTITY_UNIT = "YS04";

        /// <summary>
        /// 時価評価前薄価
        /// </summary>
        public static readonly String PRE_MARKET_VALUE_BOOK_VALUE = "YS05";

        /// <summary>
        /// 金額
        /// </summary>
        public static readonly String AMOUNT_OF_MONEY_YS06 = "YS06";

        /// <summary>
        /// 異動年月日（年）(YS07)
        /// </summary>
        public static readonly String YEAR_OF_CHANGE_YS07 = "YS07";

        /// <summary>
        /// 異動年月日（月）(YS08)
        /// </summary>
        public static readonly String MONTH_OF_CHANGE_YS08 = "YS08";

        /// <summary>
        /// 異動年月日（日）(YS09)
        /// </summary>
        public static readonly String DAY_OF_CHANGE_YS09 = "YS09";

        /// <summary>
        /// 異動事由(YS10)
        /// </summary>
        public static readonly String REASON_OF_TRANSFER_YS10 = "YS10";

        /// <summary>
        /// 期中異動・数量
        /// </summary>
        public static readonly String CHANGE_DUARING_THE_TERM_AND_QUANTITY = "YS11";

        /// <summary>
        /// 数量（単位）
        /// </summary>
        public static readonly String QUANTITY_UNIT = "YS12";

        /// <summary>
        /// 期中異動・金額
        /// </summary>
        public static readonly String CHANGE_DUARING_THE_TERM_AND_AMOUNT_OF_MONEY = "YS13";

        /// <summary>
        /// 取得先の名称(YS14)
        /// </summary>
        public static readonly String BUSINESS_PARTNER_NAME_YS14 = "YS14";

        /// <summary>
        /// 取得先の所在地(YS15)
        /// </summary>
        public static readonly String BUSINESS_PARTNER_LOCATION_YS15 = "YS15";

        /// <summary>
        /// 摘要(YS16)
        /// </summary>
        public static readonly String SUMMARY_YS16 = "YS16";

        /// <summary>
        /// 種類・構造
        /// </summary>
        public static readonly String TYPE_CONSTRUCTION = "KS01";

        /// <summary>
        /// 物件の所在地
        /// </summary>
        public static readonly String PROPERTY_LOCATION = "KS02";

        /// <summary>
        /// 用途
        /// </summary>
        public static readonly String USE = "KS03";

        /// <summary>
        /// 面積
        /// </summary>
        public static readonly String AREA = "KS04";

        /// <summary>
        /// 期末現在高(KS05)
        /// </summary>
        public static readonly String PERIOD_END_HIGH_KS05 = "KS05";

        /// <summary>
        /// 異動年月日（年）(KS06)
        /// </summary>
        public static readonly String YEAR_OF_CHANGE_KS06 = "KS06";

        /// <summary>
        /// 異動年月日（月）(KS07)
        /// </summary>
        public static readonly String MONTH_OF_CHANGE_KS07 = "KS07";

        /// <summary>
        /// 異動年月日（日）(KS08)
        /// </summary>
        public static readonly String DAY_OF_CHANGE_KS08 = "KS08";

        /// <summary>
        /// 異動事由(KS09)
        /// </summary>
        public static readonly String REASON_OF_TRANSFER_KS09 = "KS09";

        /// <summary>
        /// 価額
        /// </summary>
        public static readonly String PRICE = "KS10";

        /// <summary>
        /// 直前帳簿価額(KS11)
        /// </summary>
        public static readonly String PREVIOUS_BOOK_VALUE = "KS11";

        /// <summary>
        /// 物件取得年月（年号）(KS12)
        /// </summary>
        public static readonly String PROPERTY_ACQUISITION_YEAR_NUMBER = "KS12";

        /// <summary>
        /// 物件取得年月（年）(KS13)
        /// </summary>
        public static readonly String PROPERTY_ACQUISITION_YEAR = "KS13";

        /// <summary>
        /// 物件取得年月（月）(KS14)
        /// </summary>
        public static readonly String PROPERTY_ACQUISITION_MONTH = "KS14";

        /// <summary>
        /// 取得先の名称(KS15)
        /// </summary>
        public static readonly String BUSINESS_PARTNER_NAME_KS15 = "KS15";

        /// <summary>
        /// 取得先の所在地(KS16)
        /// </summary>
        public static readonly String BUSINESS_PARTNER_LOCATION_KS16 = "KS16";

        /// <summary>
        /// 支払先
        /// </summary>
        public static readonly String PAYMENT_DESTINATION = "ST01";

        /// <summary>
        /// 振出年月日（年）
        /// </summary>
        public static readonly String YEAR_OF_REFERENCE = "ST02";

        /// <summary>
        /// 振出年月日（月）
        /// </summary>
        public static readonly String MONTH_OF_REFERENCE = "ST03";

        /// <summary>
        /// 振出年月日（日）
        /// </summary>
        public static readonly String DAY_OF_REFERENCE = "ST04";

        /// <summary>
        /// 支払期日（年）
        /// </summary>
        public static readonly String PAYMENT_TERM_YEAR = "ST05";

        /// <summary>
        /// 支払期日（月）
        /// </summary>
        public static readonly String PAYMENT_TERM_MONTH = "ST06";

        /// <summary>
        /// 支払期日（日）
        /// </summary>
        public static readonly String PAYMENT_TERM_DAY = "ST07";

        /// <summary>
        /// 支払銀行名(ST08)
        /// </summary>
        public static readonly String PAYMENT_BANK_NAME_ST08 = "ST08";

        /// <summary>
        /// 支店名(ST09)
        /// </summary>
        public static readonly String BRANCH_NAME_ST09 = "ST09";

        /// <summary>
        /// 金額(ST10)
        /// </summary>
        public static readonly String AMOUNT_OF_MONEY_ST10 = "ST10";

        /// <summary>
        /// 摘要(ST11)
        /// </summary>
        public static readonly String SUMMARY_ST11 = "ST11";

        /// <summary>
        /// 科目(MH01)
        /// </summary>
        public static readonly String SUBJECTS_MH01 = "MH01";

        /// <summary>
        /// 相手先名称(MH02)
        /// </summary>
        public static readonly String CUSTOMER_NAME_MH02 = "MH02";

        /// <summary>
        /// 相手先所在地(MH03)
        /// </summary>
        public static readonly String CUSTOMER_LOCATION_MH03 = "MH03";

        /// <summary>
        /// 期末現在高(MH04)
        /// </summary>
        public static readonly String PERIOD_END_HIGH_MS04 = "MH04";

        /// <summary>
        /// 摘要(MH05)
        /// </summary>
        public static readonly String SUMMARY_MH05 = "MH05";

        /// <summary>
        /// 科目(RU01)
        /// </summary>
        public static readonly String SUBJECTS_RU01 = "RU01";

        /// <summary>
        /// 名称（氏名）
        /// </summary>
        public static readonly String NAME = "RU02";

        /// <summary>
        /// 所在地（住所）(RU03)
        /// </summary>
        public static readonly String ADDRESS_RU03 = "RU03";

        /// <summary>
        /// 関係(RU04)
        /// </summary>
        public static readonly String RELATIONSHIP_RU04 = "RU04";

        /// <summary>
        /// 期末現在高(RU05)
        /// </summary>
        public static readonly String PERIOD_END_HIGH_RU05 = "RU05";

        /// <summary>
        /// 取引の内容(RU06)
        /// </summary>
        public static readonly String TRANSACTION_CONTENT_RU06 = "RU06";

        /// <summary>
        /// 区分(SK01)
        /// </summary>
        public static readonly String DIVISION_SK01 = "SK01";

        /// <summary>
        /// 借入先
        /// </summary>
        public static readonly String BORROWER = "SK02";

        /// <summary>
        /// 所在地（住所）(SK03)
        /// </summary>
        public static readonly String ADDRESS_SK03 = "SK03";

        /// <summary>
        /// 関係(SK04)
        /// </summary>
        public static readonly String RELATIONSHIP_SK04 = "SK04";

        /// <summary>
        /// 期末現在高(SK05)
        /// </summary>
        public static readonly String PERIOD_END_HIGH_SK05 = "SK05";

        /// <summary>
        /// 支払利子額
        /// </summary>
        public static readonly String INTEREST_PAID = "SK06";

        /// <summary>
        /// 利率
        /// </summary>
        public static readonly String INTEREST_RATE = "SK07";

        /// <summary>
        /// 借入理由
        /// </summary>
        public static readonly String REASON_FOR_BORROWING = "SK08";

        /// <summary>
        /// 担保の内容(SK09)
        /// </summary>
        public static readonly String CONTENTS_OF_COLLATERAL_SK09 = "SK09";

        /// <summary>
        /// 区分(TOU01)
        /// </summary>
        public static readonly String DIVISION_TOU01 = "TOU01";

        /// <summary>
        /// 商品の所在地
        /// </summary>
        public static readonly String PRODUCT_LOCATION = "TOU02";

        /// <summary>
        /// 地目
        /// </summary>
        public static readonly String GROUND = "TOU03";

        /// <summary>
        /// 総面積
        /// </summary>
        public static readonly String TOTAL_EREA = "TOU04";

        /// <summary>
        /// 売上年月（年）
        /// </summary>
        public static readonly String YEAR_OF_SALES = "TOU05";

        /// <summary>
        /// 売上年月（月）
        /// </summary>
        public static readonly String MONTH_OF_SALES = "TOU06";

        /// <summary>
        /// 商品取得年（年号）
        /// </summary>
        public static readonly String PRODUCT_ACQUISITION_YEAR_NUMBER = "TOU07";

        /// <summary>
        /// 商品取得年（年）
        /// </summary>
        public static readonly String PRODUCT_ACQUISITION_YEAR = "TOU08";

        /// <summary>
        /// 売上先
        /// </summary>
        public static readonly String SALES_DESTINATION = "TOU09";

        /// <summary>
        /// 売上先住所
        /// </summary>
        public static readonly String SALES_ADDRESS = "TOU10";

        /// <summary>
        /// 売上面積
        /// </summary>
        public static readonly String SALES_AREA = "TOU11";

        /// <summary>
        /// 売上金額
        /// </summary>
        public static readonly String SALES_AMOUNT = "TOU12";

        /// <summary>
        /// 仲介手数料
        /// </summary>
        public static readonly String BROKERAGE_FEE = "TOU13";

        /// <summary>
        /// 事業所の名称
        /// </summary>
        public static readonly String NAME_OF_ESTABLISHMENT = "UAG01";

        /// <summary>
        /// 所在地
        /// </summary>
        public static readonly String LOCATION = "UAG02";

        /// <summary>
        /// 責任者氏名
        /// </summary>
        public static readonly String NAME_OF_RESPONSIBLE_PERSON = "UAG03";

        /// <summary>
        /// 関係(UAG04)
        /// </summary>
        public static readonly String RELATIONSHIP_UAG04 = "UAG04";

        /// <summary>
        /// 源泉納付署
        /// </summary>
        public static readonly String SOURCE_PAYMENT_NOTICE = "UAG05";

        /// <summary>
        /// 事業等内容
        /// </summary>
        public static readonly String BUISINESS_CONTENTS = "UAG06";

        /// <summary>
        /// 売上高
        /// </summary>
        public static readonly String AMOUNT_OF_SALES = "UAG07";

        /// <summary>
        /// 期末棚卸高
        /// </summary>
        public static readonly String YEAR_END_INVENTORY_VALUE = "UAG08";

        /// <summary>
        /// 従業員数
        /// </summary>
        public static readonly String NUMBER_OF_EMPLOYEES = "UAG09";

        /// <summary>
        /// 建物延面積
        /// </summary>
        public static readonly String BUILDING_TOTAL_AREA = "UAG10";

        /// <summary>
        /// 摘要(UAG11)
        /// </summary>
        public static readonly String SUMMARY_UAG11 = "UAG11";

        /// <summary>
        /// 役職名
        /// </summary>
        public static readonly String TITLE = "HOS01";

        /// <summary>
        /// 担当業務
        /// </summary>
        public static readonly String WORK_IN_CHARGE = "HSO02";

        /// <summary>
        /// 氏名
        /// </summary>
        public static readonly String NAME_HOS03 = "HOS03";

        /// <summary>
        /// 関係
        /// </summary>
        public static readonly String RELATIONSHIP_HOS04 = "HOS04";

        /// <summary>
        /// 住所
        /// </summary>
        public static readonly String EXECUTIVE_ADDRESS = "HOS05";

        /// <summary>
        /// 常・非
        /// </summary>
        public static readonly String FULLTIME_OR_PARTTIME = "HOS06";

        /// <summary>
        /// 役員給与の内訳使用人職務分
        /// </summary>
        public static readonly String BREAKDOWN_OF_EXECUTIVE_SALARIES = "HOS07";

        /// <summary>
        /// 職務分以外定期同額分
        /// </summary>
        public static readonly String REGULAR_FIXED_AMOUNT_EXCEPT_FOR_DUTIES = "HOS08";

        /// <summary>
        /// 職務分以外事前届出分
        /// </summary>
        public static readonly String PRE_NOTIFIED_MINUTES_OTHER_THAN_DUTIES = "HOS09";

        /// <summary>
        /// 職務分以外利益連動分
        /// </summary>
        public static readonly String NON_PROFIT_SHARE_LINKED_TO_PROFIT = "HOS10";

        /// <summary>
        /// 職務分以外その他
        /// </summary>
        public static readonly String OTHER_THAN_DUTIES = "HOS11";

        /// <summary>
        /// 退職給与
        /// </summary>
        public static readonly String RETIREMENT_SALARY = "HOS12";

        /// <summary>
        /// 人件費総額役員報酬手当
        /// </summary>
        public static readonly String TOTAL_PERSONNEL_COSTS = "HOS13";

        /// <summary>
        /// 人件費総額給与手当
        /// </summary>
        public static readonly String TOTAL_LABOR_COST = "HOS14";

        /// <summary>
        /// 人件費総額賃金手当
        /// </summary>
        public static readonly String TOTAL_LABOR_COST_PAY = "HOS15";

        /// <summary>
        /// 代表者及びその家族役員報酬手当
        /// </summary>
        public static readonly String REPRESENTATIVE_OFFICER_COMPENSATION_ALLOWANCE = "HOS16";

        /// <summary>
        /// 代表者及びその家族役給料手当
        /// </summary>
        public static readonly String REPRESENTATIVE_OFFICER_SALARY_PAY = "HOS17";

        /// <summary>
        /// 代表者及びその家族役員賃金手当
        /// </summary>
        public static readonly String REPRESENTATIVE_OFFICER_PAY = "HOS18";
    }
}
