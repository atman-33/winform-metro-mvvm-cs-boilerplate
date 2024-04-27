# log4netを導入

## 参考URL

[WPF(C#) .NET6.0 で Log4net を実装](https://qiita.com/noriseto/items/7ad682d64acc4cf6d9fb)

## 手順

### 1. パッケージを追加

ソリューション > NuGet パッケージの管理 > 「log4net」をインストール  

> WinForm, Infrastructure, Domain プロジェクトそれぞれにインストールする。
> Test プロジェクトには不要。

### 2. AssemblyInfo.cs に Log4net の定義を追加

1. WinFormプロジェクト > 追加 > 新しい項目 > アセンブリ情報ファイル から`AssemblyInfo.cs`を作成
2. `AssemblyInfo.cs`に、log4net読み込み設定を追加

`apps\WinFormBoilerplate\WinFormBoilerplate.WinForm\AssemblyInfo.cs`

```cs
// 既存のコード
// ...

[assembly: log4net.Config.XmlConfigurator(ConfigFile = @"log4net.xml", Watch = true)]
```

### 3. Log4net 設定ファイルを作成

1. WinFormプロジェクト > 追加 > 新しい項目 > XMLファイル から`log4net.xml`を作成
2. `log4net.xml`に、log4netのログ出力設定を追加

`apps\WinFormBoilerplate\WinFormBoilerplate.WinForm\log4net.xml`

```xml
<?xml version="1.0" encoding="utf-8" ?>

<configuration>
  <log4net>
    <appender name="tryLogAppender" type="log4net.Appender.RollingFileAppender" >
      <File value=".\log\" />
      <DatePattern value='yyyyMMdd".log"' />
      <StaticLogFileName value="false" />
      <RollingStyle value="date" />
      <AppendToFile value="true" />
      <MaximumFileSize value="100MB" />
      <MaxSizeRollBackups value="30" />
      <layout type="log4net.Layout.PatternLayout">
        <ConversionPattern value="%date [%thread] [%-5level] (%method) - %message%n" />
      </layout>
    </appender>
    <filter type="log4net.Filter.LevelRangeFilter">
      <LevelMax value="FATAL" />
      <LevelMin value="DEBUG" />
    </filter>
    <root>
      <level value="Debug" />
      <appender-ref ref="tryLogAppender" />
    </root>
  </log4net>
</configuration>
```

- ビルド時にlog4net.xmlを出力するように、プロパティの設定「出力ディレクトリにコピー」を「常にコピーする」に変更すること。

## 利用方法

e.g.

```cs
        /// <summary>
        /// ログ
        /// </summary>
        private static log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);

        static void Main()
        {
            // ...

            _logger.Debug("デバッグのログ");
            _logger.Info("インフォのログ");
            _logger.Warn("警告のログ");
            _logger.Error("エラーのログ");
            _logger.Fatal("致命的なログ");

            // ...
        }
```
