﻿namespace TransactionMobile.Pages
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public interface ITransactionsPage
    {
        #region Events

        /// <summary>
        /// Occurs when [admin button click].
        /// </summary>
        event EventHandler AdminButtonClick;

        /// <summary>
        /// Occurs when [bill payment button click].
        /// </summary>
        event EventHandler BillPaymentButtonClick;

        /// <summary>
        /// Occurs when [mobile topup button click].
        /// </summary>
        event EventHandler MobileTopupButtonClick;

        /// <summary>
        /// Occurs when [mobile wallet button click].
        /// </summary>
        event EventHandler MobileWalletButtonClick;

        #endregion

        #region Methods

        /// <summary>
        /// Initializes the specified view model.
        /// </summary>
        void Init();

        #endregion
    }
}