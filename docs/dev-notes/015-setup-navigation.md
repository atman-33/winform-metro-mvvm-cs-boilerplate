# ナビゲート風の画面遷移を追加

## 手順

### 1. NavigationContext を追加

`apps\WinFormBoilerplate\WinFormBoilerplate.WinForm\Program.cs`

```cs
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
```

- アプリ起動処理に、NavigationContextを利用するように変更する。

```cs
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new HomeView());
            Application.Run(new NavigationContext(new HomeView()));
        }
```

### 2. BaseForm を修正

- コンテキストを利用可能とし、ページ遷移の標準メソッドを追加する。

`apps\WinFormBoilerplate\WinFormBoilerplate.WinForm\Views\BaseForm.cs`

```cs
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BaseForm() : this(null)
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public BaseForm(ApplicationContext? context)
        {
            InitializeComponent();
            NavigationContext = (NavigationContext?)context;

            toolStripLabel1.Visible = false;
#if DEBUG
            toolStripLabel1.Visible = true;
#endif
        }

        /// <summary>
        /// フォームやページの遷移を管理するコンテキスト
        /// </summary>
        public NavigationContext? NavigationContext { get; set; }

        /// <summary>
        /// 指定したフォームの画面に遷移する。
        /// </summary>
        /// <param name="nextForm"></param>
        /// <exception cref="Exception"></exception>
        protected void RequestNavigate(BaseForm nextForm)
        {
            if (NavigationContext == null)
            {
                throw new Exception("BaseFormに、NavigationContextが設定されていません！コードを見直して下さい。");
            }

            nextForm.NavigationContext = this.NavigationContext;
            NavigationContext.SwitchForm(nextForm);
        }
```

### 3. 画面遷移の方法

e.g. SampleViewに画面遷移する際の記載例  

```cs
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
```
