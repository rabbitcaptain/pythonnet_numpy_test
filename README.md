# pythonnet_numpy_test
pythonnetを使ったC#でのnumpyの使用テスト

環境設定等は以下の私の記事を参考にしてみてください  
https://tpsxai.com/c%e3%81%abpython%e3%81%a7%e4%bd%9c%e3%81%a3%e3%81%9f%e5%87%a6%e7%90%86%e3%82%92%e7%b5%84%e3%81%bf%e8%be%bc%e3%82%80%e3%80%90pythonnet%e6%ba%96%e5%82%99%ef%bc%8b%e7%a2%ba%e8%aa%8d%e7%b7%a8-2021/

# 本リポジトリ使い方（簡易版）
1. 自分のpython環境を設定する  
Form1.csの54行目の

```c#:Form1.cs
var PYTHON_HOME = Environment.ExpandEnvironmentVariables(@"自分のpython環境");
```

をパスの部分を各々のpython環境のpython.exeがあるフォルダのパスにしてください。

2. Python.Runtime.dllを参照に追加する  

細かいやり方がわからない方は
私の記事を参考にしてみてください  
https://tpsxai.com/c%e3%81%abpython%e3%81%a7%e4%bd%9c%e3%81%a3%e3%81%9f%e5%87%a6%e7%90%86%e3%82%92%e7%b5%84%e3%81%bf%e8%be%bc%e3%82%80%e3%80%90pythonnet%e6%ba%96%e5%82%99%ef%bc%8b%e7%a2%ba%e8%aa%8d%e7%b7%a8-2021/

