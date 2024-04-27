using MetroFramework.Forms;
using WinFormBoilerplate.Domain.Exceptions;

namespace WinFormBoilerplate.WinForm
{
    public partial class BaseForm : MetroForm
    {
        /// <summary>
        /// ログ
        /// </summary>
        private static log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);

        public BaseForm()
        {
            InitializeComponent();

            toolStripLabel1.Visible = false;
#if DEBUG
            toolStripLabel1.Visible = true;
#endif
        }

        /// <summary>
        /// 参照元から処理を実行すると共に、例外発生時は例外共通処理を行う。
        /// </summary>
        /// <param name="action"></param>
        protected void ExecuteWithErrorHandling(Action action)
        {
            try
            {
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
            _logger.Error(ex.Message, ex);
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
            _logger.Info("open:" + this.Name);
        }

        /// <summary>
        /// 終了時
        /// </summary>
        /// <param name="sender">コントロール</param>
        /// <param name="e">イベント引数</param>
        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logger.Info("close:" + this.Name);
        }
    }
}