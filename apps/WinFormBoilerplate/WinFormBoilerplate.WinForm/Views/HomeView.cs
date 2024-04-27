using WinFormBoilerplate.WinForm.ViewModels;

namespace WinFormBoilerplate.WinForm.Views
{
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
            });
        }
    }
}
