using System.Windows.Media;
using ICSharpCode.AvalonEdit.Highlighting;

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
        var def = HighlightingManager.Instance.GetDefinition("MarkDown");
        if (def == null) return;

        SetColor(def, "Heading", Color.FromRgb(0x25, 0x63, 0xEB));
        SetColor(def, "Code",    Color.FromRgb(0xB4, 0x53, 0x09));
        SetColor(def, "Link",    Color.FromRgb(0x0E, 0xA5, 0xE9));
    }

    private void SetColor( IHighlightingDefinition highlightingDefinition, string name, Color color )
    {
        var colour = highlightingDefinition.GetNamedColor( name );
        if ( colour != null )
        {
            colour.Foreground = new SimpleHighlightingBrush( color );
        }
    }
}