﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Cargaison_LIAGE3_GLRS3.services;

namespace TP_Cargaison_LIAGE3_GLRS3
{

    //Utilisateur
     //nomComplet
     //login
     //Mot de passe
    public partial class FrmUser : Form
    {
        private CargaisonServiceBd service = new CargaisonServiceBd();
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            service.listerUser(dtgvUser);
        }
    }
}
