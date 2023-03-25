using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaikei
{
    /// <summary>
    /// 仮払金で扱う識別子を定義するクラス
    /// </summary>
    public class TemporaryPaymentConstants : IColumnIdentifier<TemporaryPaymentConstants>
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
        /// 仮払金で利用される識別子を格納したSet
        /// </summary>
        private static readonly HashSet<TemporaryPaymentConstants> TEMPORARY_PAYMENT_IDENTIFIER_SET = new HashSet<TemporaryPaymentConstants>()
        {
            TEMPORARY_PAYMENT_SUBJECT,
            TEMPORARY_PAYMENT_CUSTOMER_NAME,
            TEMPORARY_PAYMENT_CUSTOMER_LOCATION,
            TEMPORARY_PAYMENT_RELATIONSHIP,
            TEMPORARY_PAYMENT_PERIOD_END_HIGH,
            TEMPORARY_PAYMENT_TRANSACTION_CONTENT
        };

        /// <summary>
        /// 科目(※仮払金)
        /// </summary>
        public static readonly TemporaryPaymentConstants TEMPORARY_PAYMENT_SUBJECT = new TemporaryPaymentConstants(NameColumnIdentifierConstants.SUBJECTS, CodeColumnIdentifierConstants.SUBJECTS_RB01);

        /// <summary>
        /// 相手先名称(※仮払金)
        /// </summary>
        public static readonly TemporaryPaymentConstants TEMPORARY_PAYMENT_CUSTOMER_NAME = new TemporaryPaymentConstants(NameColumnIdentifierConstants.CUSTOMER_NAME, CodeColumnIdentifierConstants.CUSTOMER_NAME_RB02);

        /// <summary>
        /// 相手先所在地(※仮払金)
        /// </summary>
        public static readonly TemporaryPaymentConstants TEMPORARY_PAYMENT_CUSTOMER_LOCATION = new TemporaryPaymentConstants(NameColumnIdentifierConstants.CUSTOMER_LOCATION, CodeColumnIdentifierConstants.CUSTOMER_LOCATION_RB03);

        /// <summary>
        /// 関係(※仮払金)
        /// </summary>
        public static readonly TemporaryPaymentConstants TEMPORARY_PAYMENT_RELATIONSHIP = new TemporaryPaymentConstants(NameColumnIdentifierConstants.RELATIONSHIP, CodeColumnIdentifierConstants.RELATIONSHIP_RB04);

        /// <summary>
        /// 期末現在高(※仮払金)
        /// </summary>
        public static readonly TemporaryPaymentConstants TEMPORARY_PAYMENT_PERIOD_END_HIGH = new TemporaryPaymentConstants(NameColumnIdentifierConstants.PERIOD_END_HIGH, CodeColumnIdentifierConstants.PERIOD_END_HIGH_RB05);

        /// <summary>
        /// 取引の内容(※仮払金)
        /// </summary>
        public static readonly TemporaryPaymentConstants TEMPORARY_PAYMENT_TRANSACTION_CONTENT = new TemporaryPaymentConstants(NameColumnIdentifierConstants.TRANSACTION_CONTENT, CodeColumnIdentifierConstants.TRANSACTION_CONTENT_RB06);


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="identifierName"></param>
        /// <param name="identifierCode"></param>
        private TemporaryPaymentConstants(String identifierName, String identifierCode)
        {
            this.identifierName = identifierName;
            this.identifierCode = identifierCode;
        }

        /// <summary>
        /// 仮払金で扱う識別子の一覧を取得する
        /// </summary>
        /// <returns>仮払金で扱う識別子の一覧</returns>
        public HashSet<TemporaryPaymentConstants> GetColumnIdentifiers()
        {
            return TEMPORARY_PAYMENT_IDENTIFIER_SET;
        }

        /// <summary>
        /// データフォーマット種別を取得する
        /// </summary>
        /// <returns>データフォーマット種別</returns>
        public ImportCategoryConstants GetDataFormatCategory()
        {
            // 仮払金で固定
            return ImportCategoryConstants.TEMPORARY_PAYMENT;
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
