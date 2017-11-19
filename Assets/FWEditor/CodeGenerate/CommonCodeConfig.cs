using System;
namespace MiUncle.Eidtor
{
    /// <summary>
    /// 用来存储一些基本代码的配置
    /// </summary>
    public static class CommonCodeConfig
    {
        public const string SplitLine = "//------------------------------------------------------------";
        public const string LineBreak = "/n";
        public const string CopyRight = "// MiUncleGameFramework v0.1a/n// Copyright (C) 2016-2017 MiUncle. All rights reserved./n// Author: {AuthorName} /n// Date:{DateTime}";
        public const string CommonCodeTemplate = "namespace {NameSpace}/n{/n{ClassTemplate}/n}";
        public const string CommonClassTemplate = "public {ClassName}/n{/n{CodeContent}/n}";

        public const string DateTime = "{DateTime}";
        public const string NameSpace = "{NameSpace}";
        public const string ClassName = "{ClassName}";
        public const string CodeContent = "{CodeContent}";
        public const string AuthorName = "{AuthorName}";
    }
}
