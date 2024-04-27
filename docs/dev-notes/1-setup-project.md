# Visual Studio プロジェクトをセットアップ

## 1. WinForm プロジェクト構築

### WinForm

1. Visual Studio を立ち上げる。
2. 新しいプロジェクトの作成 > C# Windows フォームアプリ を構成する。

   - プロジェクトテンプレート: Windows フォームアプリ
   - プロジェクト名: `WinFormBoilerplate.WinForm`
   - ソリューション名: `WinFormBoilerplate`
   - フレームワーク名: .NET 6.0

## 2. 各プロジェクト構築

同ソリューションに、各プロジェクトを追加する。

### Infrastructure

- プロジェクトテンプレート: クラスライブラリ
- プロジェクト名: `WinFormBoilerplate.Infrastructure`
- フレームワーク名: .NET 6.0

### Domain

- プロジェクトテンプレート: クラスライブラリ
- プロジェクト名: `WinFormBoilerplate.Domain`
- フレームワーク名: .NET 6.0

### Tests

- プロジェクトテンプレート: MSTest テスト プロジェクト
- プロジェクト名: `WinFormBoilerplateTest.Tests`
- フレームワーク名: .NET 6.0

## 3. 各プロジェクトの参照設定を追加

クリーンアーキテクチャとなるように、プロジェクトの参照に制約を加える。

- WinForm => Infrastructure, Domain
- Infrastructure => Domain
- Tests => WinForm, Infrastructure, Domain

## 4. git 初期化

1. Visual Studio > Git リポジトリの作成 > ローカルのみ
   - .gitignore テンプレート: 既定値(VisualStudio)

   モノレポ対応のディレクトリ構造とする場合は、下記のように`.git`の配置を変更する。

2. Visual Studio で自動生成された`.git`を削除する。

   ```powershell
   # ソリューションファイルが生成されているフォルダ(.gitが存在するフォルダ)
   cd <.gitフォルダが存在するディレクトリ>

   # 隠し含めたファイルとフォルダ一覧を表示(=> .gitフォルダが存在するか確認)
   ls -force

   # .git を削除
   Remove-Item -Recurse -Force .git
   ```

   > `.git`は、ソリューションファイルと同フォルダ内に存在  

3. リポジトリのトップディレクトリで、Gitリポジトリを初期化する。

   ```posershell
   cd <リポジトリのトップディレクトリ>
   git init
   ```

   > 必要に応じて、commit しておく。
