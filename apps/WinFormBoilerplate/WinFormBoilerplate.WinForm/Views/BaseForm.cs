using MetroFramework.Forms;
using WinFormBoilerplate.Domain.Exceptions;

namespace WinFormBoilerplate.WinForm
{
    public partial class BaseForm : MetroForm
    {
        /// <summary>
        /// ���O
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
        /// �Q�ƌ����珈�������s����Ƌ��ɁA��O�������͗�O���ʏ������s���B
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
        /// ��O���ʏ���
        /// </summary>
        /// <param name="ex"></param>
        protected void ExceptionProc(Exception ex)
        {
            _logger.Error(ex.Message, ex);
            MessageBoxIcon icon = MessageBoxIcon.Error;
            string caption = "�G���[";
            var exceptionBase = ex as ExceptionBase;
            if (exceptionBase != null)
            {
                if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Info)
                {
                    icon = MessageBoxIcon.Information;
                    caption = "���";
                }
                else if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Warning)
                {
                    icon = MessageBoxIcon.Warning;
                    caption = "�x��";
                }
            }

            MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, icon);
        }

        /// <summary>
        /// �N����
        /// </summary>
        /// <param name="sender">�R���g���[��</param>
        /// <param name="e">�C�x���g����</param>
        private void BaseForm_Load(object sender, EventArgs e)
        {
            _logger.Info("open:" + this.Name);
        }

        /// <summary>
        /// �I����
        /// </summary>
        /// <param name="sender">�R���g���[��</param>
        /// <param name="e">�C�x���g����</param>
        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logger.Info("close:" + this.Name);
        }
    }
}