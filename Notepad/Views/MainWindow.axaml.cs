using Avalonia.Controls;
using Avalonia.Interactivity;
using Notepad.ViewModels;

namespace Notepad.Views {
    public partial class MainWindow: Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void DoubleTap(object sender, RoutedEventArgs e) {
            var mwvm = (MainWindowViewModel?) DataContext;
            if (mwvm == null) return;

            var src = e.Source;
            if (src == null) return;

            var name = src.GetType().Name; // припоминается питоновский obj.__type__.__name__ XD
            if (name == "Image" || name == "ContentPresenter" || name == "TextBlock") mwvm.DoubleTap();
        }
    }
}