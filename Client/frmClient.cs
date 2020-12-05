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
            db.OpenConnection();
            List<State> data = db.GetByParty(cmbParty.Text);
            dgvDisplay.DataSource = data;
            db.CloseConnection();
        }

        private void cmbCandidate_SelectedIndexChanged(object sender, EventArgs e) {
            db.OpenConnection();
            List<State> data = db.GetByCandidate(cmbCandidate.Text);
            dgvDisplay.DataSource = data;
            db.CloseConnection();
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e) {
            db.OpenConnection();
            List<State> data = new List<State>();
            data.Add(db.GetByState(cmbState.Text));
            dgvDisplay.DataSource = data;
            db.CloseConnection();
        }
    }
}
