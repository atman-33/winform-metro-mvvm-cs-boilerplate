namespace WinFormBoilerplate.WinForm.Views
{
    /// <summary>
    /// サンプル画面
    /// </summary>
    public partial class SampleView : BaseForm
    {
        public SampleView()
        {
            InitializeComponent();
        }

        private void HomeViewButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                base.RequestNavigate(new HomeView());
            });
        }
    }
}
