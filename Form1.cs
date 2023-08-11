using DotNetEnv;
using RestSharp;
using System.Reflection.Metadata;

namespace HomeWork_Algebra
{
    internal partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Env.Load(Path.GetFullPath("../../config.env"));
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = "Выберите файл",
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // openFileDialog.FileName содержит путь выбранного файла
                string selectedFilePath = openFileDialog.FileName;

                // Дальнейшие действия с выбранным файлом
                // Например, вы можете отобразить путь файла в каком-либо текстовом поле
                selectedFileTextBox.Text = selectedFilePath;
            }
        }

        private void CheckKeysButton_Click(object sender, EventArgs e)
        {
            KeyChecker(selectedFileTextBox.Text);
        }
        public static void KeyChecker(string filePath)
        {
            using (var reader = new StreamReader(filePath))//выбранный файл
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var client = new RestClient("https://api.openai.com/v1/completions");
                    var request = new RestRequest(Method.POST);

                    var jsonData = new
                    {
                        prompt = "What is the capital of the moon?",
                        model = "text-davinci-003",
                        max_tokens = 7
                    };

                    int startIndex = line.IndexOf("sk-");
                    int endIndex = line.IndexOf(";", startIndex);

                    string apikey = line.Substring(startIndex, endIndex - startIndex);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("Authorization", $"Bearer {apikey}");
                    request.AddJsonBody(jsonData);

                    var response = client.Execute(request);

                    if (response.IsSuccessful)
                        Console.WriteLine($"Key number {apikey} is valid!");
                    else
                        Console.WriteLine($"Key {apikey} need to CHECK!");
                }
                Console.WriteLine("Checking is complete!");
            }
        }

        private void UploadKeysFromDB_Click(object sender, EventArgs e)
        {
            var dataTable = Database_Service.GetDataFromDatabase();
            Database_Service.UpdateDatabase();
            Database_Service.ExportDataToTXT(dataTable, DBPathTextBox.Text);
        }

        private void DBFilePath_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = "Выберите файл",
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // openFileDialog.FileName содержит путь выбранного файла
                string selectedFilePath = openFileDialog.FileName;

                // Дальнейшие действия с выбранным файлом
                // Например, вы можете отобразить путь файла в каком-либо текстовом поле
                selectedFileTextBox.Text = selectedFilePath;
            }
        }
    }
}