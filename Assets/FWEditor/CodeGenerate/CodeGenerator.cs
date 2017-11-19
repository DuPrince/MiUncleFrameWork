using System;
namespace MiUncle.Eidtor
{
    /// <summary>
    /// 代码生成器
    /// </summary>
    public class CodeGenerator
    {

        public static string GetCommonCode(string className, string nameSpace, string authorName = "MiUncle")
        {
            string codeContent = GetCopyRight(authorName);
            codeContent += GetGenerateClassCode(nameSpace,className);
            return codeContent;
        }

        /// <summary>
        /// get copy right format
        /// </summary>
        /// <param name="authorName">authorName </param>
        /// <returns>copy right format</returns>
        public static string GetCopyRight(string authorName )
        {
            string copyRight = CommonCodeConfig.SplitLine + CommonCodeConfig.LineBreak;
            copyRight += CommonCodeConfig.CopyRight;
            copyRight.Replace(CommonCodeConfig.AuthorName,authorName);
            copyRight.Replace(CommonCodeConfig.DateTime,TimeUtility.GetDataTimeY2S());
            copyRight += CommonCodeConfig.LineBreak + CommonCodeConfig.SplitLine + CommonCodeConfig.LineBreak;
            return copyRight;
        }

        /// <summary>
        /// Generate class code
        /// </summary>
        /// <param name="nameSpace"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public static string GetGenerateClassCode(string nameSpace, string className,string codeContent = "")
        {
            string classCode = CommonCodeConfig.CommonCodeTemplate;
            classCode.Replace(CommonCodeConfig.NameSpace, nameSpace);
            classCode.Replace(CommonCodeConfig.ClassTemplate,CommonCodeConfig.CommonClassTemplate);
            classCode.Replace(CommonCodeConfig.ClassName, className);
            classCode.Replace(CommonCodeConfig.CodeContent,codeContent);
            return classCode;
        }
    }
}
