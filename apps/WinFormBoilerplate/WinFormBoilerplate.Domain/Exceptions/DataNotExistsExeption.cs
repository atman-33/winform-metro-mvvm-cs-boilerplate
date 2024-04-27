using WinFormBoilerplate.Domain.Exceptions;

namespace NDDD.Domain.Exceptions
{
    /// <summary>
    /// データなし例外
    /// </summary>
    public sealed class DataNotExistsExeption : ExceptionBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DataNotExistsExeption()
            :base("データがありません")
        {
        }

        /// <summary>
        /// 例外区分
        /// </summary>
        public override ExceptionKind Kind => ExceptionKind.Info;
    }
}
