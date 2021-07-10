using CalculadoraCumBLO.DTOS;
using CalculadoraCumBLO.DTOS.AccountModel;
using CalculadoraCumBLO.Interfaces;
using CalculadoraCumBLO.Models.AccountModel;
using CalculadoraCumBLO.Services;
using System.Windows.Forms;

namespace CalculadoraCum
{
    public partial class Login : Form
    {
        private readonly IAccountService _accountService;
        public Login()
        {
            InitializeComponent();
            _accountService = new AccountService();
        }

        private void SignInButton_Click(object sender, System.EventArgs e)
        {
            var login = new LoginRequest();
            login.Email = this.Emailtxt.Text;
            login.Password = this.Passwordtxt.Text;
            var result =_accountService.Login(login);
            if (result.Status != StatusCode.Ok)
            {
                MessageBox.Show(this, result.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }

        private void SignUpButton_Click(object sender, System.EventArgs e)
        {
            _accountService.Create(new CreateAccountRequest() { Email = "carlos@gmail.com",
                LastName = "MEDINA",
                Name = "CARLOS",
                Password = "12345678",
                Rol = 2
            });
        }
    }
}
