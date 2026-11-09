using System.Configuration;
using System.Data;
using System.Windows;
using ADHD_Note_Taking_App.Core;
using ADHD_Note_Taking_App.Modules.FileHandling;
using ADHD_Note_Taking_App.Modules.Notes;
using ADHD_Note_Taking_App.Views;

namespace ADHD_Note_Taking_App;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : PrismApplication
{
    protected override void RegisterTypes( IContainerRegistry containerRegistry )
    {

    }

    protected override void ConfigureModuleCatalog(
        IModuleCatalog moduleCatalog )
    {
        moduleCatalog.AddModule<FileHandlingModule>();
        moduleCatalog.AddModule<NotesModule>();
    }

    protected override Window CreateShell()
    {
        var w = Container.Resolve<MainWindow>();
        return w;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Container.Resolve<IRegionManager>()
            .RequestNavigate( RegionNames.MainRegion, "NotesEditorView" );
    }
}