using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace EventAI_Creator.GUI.General
{
    public partial class eAICreator : Form
    {
        public eAICreator()
        {
            InitializeComponent();
        }

        private void connectbutton_Click(object sender, EventArgs e)
        {
            if(SQLConnection.Connect(tboxmysqlhost.Text, tboxmysqlname.Text, tboxmysqlpw.Text, /*tboxmysqlsd2db.Text,*/ tboxmysqlwordldb.Text))
            {
                Datastores.dbused = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(SQLConnection.error.Message);
            }
        }

        private void noDBconnection_Click(object sender, EventArgs e)
        {
            Datastores.dbused = false;
            this.Close();
        }

        private void eAICreator_Load(object sender, EventArgs e)
        {
            tboxmysqlhost.Text = Properties.Settings.Default.DBHost;
            tboxmysqlname.Text = Properties.Settings.Default.DBUSER ;
            tboxmysqlport.Text = Properties.Settings.Default.DBPort;
            tboxmysqlpw.Text = Properties.Settings.Default.DBPW;
            tboxmysqlwordldb.Text = Properties.Settings.Default.DBMANGOS;
            tboxmysqlsd2db.Text = Properties.Settings.Default.DBSD;
            
            //Properties.Settings.Default;
        }

        private void eAICreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.DBHost = tboxmysqlhost.Text;
            Properties.Settings.Default.DBUSER = tboxmysqlname.Text;
            Properties.Settings.Default.DBPW =tboxmysqlpw.Text;
            Properties.Settings.Default.DBPort = tboxmysqlport.Text;
            Properties.Settings.Default.DBMANGOS =tboxmysqlwordldb.Text;
            Properties.Settings.Default.DBSD = tboxmysqlsd2db.Text;
            Properties.Settings.Default.Save();
        }
        
    }
}
