# ViewModel を準備

MVVM対応として、ViewとViewModelファイルを格納できるディレクトリ構造に変更する。

## 手順

### 1. WinForm プロジェクトのディレクトリ構造を変更

```txt
Xxx.WinForm
|
+ ViewModels/
|  |
|  + ViewModelBase.cs         : ViewModelの基底クラス
|
+ Views/
|  |
|  + BaseForm.cs              : Formの基底クラス
|
```

### 2. ViewModelBase を準備

ViewとViewModelのBindingに利用する。  

`apps\WinFormBoilerplate\WinFormBoilerplate.WinForm\ViewModels\ViewModelBase.cs`

```cs
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NDDDWinFormBoilerplate.WinForm.ViewModels
{
    /// <summary>
    /// ViewModelの基底クラス
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// SetProperty
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="field">field</param>
        /// <param name="value">value</param>
        /// <param name="propertyName">propertyName</param>
        /// <returns>returns</returns>
        protected bool SetProperty<T>(ref T field,
            T value, [CallerMemberName] string? propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }

            field = value;
            var h = this.PropertyChanged;
            if (h != null)
            {
                h(this, new PropertyChangedEventArgs(propertyName));
            }

            return true;
        }
    }
}
```

### 3. BaseForm を準備

1. BaseFormを作成する。  

    `C:\Repos\winform-metro-mvvm-cs-boilerplate\apps\WinFormBoilerplate\WinFormBoilerplate.WinForm\Views\BaseForm.cs`

2. 他のViewはBaseFormを継承して利用する。  

e.g.  

```cs
namespace WinFormBoilerplate.WinForm.Views
{
    public partial class HomeView : BaseForm
    {
        public HomeView()
        {
            InitializeComponent();
        }
    }
}
```

> 初期の起動Form（View）を変更する場合は、Program.csを修正しておくこと。

e.g. HomeViewを起動画面にする場合  

`apps\WinFormBoilerplate\WinFormBoilerplate.WinForm\Program.cs`

```cs
using WinFormBoilerplate.WinForm.Views;

namespace WinFormBoilerplate.WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeView());
        }
    }
}
```
