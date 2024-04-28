using WinFormBoilerplate.WinForm.Views;

namespace WinFormBoilerplate.WinForm
{
    internal static class Program
    {
        /// <summary>
        /// ���O
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

            // NOTE: ����m�F�p�̃R�[�h
            //_logger.Debug("�f�o�b�O�̃��O");
            //_logger.Info("�C���t�H�̃��O");
            //_logger.Warn("�x���̃��O");
            //_logger.Error("�G���[�̃��O");
            //_logger.Fatal("�v���I�ȃ��O");
            //Debug.WriteLine(Shared.IsFake ? "IsFake = true" : "IsFake = false");

            //Application.Run(new HomeView());

            Application.Run(new NavigationContext(new HomeView()));
        }
    }

    /// <summary>
    /// �A�v���P�[�V�������̃t�H�[����y�[�W�̃i�r�Q�[�V�������Ǘ�����R���e�L�X�g
    /// </summary>
    public class NavigationContext : ApplicationContext
    {
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public NavigationContext(BaseForm initialForm)
        {
            initialForm.NavigationContext = this;
            this.MainForm = initialForm;
        }

        /// <summary>
        /// �w�肵���ʃt�H�[���ɐ؂�ւ���B
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