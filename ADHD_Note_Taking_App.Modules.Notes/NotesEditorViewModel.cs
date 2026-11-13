using ICSharpCode.AvalonEdit.Document;

namespace ADHD_Note_Taking_App.Modules.Notes;

public class NotesEditorViewModel : BindableBase
{
   public TextDocument TextDocument { get; } = new TextDocument();

   public NotesEditorViewModel()
   {
      TextDocument.TextChanged += OnTextDocumentTextChanged;
      TextDocument.UpdateFinished += TextDocumentOnUpdateFinished;
      TextDocument.Changed += TextDocumentOnChanged;
   }

   private void TextDocumentOnChanged( object? sender, DocumentChangeEventArgs e )
   {
      Console.WriteLine($"{TextDocument.Text}");
   }

   private void TextDocumentOnUpdateFinished( object? sender, EventArgs e )
   {
   }

   private void OnTextDocumentTextChanged( object? sender, EventArgs e )
   {
   }
}