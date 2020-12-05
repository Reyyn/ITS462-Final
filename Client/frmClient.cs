using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election2k20_Project_ITS462 {
    public partial class frmClient : Form {
        // object to handle database connections and queries.
        DBAccess db = new DBAccess();

        public frmClient() {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e) {
            db.OpenConnection();
            foreach (var p in db.GetParties())
                cmbParty.Items.Add(p);
            foreach(var c in db.GetCandidates())
                cmbCandidate.Items.Add(c);
            foreach (var s in db.GetStates())
                cmbState.Items.Add(s);
            db.CloseConnection();
        }

        private void cmbParty_SelectedIndexChanged(object sender, EventArgs e) {
            cmbCandidate.Text = "";
            cmbState.Text = "";

            db.OpenConnection();
            List<State> data = db.GetByParty(cmbParty.Text);
            dgvDisplay.DataSource = data;
            db.CloseConnection();
        }

        private void cmbCandidate_SelectedIndexChanged(object sender, EventArgs e) {
            cmbParty.Text = "";
            cmbState.Text = "";

            db.OpenConnection();
            List<State> data = db.GetByCandidate(cmbCandidate.Text);
            dgvDisplay.DataSource = data;
            db.CloseConnection();
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e) {
            cmbCandidate.Text = "";
            cmbParty.Text = "";

            db.OpenConnection();
            List<State> data = new List<State>();
            data.Add(db.GetByState(cmbState.Text));
            dgvDisplay.DataSource = data;
            db.CloseConnection();
        }

        private void btnFinal_Click(object sender, EventArgs e) {
            cmbCandidate.Text = "";
            cmbState.Text = "";
            cmbParty.Text = "";

            DataTable final = new DataTable();
            
            db.OpenConnection();
            int t = db.GetVotes("Trump");
            int b = db.GetVotes("Biden");
            db.CloseConnection();
            
            final.Columns.Add("Candidate");
            final.Columns.Add("Total Votes");
            final.Columns.Add("Percentage");

            float tf = (float)t / (float)(t + b);
            float bf = (float)b / (float)(t + b);

            final.Rows.Add("Trump", t, tf * 100);
            final.Rows.Add("Biden", b, bf * 100);

            dgvDisplay.DataSource = final;

            var w = "";
            if (t > b) w = "Trump"; else w = "Biden"; 
            MessageBox.Show("The winner is " + w);
        }
    }
}
