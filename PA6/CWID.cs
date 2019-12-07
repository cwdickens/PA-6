using System;
using System.Windows.Forms;

namespace PA6 {
    public partial class CWID : Form {
        public CWID() {
            InitializeComponent();
        }

        public CWID(string cwid) : this() {
            txtCWID.Text = cwid;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnContinue_Click(object sender, EventArgs e) {
            var cwid = txtCWID.Text;
            var library = new Library(cwid);
            this.Hide();
            library.ShowDialog();
        }
    }
}
