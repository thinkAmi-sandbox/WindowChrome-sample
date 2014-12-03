using System;                           // Console
using System.Windows;                   // Window, SystemCommands
using Microsoft.TeamFoundation.MVVM;    // ViewModelBase

namespace WindowChrome_sample
{
    public partial class MainViewModel : ViewModelBase
    {
        // WindowStateへのデータバインディング
        private WindowState _windowState;
        public WindowState WindowState
        {
            get { return _windowState; }
            set
            {
                _windowState = value;
                RaisePropertyChanged("WindowState");

                // タイトルバーの挙動を確認するためのコンソール出力
                Console.WriteLine("WindowState:" + _windowState.ToString());
            }
        }


        // 閉じるボタン
        private void ExecuteCloseCommand(object x)
        {
            if (x != null)
            {
                var window = (Window)x;

                // SystemCommandsとCloseメソッド、どちらを使っても閉じることができる
                SystemCommands.CloseWindow(window);
                //window.Close();
            }
        }


        // 最大化ボタン
        private void ExecuteMaximizeCommand(object x)
        {
            if (x != null)
            {
                var window = (Window)x;
                SystemCommands.MaximizeWindow(window);
            }
        }

        private bool CanExecuteMaximizeCommand(object x)
        {
            if (x == null) return false;

            var window = (Window)x;
            return window.WindowState == WindowState.Maximized ? false : true;
        }


        // 最小化ボタン
        private void ExecuteMinimizeCommand(object x)
        {
            if (x != null)
            {
                var window = (Window)x;
                SystemCommands.MinimizeWindow(window);
            }
        }


        // 復元ボタン
        private void ExecuteRestoreCommand(object x)
        {
            if (x != null)
            {
                var window = (Window)x;
                SystemCommands.RestoreWindow(window);
            }
        }

        private bool CanExecuteRestoreCommand(object x)
        {
            if (x == null) return false;

            var window = (Window)x;

            // タイトルバーの挙動を確認するためのコンソール出力
            Console.WriteLine("CanRestore:" + window.WindowState.ToString());

            return window.WindowState == WindowState.Normal ? false : true;
        }
    }
}
