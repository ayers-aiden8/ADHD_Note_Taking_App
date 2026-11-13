using System.Windows.Controls;

namespace ADHD_Note_Taking_App.Modules.Notes;

public partial class NotesEditorView : UserControl
{
    public NotesEditorView()
    {
        InitializeComponent();
        this.DataContext = new NotesEditorViewModel();
    }
}