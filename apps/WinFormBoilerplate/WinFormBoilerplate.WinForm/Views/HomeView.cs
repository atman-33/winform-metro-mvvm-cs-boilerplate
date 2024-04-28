using WinFormBoilerplate.WinForm.ViewModels;

namespace WinFormBoilerplate.WinForm.Views
{
    /// <summary>
    /// ホーム画面
    /// </summary>
    public partial class HomeView : BaseForm
    {
        /// <summary>
        /// ViewModel
        /// </summary>
        private HomeViewModel _viewModel = new HomeViewModel();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HomeView()
        {
            InitializeComponent();

            Value1TextBox.DataBindings.Add(nameof(Value1TextBox.Text), _viewModel, nameof(_viewModel.Value1Text));
            Value2TextBox.DataBindings.Add(nameof(Value2TextBox.Text), _viewModel, nameof(_viewModel.Value2Text));
            ResultLabel.DataBindings.Add(nameof(ResultLabel.Text), _viewModel, nameof(_viewModel.ResultText));
        }

        /// <summary>
        /// 計算ボタンをクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                _viewModel.Calculate();
            },
            GetType(),
            System.Reflection.MethodBase.GetCurrentMethod());
        }

        /// <summary>
        /// サンプル画面に遷移する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SampleViewButton_Click(object sender, EventArgs e)
        {
            base.ExecuteWithErrorHandling(() =>
            {
                base.RequestNavigate(new SampleView());
            });
        }

        /// <summary>
        /// サンプル画面をダイアログとして開く。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SampleViewDialogButton_Click(object sender, EventArgs e)
        {
            var newForm = new SampleView();

            // NOTE: 遷移元の画面を操作可能な状態で、別ウィンドウとして開く。
            //newForm.Show();

            // NOTE: 遷移元の画面を操作不可能な状態で、別ウィンドウとして開く。
            newForm.ShowDialog();
        }
    }
}
