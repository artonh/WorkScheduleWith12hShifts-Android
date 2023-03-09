//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WorkScheduleWith12hShifts.Services
{
    public class PDFGenerator
    {
       /* public void GeneratePDF()
        {
            using (var document = new Document())
            {
                MemoryStream memoryStream = new MemoryStream();

                using (var writer = PdfWriter.GetInstance(document, memoryStream))
                {
                    document.Open();

                    Paragraph paragraph = new Paragraph("Ky eshte nje tekst i shkruar ne PDF");
                    document.Add(paragraph);

                    document.Close();

                    byte[] bytes = memoryStream.ToArray();
                    File.WriteAllBytes("Raporti.pdf", bytes);
                }
            }
        }*/


       /* private async void OnCreatePDFClicked(object sender, EventArgs e)
        {
            await System.Threading.Tasks.Task.Run(() =>
            {
                var document = new Document(iTextSharp.text.PageSize.A4, 25, 25, 30, 30);

                var stream = new MemoryStream();
                PdfWriter.GetInstance(document, stream);

                document.Open();

                document.Add(new iTextSharp.text.Paragraph("Kjo është përmbajtja e dokumentit PDF."));

                document.Close();

                return stream;
            }).ContinueWith(task =>
            {
                // Kontrolloni per gabime
                if (task.Exception != null)
                {
                    Console.WriteLine(task.Exception.Message);
                    return;
                }

                MemoryStream stream = task.Result;

                string fileName = "Raporti.pdf";
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), fileName);
                File.WriteAllBytes(filePath, stream.ToArray());

                DisplayAlert("Sukses", "Raporti u krijua me sukses.", "OK");
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }*/
    }
}
