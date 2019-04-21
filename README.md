# Test-Nuget-Packages
Test Nuget Packages

#Nuget Packageの生成を確認したときのメモ
## 環境
- Visual Sutdio 2017 community

# CPPプロジェクトでのNuget Packageについて
- CPPプロジェクトでは、Visual Studioから自動的にNuget Packageを生成することはできないので、nuspecファイルを作成して行った。
- CSプロジェクトでは、CPPのDLLは直接参照はできないので、Nuget Packageのtagetsファイルにてビルド時にターゲットディレクトリにコピーするようになっている。
- 今回は、Nuget Package内に、ビルドしたDllをコンテンツ(content)として保存しているが、この場合、インポートしたCSプロジェクトでは、そのプロジェクトにビルドしたdllが表示されるこる。これが嫌な場合は、contentFilesとして登録することで回避ができる。

# CSプロジェクトでのNuget Packageについて
- CSプロジェクト(.net standard)にて、CPPプロジェクトのNuget Packageをインポートする。
- CSプロジェクトでは、自動的にNuget Packageを生成することができる。細かい設定などは、プロジェクトファイル内で記載するが、nuspecファイルを用いることも可能。
- CSプロジェクトのNuget Packageを自動（Pack指定）で生成する場合、依存関係も自動的に含めてくれる。
- 依存関係にあるCPPプロジェクトのNuget Packageは、CSプロジェクトのNuget Packageが何に使用されるか意識する必要がある。
- 例えば、このCSプロジェクトは.net standardだが、そのNuget Packageは、.net framewark 4.6などで使用する場合もあるので、CPPプロジェクトのNuget Packgeは、.net standardだけではなく、.net framework 4.6も意識しておかないと、うまくビルドができないことが発生する。
