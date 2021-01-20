﻿namespace MultiFactor.SelfService.Windows.Portal.Services.API.DTO
{
    /// <summary>
    /// Key and setup link for TOTP apps like Google Authenticator
    /// </summary>
    public class TotpKey
    {
        public string Key { get; set; }
        public string Link { get; set; }
    }
}