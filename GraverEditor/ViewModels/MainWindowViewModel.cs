using Prism.Commands;
using Prism.Mvvm;

namespace GraverEditor.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        private static readonly NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        public MainWindowViewModel()
        {
            InitCommand();
        }

        private void InitCommand()
        {
            SayHelloCmd = new DelegateCommand<string>((arg) => SayHello(arg)); 
        }



        #region 属性

        private string msg;

        public string Msg
        {
            get { return msg; }
            set { msg = value; RaisePropertyChanged(); }
        }

        #endregion

        #region 命令

        public DelegateCommand<string> SayHelloCmd { get; set; }

        private void SayHello(string arg)
        {
            Msg = "Hello " + arg;
            log.Info($"msg:${arg}");

        }

        #endregion
    }
}
