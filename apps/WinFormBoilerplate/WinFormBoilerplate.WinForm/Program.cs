using WinFormBoilerplate.WinForm.Views;

namespace WinFormBoilerplate.WinForm
{
    internal static class Program
    {
        /// <summary>
        /// ログ
        /// </summary>
        private static log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // NOTE: 動作確認用のコード
            //_logger.Debug("デバッグのログ");
            //_logger.Info("インフォのログ");
            //_logger.Warn("警告のログ");
            //_logger.Error("エラーのログ");
            //_logger.Fatal("致命的なログ");
            //Debug.WriteLine(Shared.IsFake ? "IsFake = true" : "IsFake = false");

            //Application.Run(new HomeView());

            Application.Run(new NavigationContext(new HomeView()));
        }
    }

    /// <summary>
    /// アプリケーション内のフォームやページのナビゲーションを管理するコンテキスト
    /// </summary>
    public class NavigationContext : ApplicationContext
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public NavigationContext(BaseForm initialForm)
        {
            initialForm.NavigationContext = this;
            this.MainForm = initialForm;
        }

        /// <summary>
        /// 指定した別フォームに切り替える。
        /// </summary>
        /// <param name="nextForm"></param>
        public void SwitchForm(Form nextForm)
        {
            var perviousForm = this.MainForm;
            this.MainForm = nextForm;

            perviousForm?.Close();
            nextForm.Show();
        }
    }
}