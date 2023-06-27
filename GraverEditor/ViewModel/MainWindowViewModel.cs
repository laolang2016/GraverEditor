using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace GraverEditor.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {
        private static readonly NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        public MainWindowViewModel()
        {
            InitCommand();
        }

        private void InitCommand()
        {
            SayHelloCmd = new RelayCommand<string>((arg) => SayHello(arg));
        }

        #region 属性
        
        private string msg;

        public string Msg
        {
            get { return msg; }
            set => SetProperty(ref msg, value);
        }

        #endregion

        #region 命令

        public RelayCommand<string> SayHelloCmd{get;set;}
        private void SayHello(string arg)
        {
            Msg = "hello " + arg;
            log.Info($"arg{arg}");
        }

        #endregion

    }

}
