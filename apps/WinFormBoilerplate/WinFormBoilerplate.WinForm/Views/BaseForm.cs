using MetroFramework.Forms;

namespace WinFormBoilerplate.WinForm
{
    public partial class BaseForm : MetroForm
    {
        public BaseForm()
        {
            InitializeComponent();

            toolStripLabel1.Visible = false;
#if DEBUG
            toolStripLabel1.Visible = true;
#endif

        }
    }
}