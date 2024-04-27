using System.Diagnostics;
using WinFormBoilerplate.Domain.Modules.Guards;

namespace WinFormBoilerplate.WinForm.ViewModels
{
    internal class HomeViewModel : ViewModelBase
    {

        public HomeViewModel()
        {

        }

        // ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- //
        // Data Bindings
        // ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- //
        #region

        private string _value1Text = string.Empty;
        /// <summary>
        /// 計算用の値1
        /// </summary>
        public string Value1Text
        {
            get { return _value1Text; }
            set { SetProperty(ref _value1Text, value); }
        }

        private string _value2Text = string.Empty;
        /// <summary>
        /// 計算用の値2
        /// </summary>
        public string Value2Text
        {
            get { return _value2Text; }
            set { SetProperty(ref _value2Text, value); }
        }

        private string _resultText = "----";
        /// <summary>
        /// 計算結果
        /// </summary>
        public string ResultText
        {
            get { return _resultText; }
            set { SetProperty(ref _resultText, value); }
        }

        #endregion 

        /// <summary>
        /// 値を計算
        /// </summary>
        public void Calculate()
        {
            Debug.WriteLine("Calculate Button Clicked!!");
            Debug.WriteLine($" - Value1: {Value1Text}");
            Debug.WriteLine($" - Value2: {Value2Text}");

            float value1 = Guard.IsFloat(Value1Text, "1つ目のテキストボックスを数値で入力して下さい！");
            float value2 = Guard.IsFloat(Value2Text, "2つ目のテキストボックスを数値で入力して下さい！");

            ResultText = (value1 + value2).ToString();

            Debug.WriteLine($" - Result: {ResultText}");
        }
    }
}
