//------------------------------------------------------------
// MiUncleGameFramework v0.1a
// Copyright (C) 2016-2017 MiUncle. All rights reserved.
// Author: MiUncle
// Date:2017/11/19
//------------------------------------------------------------
using System;
namespace MiUncle.Eidtor
{
    public class TimeUtility
    {
        /// <summary>
        /// Get date format by "yyyy-MM-dd HH:mm:ss"
        /// </summary>
        /// <returns>formated date time</returns>
        public static string GetDataTimeY2S()
        {
            string dateFormat = "";
            DateTime dt = System.DateTime.Now;
            dateFormat = dt.ToString("yyyy-MM-dd HH:mm:ss");
            return dateFormat;
        }
    }
}
