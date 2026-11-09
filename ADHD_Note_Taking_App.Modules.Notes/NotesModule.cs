namespace ADHD_Note_Taking_App.Modules.Notes;

using Prism.Ioc;

public class NotesModule : IModule
{
    public void RegisterTypes( IContainerRegistry containerRegistry )
    {
        containerRegistry.RegisterForNavigation<NotesEditorView>();
    }

    public void OnInitialized( IContainerProvider containerProvider )
    {
    }
}