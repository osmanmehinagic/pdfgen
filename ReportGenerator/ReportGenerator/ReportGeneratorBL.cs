using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ReportGenerator.DataObjects;
using System.Configuration;
using ReportGenerator.DataObjects.Constants;
using ReportGenerator.DataObjects.CustomExceptions;

namespace ReportGenerator
{
    public static class ReportGeneratorBL
    {
        public static void GeneratePDFReport(IList<DummyObject> dummyObjects,  int applicationRowsLimit)
        {
            if (dummyObjects == null || dummyObjects.Count == 0)
            {
                //validacije, prikaz odgovarajuće poruke.
                throw new UserException(CustomExceptionMessages.emptyList);
            }

            if (dummyObjects.Count > applicationRowsLimit)
            {
                //potrebno implementirati batch (pozadinsko) kreiranje reporta zbog ocuvanja performansi.
                //ovaj dio nije implementiran u sklopu ovog zadatka
                throw new UserException(CustomExceptionMessages.applicationProcessingLimitExceeded);
            }


            //IDisposable object FileStream rad sa unmanaged memory - using block
            using (FileStream fs = new FileStream(string.Format("{0}\\{1}.pdf", DefaultFileProperties.defaultFileLocation, DefaultFileProperties.defaultFileName), FileMode.Create))
            {
                Document document = CreatePDFDocument();
                PdfWriter writer = PdfWriter.GetInstance(document, fs);

                document.Open();

                PdfPTable table = GenerateTableFromSource(dummyObjects);

                document.Add(table);

                document.Close();
                writer.Close();
            }
        }

        private static Document CreatePDFDocument()
        {
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);

            document.AddAuthor("Osman Mehinagic");
            document.AddCreator("Osman Mehinagic");
            document.AddKeywords("PDF Report");
            document.AddSubject("Dummy Report");
            document.AddTitle("Dummy Report");

            return document;
        }

        private static PdfPTable GenerateTableFromSource(IList<DummyObject> dummyObjects)
        {
            //simple implementation
            //todo : generic implementation
            PdfPTable table = new PdfPTable(5);

            foreach (DummyObject dummyObject in dummyObjects)
            {
                PdfPCell[] cellArray = new PdfPCell[5];
                cellArray[0] = new PdfPCell(new Phrase(dummyObject.FirstName));
                cellArray[1] = new PdfPCell(new Phrase(dummyObject.LastName));
                cellArray[2] = new PdfPCell(new Phrase(dummyObject.CityName));
                cellArray[3] = new PdfPCell(new Phrase(dummyObject.State));
                cellArray[4] = new PdfPCell(new Phrase(dummyObject.Points.ToString()));

                table.Rows.Add(new PdfPRow(cellArray));
            }

            return table;
        }
    }
}
