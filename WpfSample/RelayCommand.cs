using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;

namespace WpfSample
{
    internal class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            // CommandManager = UI更新の通知や管理を行うクラス
            // パラメーターが変化したとき、それが再評価される。
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private readonly Action _excute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            this._excute = execute;
            this._canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
