﻿using System;
using TalkBackWCF.Contract;

namespace TalkBack.ClientDemo
{
    public class OnLoginEventArgs : EventArgs,IUserName
    {
        public string UserName { get; set; }
    }
}