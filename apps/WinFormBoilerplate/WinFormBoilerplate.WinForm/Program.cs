using System.Diagnostics;
using WinFormBoilerplate.Domain;
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

            _logger.Debug("�f�o�b�O�̃��O");
            _logger.Info("�C���t�H�̃��O");
            _logger.Warn("�x���̃��O");
            _logger.Error("�G���[�̃��O");
            _logger.Fatal("�v���I�ȃ��O");

            Debug.WriteLine(Shared.IsFake ? "IsFake = true" : "IsFake = false");

            Application.Run(new HomeView());
        }
    }
}