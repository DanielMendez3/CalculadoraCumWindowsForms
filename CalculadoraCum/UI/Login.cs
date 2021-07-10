using CalculadoraCumBLO.DTOS;
using CalculadoraCumBLO.DTOS.AccountModel;
using CalculadoraCumBLO.Interfaces;
using CalculadoraCumBLO.Models;
using CalculadoraCumBLO.Models.AccountModel;
using CalculadoraCumBLO.Services;
using System;
using System.Windows.Forms;

namespace CalculadoraCum
{
    public partial class Login : Form
    {
        private readonly IAccountService _accountService;
        public EventHandler<LoginEventArgs> LoginEventHandler;
        private AccountDTO _account;
        private Result _result;
        private LoginRequest _loginRequest = new LoginRequest();
        public Login()
        {
            InitializeComponent();
            _accountService = new AccountService();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.SignIn();
            this.Cursor = Cursors.Default;
            this.Emailtxt.Focus();
            if (_account != null) this.Close();
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

        private void SignIn()
        {
            _loginRequest.Email = this.Emailtxt.Text;
            _loginRequest.Password = this.Passwordtxt.Text;

            (_result, _account) = _accountService.Login(_loginRequest);
            if (_result.Status != StatusCode.Ok)
            {
                MessageBox.Show(this, _result.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Pasamos información a formulario padre
            LoginEventHandler?.Invoke(this, new LoginEventArgs()
            {
                account = _account
            });
        }
    }

    public class LoginEventArgs : EventArgs
    {
        public AccountDTO account { get; set; }
    }
}
