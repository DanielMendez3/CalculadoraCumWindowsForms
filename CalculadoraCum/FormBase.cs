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
        public FormBase()
        {
            InitializeComponent();
        }

        public FormBase(AccountDTO account) : base()
        {

        }
    }
}
