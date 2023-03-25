using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 出力データのカテゴリを定義したクラス
    /// </summary>
    public class ImportCategoryConstants {

        /// <summary>
        /// カテゴリ名称
        /// </summary>
        private readonly String categoryName;

        /// <summary>
        /// カテゴリ名称を取得する
        /// </summary>
        /// <returns></returns>
        public String GetCategoryName()
        {
            return categoryName;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="categoryName"></param>
        private ImportCategoryConstants(String categoryName)
        {
            this.categoryName = categoryName;
        }

        /// <summary>
        /// 預貯金
        /// </summary>
        public static readonly ImportCategoryConstants DEPOSIT_AND_SAVINGS = new ImportCategoryConstants(ImportCategoryNameConstants.DEPOSIT_AND_SAVINGS);

        /// <summary>
        /// 受取手形
        /// </summary>
        public static readonly ImportCategoryConstants BILLS_RECIVABLE = new ImportCategoryConstants(ImportCategoryNameConstants.BILLS_RECIVABLE);

        /// <summary>
        /// 売掛金・未収入金
        /// </summary>
        public static readonly ImportCategoryConstants ACCOUNTS_RECEIVABLE = new ImportCategoryConstants(ImportCategoryNameConstants.ACCOUNTS_RECEIVABLE);

        /// <summary>
        /// 仮払金
        /// </summary>
        public static readonly ImportCategoryConstants TEMPORARY_PAYMENT = new ImportCategoryConstants(ImportCategoryNameConstants.TEMPORARY_PAYMENT);

        /// <summary>
        /// 貸付金
        /// </summary>
        public static readonly ImportCategoryConstants LOAN = new ImportCategoryConstants(ImportCategoryNameConstants.LOAN);

        /// <summary>
        /// 棚卸資産
        /// </summary>
        public static readonly ImportCategoryConstants INVENTORY = new ImportCategoryConstants(ImportCategoryNameConstants.INVENTORY);

        /// <summary>
        /// 有価証券
        /// </summary>
        public static readonly ImportCategoryConstants SECURITIES = new ImportCategoryConstants(ImportCategoryNameConstants.SECURITIES);

        /// <summary>
        /// 固定資産
        /// </summary>
        public static readonly ImportCategoryConstants FIXED_ASSET = new ImportCategoryConstants(ImportCategoryNameConstants.FIXED_ASSET);

        /// <summary>
        /// 支払手形
        /// </summary>
        public static readonly ImportCategoryConstants BILLS_PAYABLE = new ImportCategoryConstants(ImportCategoryNameConstants.BILLS_PAYABLE);

        /// <summary>
        /// 買掛金・未払金
        /// </summary>
        public static readonly ImportCategoryConstants ACCOUNTS_PAYABLE = new ImportCategoryConstants(ImportCategoryNameConstants.ACCOUNTS_PAYABLE);

        /// <summary>
        /// 仮受金
        /// </summary>
        public static readonly ImportCategoryConstants TEMPORARY_DEPOSIT = new ImportCategoryConstants(ImportCategoryNameConstants.TEMPORARY_DEPOSIT);

        /// <summary>
        /// 借入金
        /// </summary>
        public static readonly ImportCategoryConstants BORROWING = new ImportCategoryConstants(ImportCategoryNameConstants.BORROWING);

        /// <summary>
        /// 土地の売上高等
        /// </summary>
        public static readonly ImportCategoryConstants LAND_SALES = new ImportCategoryConstants(ImportCategoryNameConstants.LAND_SALES);

        /// <summary>
        /// 売上高等の事業所別
        /// </summary>
        public static readonly ImportCategoryConstants BY_SALES_OFFICE = new ImportCategoryConstants(ImportCategoryNameConstants.BY_SALES_OFFICE);

        /// <summary>
        /// 役員報酬手形等・人件費
        /// </summary>
        public static readonly ImportCategoryConstants PERSONNEL_EXPENSES = new ImportCategoryConstants(ImportCategoryNameConstants.PERSONNEL_EXPENSES);

        /// <summary>
        /// 地代家賃
        /// </summary>
        public static readonly ImportCategoryConstants RENT = new ImportCategoryConstants(ImportCategoryNameConstants.RENT);

        /// <summary>
        /// 工業所有権等の使用料
        /// </summary>
        public static readonly ImportCategoryConstants INDUSTRIAL_PROPERTY_FEE = new ImportCategoryConstants(ImportCategoryNameConstants.INDUSTRIAL_PROPERTY_FEE);

        /// <summary>
        /// 雑益等
        /// </summary>
        public static readonly ImportCategoryConstants MISCELLANEOUS_PROFIT = new ImportCategoryConstants(ImportCategoryNameConstants.MISCELLANEOUS_PROFIT);

        /// <summary>
        /// 雑損失等
        /// </summary>
        public static readonly ImportCategoryConstants MISCELLANEOUS_LOSSES = new ImportCategoryConstants(ImportCategoryNameConstants.MISCELLANEOUS_LOSSES);

        /// <summary>
        /// その他科目(1)
        /// </summary>
        public static readonly ImportCategoryConstants OTHER_SUBJECTS_1 = new ImportCategoryConstants(ImportCategoryNameConstants.OTHER_SUBJECTS_1);

        /// <summary>
        /// その他科目(2)
        /// </summary>
        public static readonly ImportCategoryConstants OTHER_SUBJECTS_2 = new ImportCategoryConstants(ImportCategoryNameConstants.OTHER_SUBJECTS_2);

        /// <summary>
        /// その他科目(3)
        /// </summary>
        public static readonly ImportCategoryConstants OTHER_SUBJECTS_3 = new ImportCategoryConstants(ImportCategoryNameConstants.OTHER_SUBJECTS_3);

        /// <summary>
        /// その他科目(4)
        /// </summary>
        public static readonly ImportCategoryConstants OTHER_SUBJECTS_4 = new ImportCategoryConstants(ImportCategoryNameConstants.OTHER_SUBJECTS_4);

        /// <summary>
        /// その他科目(5)
        /// </summary>
        public static readonly ImportCategoryConstants OTHER_SUBJECTS_5 = new ImportCategoryConstants(ImportCategoryNameConstants.OTHER_SUBJECTS_5);
    }
}
