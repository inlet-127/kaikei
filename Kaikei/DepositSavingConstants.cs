using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 預貯金で扱う識別子を定義するクラス
    /// </summary>
    public class DepositSavingConstants : IColumnIdentifier<DepositSavingConstants>
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
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private DepositSavingConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 金融機関名
        /// </summary>
        public static readonly DepositSavingConstants FINANTIAL_INSTITUTION_NAME = new DepositSavingConstants(NameColumnIdentifierConstants.FINANTIAL_INSTITUTION_NAME, CodeColumnIdentifierConstants.FINANTIAL_INSTITUTION_NAME);

        /// <summary>
        /// 支店名
        /// </summary>
        public static readonly DepositSavingConstants BRANCH_NAME = new DepositSavingConstants(NameColumnIdentifierConstants.BRANCH_NAME, CodeColumnIdentifierConstants.BRANCH_NAME_YK02);

        /// <summary>
        /// 預貯金種類
        /// </summary>
        public static readonly DepositSavingConstants DEPOSIT_TYPE = new DepositSavingConstants(NameColumnIdentifierConstants.DEPOSIT_TYPE, CodeColumnIdentifierConstants.DEPOSIT_TYPE);

        /// <summary>
        /// 口座番号
        /// </summary>
        public static readonly DepositSavingConstants ACCOUNT_NUMBER = new DepositSavingConstants(NameColumnIdentifierConstants.ACCOUNT_NUMBER, CodeColumnIdentifierConstants.ACCOUNT_NUMBER);

        /// <summary>
        /// 期末現在高
        /// </summary>
        public static readonly DepositSavingConstants DEPOSIT_PERIOD_END_HIGH = new DepositSavingConstants(NameColumnIdentifierConstants.PERIOD_END_HIGH, CodeColumnIdentifierConstants.PERIOD_END_HIGH);

        /// <summary>
        /// 摘要(※預貯金)
        /// </summary>
        public static readonly DepositSavingConstants DEPOSIT_SUMMARY = new DepositSavingConstants(NameColumnIdentifierConstants.SUMMARY, CodeColumnIdentifierConstants.SUMMARY_YK06);

        /// <summary>
        /// 預貯金で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<DepositSavingConstants> DEPOSIT_SAVING_IDENTIFIER_SET = new HashSet<DepositSavingConstants>()
        {
            FINANTIAL_INSTITUTION_NAME,
            BRANCH_NAME,
            DEPOSIT_TYPE,
            ACCOUNT_NUMBER,
            DEPOSIT_PERIOD_END_HIGH,
            DEPOSIT_SUMMARY
        };

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
        /// <returns>識別子</returns>
        public string GetIdentifierCode()
        {
            return identifierCode;
        }

        /// <summary>
        /// 預貯金で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>預貯金で扱う識別子の一覧</returns>
        public HashSet<DepositSavingConstants> GetColumnIdentifiers()
        {
            return DEPOSIT_SAVING_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 預貯金で固定
            return ImportCategoryConstants.DEPOSIT_AND_SAVINGS;
        }
    }
}