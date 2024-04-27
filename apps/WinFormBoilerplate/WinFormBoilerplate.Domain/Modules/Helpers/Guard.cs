using WinFormBoilerplate.Domain.Exceptions;

namespace WinFormBoilerplate.Domain.Modules.Helpers
{
    /// <summary>
    /// ガード処理
    /// </summary>
    public static class Guard
    {
        /// <summary>
        /// Nullの場合に例外を発生
        /// </summary>
        /// <param name="o"></param>
        /// <param name="message"></param>
        /// <exception cref="InputException"></exception>
        public static void IsNull(object o, string message)
        {
            if (o == null)
            {
                throw new InputException(message);
            }
        }

        /// <summary>
        /// Null or 空白の場合に例外を発生
        /// </summary>
        /// <param name="o"></param>
        /// <param name="message"></param>
        /// <exception cref="InputException"></exception>
        public static void IsNullOrEmpty(object o, string message)
        {
            if (o == null || Convert.ToString(o) == string.Empty)
            {
                throw new InputException(message);
            }
        }

        /// <summary>
        /// int型でない場合に例外を発生
        /// </summary>
        /// <param name="text"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="InputException"></exception>
        public static int IsInt(string text, string? message = null)
        {
            int intValue;
            if (!int.TryParse(text, out intValue))
            {
                throw new InputException(message ?? "int数値の入力に誤りがあります");
            }

            return intValue;
        }

        /// <summary>
        /// long型でない場合に例外を発生
        /// </summary>
        /// <param name="text"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="InputException"></exception>
        public static long IsLong(string text, string? message = null)
        {
            long longValue;
            if (!long.TryParse(text, out longValue))
            {
                throw new InputException(message ?? "long数値の入力に誤りがあります");
            }

            return longValue;
        }

        /// <summary>
        /// float型でない場合に例外を発生
        /// </summary>
        /// <param name="text"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="InputException"></exception>
        public static float IsFloat(string text, string? message = null)
        {
            float floatValue;
            if (!float.TryParse(text, out floatValue))
            {
                throw new InputException(message ?? "float数値の入力に誤りがあります");
            }

            return floatValue;
        }
    }
}
