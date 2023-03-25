using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 役員報酬手当等・人件費で扱う識別子を定義するクラス
    /// </summary>
    public class PersonnelExpensesConstants : IColumnIdentifier<PersonnelExpensesConstants>
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
        /// 役員報酬手当等・人件費で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<PersonnelExpensesConstants> PERSONNEL_EXPENSES_IDENTIFIER_SET = new HashSet<PersonnelExpensesConstants>()
        {
            TITLE,
            WORK_IN_CHARGE,
            NAME,
            RELATIONSHIP,
            EXECUTIVE_ADDRESS,
            FULLTIME_OR_PARTTIME,
            BREAKDOWN_OF_EXECUTIVE_SALARIES,
            REGULAR_FIXED_AMOUNT_EXCEPT_FOR_DUTIES,
            PRE_NOTIFIED_MINUTES_OTHER_THAN_DUTIES,
            NON_PROFIT_SHARE_LINKED_TO_PROFIT,
            OTHER_THAN_DUTIES,
            RETIREMENT_SALARY,
            TOTAL_PERSONNEL_COSTS,
            TOTAL_LABOR_COST,
            TOTAL_LABOR_COST_PAY,
            REPRESENTATIVE_OFFICER_COMPENSATION_ALLOWANCE,
            REPRESENTATIVE_OFFICER_SALARY_PAY,
            REPRESENTATIVE_OFFICER_PAY
        };

        /// <summary>
        /// 役職名
        /// </summary>
        public static readonly PersonnelExpensesConstants TITLE = new PersonnelExpensesConstants(NameColumnIdentifierConstants.TITLE, CodeColumnIdentifierConstants.TITLE);

        /// <summary>
        /// 担当業務
        /// </summary>
        public static readonly PersonnelExpensesConstants WORK_IN_CHARGE = new PersonnelExpensesConstants(NameColumnIdentifierConstants.WORK_IN_CHARGE, CodeColumnIdentifierConstants.WORK_IN_CHARGE);

        /// <summary>
        /// 氏名
        /// </summary>
        public static readonly PersonnelExpensesConstants NAME = new PersonnelExpensesConstants(NameColumnIdentifierConstants.NAME, CodeColumnIdentifierConstants.NAME_HOS03);

        /// <summary>
        /// 関係
        /// </summary>
        public static readonly PersonnelExpensesConstants RELATIONSHIP = new PersonnelExpensesConstants(NameColumnIdentifierConstants.RELATIONSHIP, CodeColumnIdentifierConstants.RELATIONSHIP_HOS04);

        /// <summary>
        /// 住所
        /// </summary>
        public static readonly PersonnelExpensesConstants EXECUTIVE_ADDRESS = new PersonnelExpensesConstants(NameColumnIdentifierConstants.EXECUTIVE_ADDRESS, CodeColumnIdentifierConstants.EXECUTIVE_ADDRESS);

        /// <summary>
        /// 常・非
        /// </summary>
        public static readonly PersonnelExpensesConstants FULLTIME_OR_PARTTIME = new PersonnelExpensesConstants(NameColumnIdentifierConstants.FULLTIME_OR_PARTTIME, CodeColumnIdentifierConstants.FULLTIME_OR_PARTTIME);

        /// <summary>
        /// 役員給与の内訳使用人職務分
        /// </summary>
        public static readonly PersonnelExpensesConstants BREAKDOWN_OF_EXECUTIVE_SALARIES = new PersonnelExpensesConstants(NameColumnIdentifierConstants.BREAKDOWN_OF_EXECUTIVE_SALARIES, CodeColumnIdentifierConstants.BREAKDOWN_OF_EXECUTIVE_SALARIES);

        /// <summary>
        /// 職務分以外定期同額分
        /// </summary>
        public static readonly PersonnelExpensesConstants REGULAR_FIXED_AMOUNT_EXCEPT_FOR_DUTIES = new PersonnelExpensesConstants(NameColumnIdentifierConstants.REGULAR_FIXED_AMOUNT_EXCEPT_FOR_DUTIES, CodeColumnIdentifierConstants.REGULAR_FIXED_AMOUNT_EXCEPT_FOR_DUTIES);

        /// <summary>
        /// 職務分以外事前届出分
        /// </summary>
        public static readonly PersonnelExpensesConstants PRE_NOTIFIED_MINUTES_OTHER_THAN_DUTIES = new PersonnelExpensesConstants(NameColumnIdentifierConstants.PRE_NOTIFIED_MINUTES_OTHER_THAN_DUTIES, CodeColumnIdentifierConstants.PRE_NOTIFIED_MINUTES_OTHER_THAN_DUTIES);

        /// <summary>
        /// 職務分以外利益連動分
        /// </summary>
        public static readonly PersonnelExpensesConstants NON_PROFIT_SHARE_LINKED_TO_PROFIT = new PersonnelExpensesConstants(NameColumnIdentifierConstants.NON_PROFIT_SHARE_LINKED_TO_PROFIT, CodeColumnIdentifierConstants.NON_PROFIT_SHARE_LINKED_TO_PROFIT);

        /// <summary>
        /// 職務分以外その他
        /// </summary>
        public static readonly PersonnelExpensesConstants OTHER_THAN_DUTIES = new PersonnelExpensesConstants(NameColumnIdentifierConstants.OTHER_THAN_DUTIES, CodeColumnIdentifierConstants.OTHER_THAN_DUTIES);

        /// <summary>
        /// 退職給与
        /// </summary>
        public static readonly PersonnelExpensesConstants RETIREMENT_SALARY = new PersonnelExpensesConstants(NameColumnIdentifierConstants.RETIREMENT_SALARY, CodeColumnIdentifierConstants.RETIREMENT_SALARY);

        /// <summary>
        /// 人件費総額役員報酬手当
        /// </summary>
        public static readonly PersonnelExpensesConstants TOTAL_PERSONNEL_COSTS = new PersonnelExpensesConstants(NameColumnIdentifierConstants.TOTAL_PERSONNEL_COSTS, CodeColumnIdentifierConstants.TOTAL_PERSONNEL_COSTS);

        /// <summary>
        /// 人件費総額給与手当
        /// </summary>
        public static readonly PersonnelExpensesConstants TOTAL_LABOR_COST = new PersonnelExpensesConstants(NameColumnIdentifierConstants.TOTAL_LABOR_COST, CodeColumnIdentifierConstants.TOTAL_LABOR_COST);

        /// <summary>
        /// 人件費総額賃金手当
        /// </summary>
        public static readonly PersonnelExpensesConstants TOTAL_LABOR_COST_PAY = new PersonnelExpensesConstants(NameColumnIdentifierConstants.TOTAL_LABOR_COST_PAY, CodeColumnIdentifierConstants.TOTAL_LABOR_COST_PAY);

        /// <summary>
        /// 代表者及びその家族役員報酬手当
        /// </summary>
        public static readonly PersonnelExpensesConstants REPRESENTATIVE_OFFICER_COMPENSATION_ALLOWANCE = new PersonnelExpensesConstants(NameColumnIdentifierConstants.REPRESENTATIVE_OFFICER_COMPENSATION_ALLOWANCE, CodeColumnIdentifierConstants.REPRESENTATIVE_OFFICER_COMPENSATION_ALLOWANCE);

        /// <summary>
        /// 代表者及びその家族役給料手当
        /// </summary>
        public static readonly PersonnelExpensesConstants REPRESENTATIVE_OFFICER_SALARY_PAY = new PersonnelExpensesConstants(NameColumnIdentifierConstants.REPRESENTATIVE_OFFICER_SALARY_PAY, CodeColumnIdentifierConstants.REPRESENTATIVE_OFFICER_SALARY_PAY);

        /// <summary>
        /// 代表者及びその家族役員賃金手当
        /// </summary>
        public static readonly PersonnelExpensesConstants REPRESENTATIVE_OFFICER_PAY = new PersonnelExpensesConstants(NameColumnIdentifierConstants.REPRESENTATIVE_OFFICER_PAY, CodeColumnIdentifierConstants.REPRESENTATIVE_OFFICER_PAY);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private PersonnelExpensesConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 役員報酬手当等・人件費で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>買掛金・未収入金で扱う識別子の一覧</returns>
        public HashSet<PersonnelExpensesConstants> GetColumnIdentifiers()
        {
            return PERSONNEL_EXPENSES_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 役員報酬手当等・人件費で固定
            return ImportCategoryConstants.PERSONNEL_EXPENSES;
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
