﻿namespace TransactionMobile.Common
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;
    using Events;

    /// <summary>
    /// 
    /// </summary>
    public interface IDevice
    {
        #region Methods

        /// <summary>
        /// Gets the device identifier.
        /// </summary>
        /// <returns></returns>
        String GetDeviceIdentifier();

        #endregion
    }
}