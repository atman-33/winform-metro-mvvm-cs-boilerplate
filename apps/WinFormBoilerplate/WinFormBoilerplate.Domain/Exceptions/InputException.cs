namespace WinFormBoilerplate.Domain.Exceptions
{
    /// <summary>
    /// 入力例外
    /// </summary>
    public sealed class InputException : ExceptionBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="message">メッセージ</param>
        public InputException(string message) : base(message)
        {
        }

        /// <summary>
        /// 例外区分
        /// </summary>
        public override ExceptionKind Kind => ExceptionKind.Info;
    }
}
