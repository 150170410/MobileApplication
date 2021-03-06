﻿namespace TransactionMobile.ViewModels
{
    using System;
    using Xamarin.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Xamarin.Forms.BindableObject" />
    public class MobileTopupPerformTopupViewModel : BindableObject
    {
        #region Fields

        /// <summary>
        /// The customer mobile number
        /// </summary>
        private String customerMobileNumber;

        /// <summary>
        /// The operator name
        /// </summary>
        private String operatorName;

        /// <summary>
        /// The topup amount
        /// </summary>
        private Decimal topupAmount;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the customer mobile number.
        /// </summary>
        /// <value>
        /// The customer mobile number.
        /// </value>
        public String CustomerMobileNumber
        {
            get
            {
                return this.customerMobileNumber;
            }
            set
            {
                this.customerMobileNumber = value;
                this.OnPropertyChanged(nameof(this.CustomerMobileNumber));
            }
        }

        /// <summary>
        /// Gets or sets the name of the operator.
        /// </summary>
        /// <value>
        /// The name of the operator.
        /// </value>
        public String OperatorName
        {
            set
            {
                this.operatorName = value;
            }
            get
            {
                return this.operatorName;
            }
        }

        /// <summary>
        /// Gets or sets the topup amount.
        /// </summary>
        /// <value>
        /// The topup amount.
        /// </value>
        public Decimal TopupAmount
        {
            get
            {
                return this.topupAmount;
            }
            set
            {
                this.topupAmount = value;
                this.OnPropertyChanged(nameof(this.TopupAmount));
            }
        }

        #endregion
    }
}