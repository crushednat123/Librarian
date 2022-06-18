using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Xps.Packaging;

namespace Library.Logic
{
    public class DocymentConvertToXPS
    {
        /// <summary>
        ///  Читает массив, и преобразовывает в документ в формате XPS
        /// </summary>
        /// <param name="array"></param>
        public static void DocymentReader(byte[] array, DocumentViewer documentViewer)
        {
            try
            {
                MemoryStream docStream = new MemoryStream(array);
                Package package = Package.Open(docStream);


                string inMemoryPackageName = string.Format("memorystream://{0}.xps", Guid.NewGuid());
                Uri packageUri = new Uri(inMemoryPackageName);


                PackageStore.AddPackage(packageUri, package);

                XpsDocument xpsDoc = new XpsDocument(package, CompressionOption.Maximum, inMemoryPackageName);
                FixedDocumentSequence fixedDocumentSequence = xpsDoc.GetFixedDocumentSequence();

                documentViewer.Document = fixedDocumentSequence;

            }
            catch
            {
                MessagesInfo.ErrorServerOrDocymentError();
            }
        }
    }
}
