using System;

namespace MobileSolutions.UILayer.Contracts
{
    /// <summary>
    /// Contract implemented by views or controls that expose a logout request event.
    /// </summary>
    public interface ILogoutSupport
    {
        /// <summary>
        /// Occurs when the user requests to log out.
        /// </summary>
        event EventHandler? LogoutRequested;
    }
}

