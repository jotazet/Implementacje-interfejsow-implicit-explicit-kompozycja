using System;

namespace ver2
{
    public interface IDocument
    {
        enum FormatType {TXT, PDF, JPG}

        // Zwraca typ formatu dokumentu
        FormatType GetFormatType();

        // Zwraca nazwę pliku dokumentu - nie może być `null` ani pusty `string`
        string GetFileName();        
    }
    public abstract class AbstractDocument : IDocument
    {
        private string fileName;
        public AbstractDocument(string fileName) =>  this.fileName = fileName;

        public string GetFileName() => fileName;

        public void ChangeFileName(string newFileName) => fileName = newFileName;

        public abstract IDocument.FormatType GetFormatType();
    }

    public class PDFDocument : AbstractDocument
    {
        public PDFDocument(string filename) : base(filename) { }
        public override IDocument.FormatType GetFormatType() => IDocument.FormatType.PDF;        
    }

    public class ImageDocument : AbstractDocument
    {
        public ImageDocument(string filename) : base(filename) { }
        public override IDocument.FormatType GetFormatType() => IDocument.FormatType.JPG;  
    }

    public class TextDocument : AbstractDocument
    {
        public TextDocument(string filename) : base(filename) { }
        public override IDocument.FormatType GetFormatType() => IDocument.FormatType.TXT;  
    }

}
