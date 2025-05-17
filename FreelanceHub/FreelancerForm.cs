using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace FreelanceHub
{
    public partial class FreelancerForm : Form
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly Dictionary<int, Stopwatch> taskTimers = new Dictionary<int, Stopwatch>();
        private int selectedTaskIndexListBoxTask = -1;
        private int selectedTaskIndexListBoxProject = -1;
        public FreelancerForm()
        {
            InitializeComponent();
            timer1.Interval = 1;
        }


        private void buttonTimer_Click(object sender, EventArgs e)
        {

            if (selectedTaskIndexListBoxTask != -1)
            {
                if (!taskTimers.ContainsKey(selectedTaskIndexListBoxTask))
                {
                    taskTimers[selectedTaskIndexListBoxTask] = new Stopwatch();
                }

                var timer = taskTimers[selectedTaskIndexListBoxTask];
                if (!timer.IsRunning)
                {
                    timer.Start();
                    timer1.Start();
                    buttonTimer.Text = "Остановить таймер"; 
                }
                else
                {
                    timer.Stop();
                    timer1.Stop();
                    UpdateTaskElapsedTime(selectedTaskIndexListBoxTask, timer.Elapsed);
                    buttonTimer.Text = "Запустить таймер"; 
                }
            }
        }
        private void UpdateTaskElapsedTime(int index, TimeSpan elapsed)
        {
            if (index >= 0 && index < listBoxTasks.Items.Count)
            {
                var taskItem = listBoxTasks.Items[index] as TaskItem;
                if (taskItem != null)
                {
                    taskItem.ElapsedTime = elapsed;
                    listBoxTasks.Items[index] = taskItem;
                }
            }
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (selectedTaskIndexListBoxTask != -1 && taskTimers.ContainsKey(selectedTaskIndexListBoxTask))
            {
                var timer = taskTimers[selectedTaskIndexListBoxTask];
                if (timer.IsRunning)
                {
                    label1.Text = timer.Elapsed.ToString(@"hh\:mm\:ss\.ff");

                }
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox("Dialog Box", "Введите задачу", ref value) == DialogResult.OK)
            {
                int index = listBoxTasks.Items.Count + 1;
                listBoxTasks.Items.Add(new TaskItem($"{index}: {value}"));
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            form.BackColor = Color.LightSeaGreen;
            form.Text = title;
            label.Text = promptText;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 160, 160, 60);
            buttonCancel.SetBounds(400, 160, 160, 60);
            label.AutoSize = true;
            form.ClientSize = new Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox("Dialog Box", "Введите индекс задачи", ref value) == DialogResult.OK)
            {
                if (int.TryParse(value, out int result) && result > 0 && result <= listBoxTasks.Items.Count)
                {
                    listBoxTasks.Items.RemoveAt(result - 1);
                    taskTimers.Remove(result - 1);
                }
            }
        }

        private void buttonUpdateTasks_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox("Dialog Box", "Введите индекс задачи", ref value) == DialogResult.OK)
            {
                if (int.TryParse(value, out int result) && result > 0 && result <= listBoxTasks.Items.Count)
                {
                    string temp = "";
                    if (InputBox("Dialog Box", "Введите задачу", ref temp) == DialogResult.OK)
                    {
                        listBoxTasks.Items[result - 1] = new TaskItem($"{result}: {temp}");
                    }
                }
            }
        }
        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTaskIndexListBoxTask = listBoxTasks.SelectedIndex;

        }

        private void buttonSaveToPDF_Click(object sender, EventArgs e)
        {
            if (selectedTaskIndexListBoxProject == -1)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                SaveListBoxToPdf();
            }
        }
        private void buttonAddProject_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox("Dialog Box", "Введите название проекта", ref value) == DialogResult.OK)
            {
                int index = listBoxProjects.Items.Count + 1;
                listBoxProjects.Items.Add($"{index}: {value}");
            }
        }
        private void buttonDeleteProject_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox("Dialog Box", "Введите номер проекта", ref value) == DialogResult.OK)
            {
                if (int.TryParse(value, out int result) && result > 0 && result <= listBoxProjects.Items.Count)
                {
                    listBoxProjects.Items.RemoveAt(result - 1);

                }
            }
        }
        private void buttonUpdateProject_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox("Dialog Box", "Введите индекс задачи", ref value) == DialogResult.OK)
            {
                if (int.TryParse(value, out int result) && result > 0 && result <= listBoxProjects.Items.Count)
                {
                    string temp = "";
                    if (InputBox("Dialog Box", "Введите задачу", ref temp) == DialogResult.OK)
                    {
                        listBoxProjects.Items[result - 1] = new string($"{result}: {temp}");
                    }
                }
            }
        }
        private void listBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTaskIndexListBoxProject = listBoxProjects.SelectedIndex;
            buttonAddTask.Visible = true;
            buttonUpdateTask.Visible = true;
            buttonDeleteTask.Visible = true;
            listBoxTasks.Visible = true;
            labelTasks.Visible = true;

        }
        private void SaveListBoxToPdf()
        {

            Document doc = new Document();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "FreelancerReport.pdf");

            try
            {

                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                doc.Open();


                BaseFont baseFont = BaseFont.CreateFont("c:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(baseFont, 18f);
                iTextSharp.text.Font taskFont = new iTextSharp.text.Font(baseFont, 12f);


                Paragraph title = new Paragraph("Отчет", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);


                if (selectedTaskIndexListBoxProject != -1)
                {
                    string projectName = listBoxProjects.Items[selectedTaskIndexListBoxProject].ToString();
                    Paragraph project = new Paragraph($"Проект: {projectName}", titleFont);
                    project.Alignment = Element.ALIGN_CENTER;
                    doc.Add(project);
                }


                doc.Add(new Paragraph("\n"));


                double totalCost = 0;
                foreach (var item in listBoxTasks.Items)
                {
                    var taskItem = item as TaskItem;
                    if (taskItem != null)
                    {
                        Paragraph task = new Paragraph($"{taskItem.Description} - Затраченное Время: {taskItem.ElapsedTime.ToString(@"hh\:mm\:ss\.ff")}", taskFont);
                        doc.Add(task);


                        double cost = taskItem.ElapsedTime.TotalHours * 60000;
                        totalCost += cost;
                    }
                }


                totalCost = Math.Round(totalCost, 1);


                Paragraph totalCostParagraph = new Paragraph($"Итоговая цена: {totalCost} рублей", titleFont);
                totalCostParagraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(totalCostParagraph);


                doc.Close();


                MessageBox.Show("Отчет сформирован!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ошибка при сохранение файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}




