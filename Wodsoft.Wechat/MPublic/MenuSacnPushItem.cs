﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wodsoft.Wechat.MPublic
{
    /// <summary>
    /// 微信扫码推事件菜单。
    /// </summary>
    public class MenuSacnPushItem : MenuKeyItem
    {
        public override string Type
        {
            get { return "scancode_push"; }
        }
    }
}
