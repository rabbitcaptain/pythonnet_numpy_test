using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

using Python.Runtime;

namespace pythonnet_numpy_version
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// pythonライブラリを共有して使うための変数
        /// </summary>
        public dynamic np;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// プロセスの環境変数PATHに、指定されたディレクトリを追加する(パスを通す)。
        /// </summary>
        /// <param name="paths">PATHに追加するディレクトリ。</param>
        public static void AddEnvPath(params string[] paths)
        {
            var envPaths = Environment.GetEnvironmentVariable("PATH").Split(Path.PathSeparator).ToList();
            foreach (var path in paths)
            {
                if (path.Length > 0 && !envPaths.Contains(path))
                {
                    envPaths.Insert(0, path);
                }
            }
            Environment.SetEnvironmentVariable("PATH", string.Join(Path.PathSeparator.ToString(), envPaths), EnvironmentVariableTarget.Process);
        }
        // フォームが呼び出されるときに処理させる
        private void Form1_Load(object sender, EventArgs e)
        {
            // *-------------------------------------------------------*
            // * python環境の設定
            // *-------------------------------------------------------*

            // python環境にパスを通す
            // TODO: 環境に合わせてパスを直すこと
            var PYTHON_HOME = Environment.ExpandEnvironmentVariables(@"自分のpython環境");
            // pythonnetが、python本体のDLLおよび依存DLLを見つけられるようにする
            //Environment.SetEnvironmentVariable("PATH", PYTHON_HOME, EnvironmentVariableTarget.Process);
            //Environment.SetEnvironmentVariable("PATH", Path.Combine(PYTHON_HOME, @"Library\bin"), EnvironmentVariableTarget.Process);

            AddEnvPath(
              PYTHON_HOME,
              Path.Combine(PYTHON_HOME, @"Library\bin")
            );

            // python環境に、PYTHON_HOME(標準pythonライブラリの場所)を設定
            PythonEngine.PythonHome = PYTHON_HOME;

            // pythonの処理をする＝numpyの定義とバージョンをラベルに表示させる
            using (Py.GIL())
            {
                // numpyのインポート
                np = Py.Import("numpy");
                // numpyのバージョンを変数に格納
                dynamic np_version = np.__version__;
                // string型にして文字列と連結させラベルに表示
                labelNumpyVersion.Text = "numpyバージョン：" + np_version.ToString();
            }
        }
        // ボタンをクリックするとnumpyのメソッドを使って簡単な計算をしてラベルに表示
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            // 簡単な計算をして変数に格納
            dynamic result = np.cos(np.pi / 3);
            // ToStringしなくても文字列にくっつけると勝手に型を変えてくれる
            labelResult.Text = "np.cos(np.pi / 3)=" + result;
        }
    }
}
