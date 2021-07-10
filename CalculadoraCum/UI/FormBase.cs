using CalculadoraCumBLO.DTOS.AccountModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraCum
{
    public partial class FormBase : Form
    {
        private AccountDTO _account;
        public FormBase()
        {
            InitializeComponent();            
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            Login _formlogin = new Login();
            _formlogin.LoginEventHandler += LoginEvent;//Adjuntamos evento LoginEventHandler
            _formlogin.ShowDialog();          
        }

        private void LoginEvent(object sender, LoginEventArgs e)
        {
            this._account = e.account;
            this.LoadAccountData();
        }

        private void LoadAccountData()
        {
            if (_account == null) return;
            this.WelComeLabel.Text = $"Bienvenido(a) {_account.Name}";
        }
    }
}
