using System.Diagnostics;
using System.Reflection;

namespace WinFormBoilerplate.Domain.Modules.Attributes
{
    /// <summary>
    /// 作者情報を残すための属性クラス
    /// </summary>
    [AttributeUsage(
    AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method,
    AllowMultiple = true,
    Inherited = false)]
    public class AuthorAttribute : Attribute
    {
        private string name;
        public AuthorAttribute(string name) { this.name = name; }
        public string Name { get { return name; } }
    }

    /// <summary>
    /// 作者情報を取得するヘルパー
    /// </summary>
    public static class AuthorHelper
    {
        /// <summary>
        /// クラス自体とクラス中の public メソッドの作者情報を取得する。
        /// </summary>
        /// <param name="t">クラスの Type</param>
        public static void GetAllAuthors(Type t)
        {
            Console.WriteLine($"type name: {t.Name}");
            GetAuthors(t);

            foreach (MethodInfo info in t.GetMethods())
            {
                Debug.WriteLine($"  method name: {info.Name}");
                GetAuthors(info);
            }
        }

        /// <summary>
        /// クラスやメソッドの作者情報を取得する。
        /// </summary>
        /// <param name="info">クラスやメソッドの MemberInfo</param>
        public static void GetAuthors(MemberInfo info)
        {
            Attribute[] authors = Attribute.GetCustomAttributes(
                info, typeof(AuthorAttribute));
            foreach (Attribute att in authors)
            {
                AuthorAttribute? author = att as AuthorAttribute;
                if (author != null)
                {
                    Debug.WriteLine($"    author name: {author.Name}");
                }
            }
        }
    }
}