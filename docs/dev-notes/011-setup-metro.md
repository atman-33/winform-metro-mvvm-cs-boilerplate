# Modern UI Metro Framework導入

## 参考URL

[Modern UI Metro Framework導入](http://pgst.blog.jp/archives/1026512278.html)

## 導入手順

### 1. パッケージを追加

WinFormプロジェクト > NuGet パッケージの管理 > 「Metro Modern UI」をインストール

### 2. フォームをメトロフォームに変更

```cs
using MetroFramework.Forms;

namespace WinFormBoilerplate.WinForm
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
```

### 3. メトロコントロールを設定

Visual Studio のツールボックス > MetroFramework に各コントロールが配置されている。

> 一部記事では、dllの参照設定が必要とのことだったが、自動で設定されている場合もある。
