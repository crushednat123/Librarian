using Library.Entities;
using Library.Pages.PageLibrarian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Word = Microsoft.Office.Interop.Word;

namespace Library.Pages.PagePrint
{
    /// <summary>
    /// Логика взаимодействия для VidachaAllBookPrint.xaml
    /// </summary>
    public partial class VidachaAllBookPrint : Page
    {
        private Word.Document document = null;

        public VidachaAllBookPrint()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) => dateGrid.ItemsSource = App.DataBase.Extraditions.Where(x => x.IdTypeOfHalls == 3).ToList();           
        
        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {            
            MessageBox.Show("Печать загружается");

            FormDocument();
            document.Application.Dialogs[Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrint].Show();
            document.Application.Quit();
            document = null;
        }

        /// <summary>
        /// Метод печати
        /// </summary>
        private void FormDocument()
        {
            try
            {

                var rows = dateGrid.ItemsSource.Cast<Extraditions>().ToList();
                if (rows.Count == 0)
                {
                    MessageBox.Show("Нет выбранных книг", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                var app = new Word.Application();
                document = app.Documents.Add();
                Word.Paragraph tableParagraph = document.Paragraphs.Add();
                Word.Range tableRange = tableParagraph.Range;
                Word.Table table = document.Tables.Add(tableRange, rows.Count + 1, 6);
                table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                Word.Range cellRange;
                cellRange = table.Cell(1, 1).Range;
                cellRange.Text = "Номер книги";
                cellRange = table.Cell(1, 2).Range;
                cellRange.Text = "Название книги";
                cellRange = table.Cell(1, 3).Range;
                cellRange.Text = "Выдана";
                cellRange = table.Cell(1, 4).Range;
                cellRange.Text = "Тип";
                cellRange = table.Cell(1, 5).Range;
                cellRange.Text = "Дата выдачи";
                cellRange = table.Cell(1, 6).Range;
                cellRange.Text = "До";
                

                table.Rows[1].Range.Bold = 1;
                int currentRow = 1;
                foreach (var row in rows)
                {
                    currentRow++;
                    cellRange = table.Cell(currentRow, 1).Range;
                    cellRange.Text = row.Books.NamberBook.ToString();

                    cellRange = table.Cell(currentRow, 2).Range;
                    cellRange.Text = row.Books.NameBook;

                    cellRange = table.Cell(currentRow, 3).Range;
                    cellRange.Text = row.FullName;

                    cellRange = table.Cell(currentRow, 4).Range;
                    cellRange.Text = row.TypeUsers;

                    cellRange = table.Cell(currentRow, 5).Range;
                    cellRange.Text = row.DateOfISsue.ToShortDateString();

                    cellRange = table.Cell(currentRow, 6).Range;
                    cellRange.Text = row.EndDate.ToShortDateString();

                }

                document.Paragraphs.Add();
                Word.Paragraph sum = document.Paragraphs.Add();
                sum.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                Word.Range sumRange = sum.Range;
                sumRange.Bold = 1;
               
            }
            catch
            {
                MessageBox.Show("Ошибка в формировании отчета", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
