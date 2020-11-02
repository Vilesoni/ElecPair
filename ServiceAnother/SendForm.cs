using System;
using System.Windows.Forms;
using Xceed.Words.NET;
using Xceed.Document.NET;
using System.Data.SQLite;
using System.Net;
using System.Net.Mail;
using System.Drawing.Printing;
using Paragraph = Xceed.Document.NET.Paragraph;
using Table = Xceed.Document.NET.Table;
using Document = Spire.Doc.Document;
using System.IO;
using System.Text.RegularExpressions;

namespace ServiceAnother
{
    public partial class SendForm : Form
    {
        string formName;
        DataGridView data;

        int checkBoxColumnIndex = 0;

        string userFullName = "";

        string messageTheme = "";

        SQLiteConnection connection;
        SQLiteDataReader dataReader;
        SQLiteCommand cmd;

        string dirName = "tmp";
        public SendForm()
        {
            InitializeComponent();
        }
        public SendForm(DataGridView _data, string _formName, int _checkBoxColumnIndex, SQLiteConnection _connection)
        {
            InitializeComponent();
            data = _data;
            formName = _formName;
            checkBoxColumnIndex = _checkBoxColumnIndex;
            connection = _connection;
        }
        private void SendForm_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(dirName);
            infoTB.Text = "\t\t\t\tРемонт электрооборудования ElecPair\t\t\r\n";
            switch (formName)
            {
                case "Клиенты":
                    {
                        messageTheme = "Информация о заказе ElecPair";

                        for (int i = 0; i < data.RowCount; i++)
                        {
                            if (Convert.ToBoolean(data[checkBoxColumnIndex, i].Value))
                            {
                                GetInfoUser(i);
                                infoTB.Text += $"ФИО Клиента: {data[1, i].Value}\r\n";
                                infoTB.Text += $"ФИО Сотрудника: {userFullName}\r\n";
                                infoTB.Text += $"Телефон: {data[2, i].Value}\r\n";
                                infoTB.Text += $"Дата принятия в ремонт: {data[3, i].Value}\r\n";
                                infoTB.Text += "===============================================================\r\n";
                                infoTB.Text += $"Принятое оборудование: {data[5, i].Value}\r\n";
                                infoTB.Text += $"Заявленная неисправность: {data[6, i].Value}\r\n";
                                infoTB.Text += $"Вид работ:\r\n";
                                var tmp = data[7, i].Value.ToString().Split(new char[] { '\n' });
                                for (int j = 0; j < tmp.Length; j++)
                                {
                                    infoTB.Text += $"{tmp[j]}\r\n";
                                }
                                infoTB.Text += $"Сумма, руб: {data[8, i].Value}\r\n";
                                infoTB.Text += "===============================================================\r\n";
                                infoTB.Text += $"Дата выдачи: {data[4, i].Value}\r\n";
                                infoTB.Text += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n\r\n\r\n";
                            }
                        }
                        if (Directory.Exists(dirName))
                        {
                            WriteClients($@"{ dirName}\Заказ.docx");
                        }
                    }
                    break;
                case "Услуги":
                    {
                        messageTheme = "Предоставляемые услуги";
                        for (int i = 0; i < data.RowCount; i++)
                        {
                            if (Convert.ToBoolean(data[checkBoxColumnIndex, i].Value))
                            {
                                infoTB.Text += $"Тип оборудования: {data[1, i].Value}\r\n";
                                infoTB.Text += $"Вид работ: {data[2, i].Value}\r\n";
                                infoTB.Text += $"Стоимость, руб: {data[3, i].Value}\r\n";
                                infoTB.Text += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n\r\n\r\n";
                            }
                        }
                        if (Directory.Exists(dirName))
                        {
                            WriteService($@"{dirName}\Услуги.docx");
                        }
                    }
                    break;
            }

        }
        private void moveToolsPanelPB_Click(object sender, EventArgs e)
        {
            toolPanel.Visible = toolPanel.Visible = true ^ toolPanel.Visible;
            inputPanel.Visible = false;
        }
        private void fileButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = formName;
            saveFileDialog.Title = "Сохранить как";
            saveFileDialog.Filter = "Документ Word (*.docx)|*.docx|" +
                "Документ Word 97-2003 (*.doc)|*.doc";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName == "")
                {
                    MessageBox.Show("Введите имя файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    switch (formName)
                    {
                        case "Клиенты":
                            try
                            {
                                WriteClients(saveFileDialog.FileName);

                                MessageBox.Show("Файл успешно создан", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("Не удалось создать файл", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case "Услуги":
                            try
                            {
                                WriteService(saveFileDialog.FileName);
                                MessageBox.Show("Файл успешно создан", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("Не удалось создать файл", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                    }

                }
            }
        }
        private void WriteClients(string fileName)
        {
            DocX doc = DocX.Create(fileName);
            for (int i = 0; i < data.RowCount; i++)
            {
                if (Convert.ToBoolean(data[checkBoxColumnIndex, i].Value))
                {
                    Paragraph paragraph = doc.InsertParagraph();
                    paragraph.Alignment = Alignment.right;
                    paragraph.AppendLine("ElecPair").Font("Arial Black").FontSize(16).UnderlineStyle(UnderlineStyle.singleLine).Highlight(Highlight.magenta); ;
                    paragraph.AppendLine($"(29) 970 - 14 - 80\r\nelec_pair@mail.ru").Font("Arial Black").FontSize(12);

                    doc.InsertParagraph($"Клиент: {data[1, i].Value}").Font("Arial Black").FontSize(14);
                    doc.InsertParagraph($"Телефон: {data[2, i].Value}").Font("Arial Black").FontSize(14);

                    doc.InsertParagraph($"Сотрудник: {userFullName}").Font("Arial Black").FontSize(14);

                    doc.InsertParagraph($"Дата принятия в ремонт: {data[3, i].Value}").Font("Arial Black").FontSize(12);

                    Table table = doc.AddTable(4, 2);
                    table.Design = TableDesign.TableGrid;

                    table.Rows[0].Cells[0].Paragraphs[0].Append("Принятое оборудование").Font("Arial").Bold();
                    table.Rows[1].Cells[0].Paragraphs[0].Append("Заявленная неисправность").Font("Arial").Bold();
                    table.Rows[2].Cells[0].Paragraphs[0].Append("Вид работ").Font("Arial").Bold();
                    table.Rows[3].Cells[0].Paragraphs[0].Append("Сумма, руб").Font("Arial").Bold();

                    table.Rows[0].Cells[1].Paragraphs[0].Append(data[5, i].Value.ToString()).Font("Arial");
                    table.Rows[1].Cells[1].Paragraphs[0].Append(data[6, i].Value.ToString()).Font("Arial");
                    table.Rows[2].Cells[1].Paragraphs[0].Append(data[7, i].Value.ToString()).Font("Arial");
                    table.Rows[3].Cells[1].Paragraphs[0].Append(data[8, i].Value.ToString()).Font("Arial");

                    doc.InsertParagraph().InsertTableAfterSelf(table);
                    doc.InsertParagraph($"Дата выдачи: {data[4, i].Value}").Font("Arial Black").FontSize(12); ;

                }
            }
            doc.AddProtection(EditRestrictions.readOnly);
            doc.Save();

        }///////////Создание файла и запись информации о клиентах
        private void WriteService(string fileName)
        {
            int checkedRowsCount = 0;
            for (int i = 0; i < data.RowCount; i++)
            {
                if (Convert.ToBoolean(data[checkBoxColumnIndex, i].Value))
                {
                    checkedRowsCount++;
                }
            }
            DocX doc = DocX.Create(fileName);

            Paragraph paragraph = doc.InsertParagraph();
            paragraph.Alignment = Alignment.right;
            paragraph.AppendLine("ElecPair").Font("Arial Black").FontSize(16).UnderlineStyle(UnderlineStyle.singleLine).Highlight(Highlight.magenta);
            paragraph.AppendLine($"(29) 970 - 14 - 80\r\nelec_pair@mail.ru").Font("Arial Black").FontSize(12);
            Table table = doc.AddTable(checkedRowsCount + 1, 3);
            table.Design = TableDesign.TableGrid;

            table.Rows[0].Cells[0].Paragraphs[0].Append("Тип оборудования").Font("Arial").Bold();
            table.Rows[0].Cells[1].Paragraphs[0].Append("Вид работ").Font("Arial").Bold();
            table.Rows[0].Cells[2].Paragraphs[0].Append("Стоимость, руб").Font("Arial").Bold();

            int index = 1;
            for (int i = 0; i < checkedRowsCount; i++)
            {
                table.Rows[index].Cells[0].Paragraphs[0].Append(data[1, i].Value.ToString()).Font("Arial");
                table.Rows[index].Cells[1].Paragraphs[0].Append(data[2, i].Value.ToString()).Font("Arial");
                table.Rows[index].Cells[2].Paragraphs[0].Append(data[3, i].Value.ToString()).Font("Arial");

                index++;

            }
            doc.InsertParagraph().InsertTableAfterSelf(table);
            doc.AddProtection(EditRestrictions.readOnly);
            doc.Save();

        }//////////Создание файла и запись информации об услугах
        private void mailButton_Click(object sender, EventArgs e)
        {
            inputPanel.Visible = inputPanel.Visible = true ^ inputPanel.Visible;
            fileButton.Visible = fileButton.Visible = true ^ fileButton.Visible;
            printButton.Visible = printButton.Visible = true ^ printButton.Visible;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(mailTB.Text))
            {
                if (CheckMail())
                {
                    SendMail();
                }
                else
                {
                    statusText.Text = "Указана неверная почта";
                }
            }
            else
            {
                statusText.Text = "Поле не может оставаться пустым";
            }
        }
        private bool CheckMail()
        {
            if (Regex.IsMatch(mailTB.Text, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }///////////Проверка корректности введенного почтового адреса
        private void SendMail()
        {
            string myMailName = "elec_pair@mail.ru";
            string myMailPassword = "steopatra79";

            string sendTo = mailTB.Text;

            string fileName = "";

            sendTo += mailTypeUD.Text;

            MailAddress from = new MailAddress(myMailName, "ElecPair");

            MailAddress to = new MailAddress(sendTo);

            MailMessage m = new MailMessage(from, to);

            m.Subject = messageTheme;
            m.Body = "Хорошего дня";

            switch (formName)
            {
                case "Клиенты":
                    {
                        if (Directory.Exists(dirName))
                        {
                            fileName = $@"{ dirName}\Заказ.docx";

                            Attachment attachment = new Attachment(fileName);
                            m.Attachments.Add(attachment);
                        }
                        else
                        {
                            Directory.CreateDirectory(dirName);
                        }
                    }
                    break;
                case "Услуги":
                    {
                        if (Directory.Exists(dirName))
                        {
                            fileName = $@"{dirName}\Услуги.docx";

                            Attachment attachment = new Attachment(fileName);
                            m.Attachments.Add(attachment);
                        }
                        else
                        {
                            Directory.CreateDirectory(dirName);
                        }
                    }
                    break;
            }
            m.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);

            smtp.Credentials = new NetworkCredential(myMailName, myMailPassword);
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(m);
                MessageBox.Show("Сообщение успешно отправлено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Не удалось отправить сообщение", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }///////////Отправка на электронную почту
        private void FocusEntered(object sender, EventArgs e)
        {
            statusText.Text = "";
        }
        private void GetInfoUser(int i)
        {
            string getInf = $"SELECT FullName FROM Users WHERE UserName = '{data[9, i].Value}'";
            cmd = new SQLiteCommand(getInf, connection);
            dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    userFullName = dataReader[0].ToString();
                }
            }
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            string fileName = "";
            switch (formName)
            {
                case "Клиенты":
                    {
                        if (Directory.Exists(dirName))
                        {
                            fileName = $@"{dirName}\Заказ.docx";
                        }
                    }
                    break;
                case "Услуги":
                    {
                        if (Directory.Exists(dirName))
                        {
                            fileName = $@"{dirName}\Услуги.docx";
                        }
                    }
                    break;
            }

            Document doc = new Document();
            if (File.Exists(fileName))
            {
                doc.LoadFromFile(fileName);
                PrintDialog dialog = new PrintDialog();

                dialog.AllowPrintToFile = true;
                dialog.AllowCurrentPage = true;
                dialog.AllowSomePages = true;
                dialog.UseEXDialog = true;

                doc.PrintDialog = dialog;
                PrintDocument printDoc = doc.PrintDocument;
                printDoc.DocumentName = fileName;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }

            }
            else
            {
                MessageBox.Show("Не удалось найти файл для печати.\nПожалуйста закройте окно отправки", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }///////////Печать документа
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}

