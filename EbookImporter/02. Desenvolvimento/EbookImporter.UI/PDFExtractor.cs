using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;

namespace EbookImporter.UI
{
    class PDFExtractor
    {
        public static string ExtrairTextoPdf(string caminho)
        {
            PDDocument doc = null;
            try
            {
                doc = PDDocument.load(caminho);
              PDFTextStripper stripper = new PDFTextStripper();
                return stripper.getText(doc);
            }
            finally
            {
                if (doc != null)
                {
                    doc.close();
                }
            }
        }
    }
}
