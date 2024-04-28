using MetroFramework.Forms;
using System.Diagnostics;
using System.Reflection;
using WinFormBoilerplate.Domain.Exceptions;

namespace WinFormBoilerplate.WinForm
{
    /// <summary>
    /// Formの基底クラス
    /// </summary>
    public partial class BaseForm : MetroForm
    {

        /// <summary>
        /// ログ
        /// </summary>
        private static log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BaseForm() : this(null)
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public BaseForm(ApplicationContext? context)
        {
            InitializeComponent();
            NavigationContext = (NavigationContext?)context;

            toolStripLabel1.Visible = false;
#if DEBUG
            toolStripLabel1.Visible = true;
#endif
        }

        /// <summary>
        /// フォームやページの遷移を管理するコンテキスト
        /// </summary>
        public NavigationContext? NavigationContext { get; set; }

        /// <summary>
        /// 指定したフォームの画面に遷移する。
        /// </summary>
        /// <param name="nextForm"></param>
        /// <exception cref="Exception"></exception>
        protected void RequestNavigate(BaseForm nextForm)
        {
            if (NavigationContext == null)
            {
                throw new Exception("BaseFormに、NavigationContextが設定されていません！コードを見直して下さい。");
            }

            nextForm.NavigationContext = this.NavigationContext;
            NavigationContext.SwitchForm(nextForm);
        }

        /// <summary>
        /// 参照元から処理を実行すると共に、例外発生時は例外共通処理を行う。
        /// </summary>
        /// <param name="action">処理内容</param>
        /// <param name="memberInfo">呼び出し元のクラス情報</param>
        /// <param name="methodBase">呼び出し元の関数情報</param>
        protected void ExecuteWithErrorHandling(
            Action action,
            MemberInfo? memberInfo = null,
            MethodBase? methodBase = null)
        {
            try
            {
                if (memberInfo is not null || methodBase is not null)
                {
                    string info = memberInfo?.Name ?? string.Empty;
                    info = info != string.Empty ? info + "." : string.Empty;
                    info = info + methodBase?.Name ?? string.Empty;
                    info = $"👉 {info}";

#if DEBUG
                    Debug.WriteLine(info);
#else
                    _logger.Info($"👉 {info}");
#endif
                }

                action();
            }
            catch (Exception ex)
            {
                ExceptionProc(ex);
            }
        }

        /// <summary>
        /// 例外共通処理
        /// </summary>
        /// <param name="ex"></param>
        protected void ExceptionProc(Exception ex)
        {
#if DEBUG
            Debug.WriteLine(ex.Message);
#else
            _logger.Error(ex.Message, ex);
#endif

            MessageBoxIcon icon = MessageBoxIcon.Error;
            string caption = "エラー";
            var exceptionBase = ex as ExceptionBase;
            if (exceptionBase != null)
            {
                if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Info)
                {
                    icon = MessageBoxIcon.Information;
                    caption = "情報";
                }
                else if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Warning)
                {
                    icon = MessageBoxIcon.Warning;
                    caption = "警告";
                }
            }

            MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, icon);
        }

        /// <summary>
        /// 起動時
        /// </summary>
        /// <param name="sender">コントロール</param>
        /// <param name="e">イベント引数</param>
        private void BaseForm_Load(object sender, EventArgs e)
        {
#if DEBUG
            Debug.WriteLine("🚀 open:" + this.Name);
#else
            _logger.Info("🚀 open:" + this.Name);
#endif
        }

        /// <summary>
        /// 終了時
        /// </summary>
        /// <param name="sender">コントロール</param>
        /// <param name="e">イベント引数</param>
        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
#if DEBUG
            Debug.WriteLine("🌙 close:" + this.Name);
#else
            _logger.Info("🌙 close:" + this.Name);

#endif
        }
    }
}