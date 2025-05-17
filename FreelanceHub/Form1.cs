using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelanceHub
{
    public partial class Form1 : Form
    {

        private readonly DBConnection dbConnection = DBConnection.Instance;
        private readonly DateBaseManager dbManager = new DateBaseManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            string password = "";
            string login = "";

            if (ShowLoginDialog("Dialog Box", ref login, ref password) == DialogResult.OK)
            {
                if (dbManager.AreCredentialsValidFreelance(login, password))
                {
                    FreelancerForm freelancer = new FreelancerForm();
                    freelancer.Show();
                }
                else
                {
                    MessageBox.Show("Невернный логин или пароль");
                }

            }

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            string password = "";
            string login = "";

            if (RegistlationBox("Окно регистрации",ref login,ref password) == DialogResult.OK)
            {
                dbManager.SaveToDateBase(login, password);
            }

        }
        public static DialogResult ShowLoginDialog(string title, ref string login, ref string password)
        {
            Form form = new Form();
            Label labelLogin = new Label();
            TextBox textBoxLogin = new TextBox();
            Label labelPassword = new Label();
            TextBox textBoxPassword = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.BackColor = Color.LightSeaGreen;
            form.Text = title;
            labelLogin.Text = "Логин:";
            labelPassword.Text = "Пароль:";
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            labelLogin.SetBounds(36, 36, 372, 13);
            textBoxLogin.SetBounds(36, 56, 300, 20);
            labelPassword.SetBounds(36, 86, 372, 13);
            textBoxPassword.SetBounds(36, 106, 300, 20);
            textBoxPassword.PasswordChar = '*';
            buttonOk.SetBounds(100, 150, 100, 30);
            buttonCancel.SetBounds(220, 150, 100, 30);

            labelLogin.AutoSize = true;
            labelPassword.AutoSize = true;

            form.ClientSize = new Size(400, 250);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { labelLogin, textBoxLogin, labelPassword, textBoxPassword, buttonOk, buttonCancel });

            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            login = textBoxLogin.Text;
            password = textBoxPassword.Text;

            return dialogResult;
        }
        public static DialogResult RegistlationBox(string title, ref string login, ref string password)
        {
            Form form = new Form();
            Label labelLogin = new Label();
            TextBox textBoxLogin = new TextBox();
            Label labelPassword = new Label();
            TextBox textBoxPassword = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            form.BackColor = Color.LightSeaGreen;
            labelLogin.Text = "Логин:";
            labelPassword.Text = "Пароль:";
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            labelLogin.SetBounds(36, 36, 372, 13);
            textBoxLogin.SetBounds(36, 56, 300, 20);
            labelPassword.SetBounds(36, 86, 372, 13);
            textBoxPassword.SetBounds(36, 106, 300, 20);
            textBoxPassword.PasswordChar = '*';

            buttonOk.SetBounds(100, 180, 100, 30);
            buttonCancel.SetBounds(220, 180, 100, 30);

            labelLogin.AutoSize = true;
            labelPassword.AutoSize = true;

            form.ClientSize = new Size(400, 250);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { labelLogin, textBoxLogin, labelPassword, textBoxPassword, buttonOk, buttonCancel });

            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            login = textBoxLogin.Text;
            password = textBoxPassword.Text;


            return dialogResult;
        }
    }
}
