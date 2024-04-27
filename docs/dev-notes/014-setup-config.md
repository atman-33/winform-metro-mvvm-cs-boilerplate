# config ファイルを利用する設定

## 手順

### 1. App.config ファイルを作成

1. WinFormプロジェクト > 追加 > 新しい項目 > アプリケーション構成ファイル から`App.config`を作成
2. `App.config`に、Domainレイヤーのconfigファイル参照を追加

`apps\WinFormBoilerplate\WinFormBoilerplate.WinForm\App.config`

```config
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings configSource="WinFormBoilerplate.config"></appSettings>
</configuration>
```

### 2. Domainレイヤーに、configファイルを作成

1. Domainプロジェクト > 追加 > 新しい項目 > アプリケーション構成ファイル から`WinFormBoilerplate.config`を作成

> WinFormBoilerplate はソリューション名のため、適宜変更すること。

- ビルド時に`WinFormBoilerplate.config`を出力するように、プロパティの設定「出力ディレクトリにコピー」を「常にコピーする」に変更すること。

### 3. Sharedクラスを作成

アプリ内でconfigファイルの値を扱えるように、Sharedクラスを作成する。

`apps\WinFormBoilerplate\WinFormBoilerplate.Domain\Shared.cs`  

e.g.  

```cs
using System.Configuration;

namespace WinFormBoilerplate.Domain
{
    public static class Shared
    {
        /// <summary>
        /// Fakeの時True
        /// </summary>
        public static bool IsFake { get; } = ConfigurationManager.AppSettings["IsFake"] == "1";
    }
}
```
