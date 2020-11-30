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
        //DBAccess db = new DBAccess();

        public frmClient() {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e) {
            //db.OpenConnection();
        }

        private void cmbParty_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cmbCandidate_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
