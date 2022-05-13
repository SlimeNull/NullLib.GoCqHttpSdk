﻿using NullLib.GoCqHttpSdk.Message;
using System.Text;

namespace NullLib.GoCqHttpSdk
{
    public static class CqMsgChainExtensions
    {
        public static string GetText(this CqMsg[] message)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var msg in message)
                if (msg is CqTextMsg txtMsg)
                    sb.Append(txtMsg.Text);
            return sb.ToString();
        }
    }
}