
using DryIoc;

namespace GraverEditor.ViewModel
{
    /// <summary>
    /// 这个类包含对应用程序中所有视图模型的静态引用，并提供绑定的入口点。
    /// </summary>
    class ViewModelLocator
    {

        private readonly Container _container;

        public ViewModelLocator()
        {
            // 初始化容器
            _container = new Container();

            // 注册 ViewModel
            _container.Register<MainWindowViewModel>();
        }

        public MainWindowViewModel MainWindow => _container.Resolve<MainWindowViewModel>();
    }
}
