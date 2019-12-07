using System;
using System.Windows.Forms;

namespace PA6 {
    public partial class UpsertBook : Form {
        private readonly string mode;
        private readonly string _id;

        public UpsertBook(string mode = "new") {
            this.mode = mode;
            InitializeComponent();
            InitializeForm();
        }

        public UpsertBook(Book selectedBook) : this("edit") {
            _id = selectedBook._id;
            PopulateFormFields(selectedBook);
        }

        private void InitializeForm() {
            if(mode == "edit") {
                this.Text = "Edit Book";
                this.btnUpsert.Text = "Update";
            } else {
                this.Text = "Add Book";
                this.btnUpsert.Text = "Add";
            }
        }

        private void PopulateFormFields(Book book) {
            this.txtTitle.Text = book.Title;
            this.txtAuthor.Text = book.Author;
            this.txtGenre.Text = book.Genre;
            this.txtCopiesAvailable.Text = book.Copies.ToString();
            this.txtISBN.Text = book.ISBN;
            this.txtLength.Text = book.Length.ToString();
            this.picBx.ImageLocation = book.Cover;
            this.txtUrl.Text = this.picBx.ImageLocation;
        }

        private void btnUpsert_Click(object sender, System.EventArgs e) {
            if(!InputFieldsValid()) {
                MessageBox.Show("All inputs must be valid!");
                return;
            }

            NewOrUpdatedBook = new Book {
                _id = this._id,
                Author = txtAuthor.Text,
                Copies = int.Parse(txtCopiesAvailable.Text),
                Cover = picBx.ImageLocation,
                Genre = txtGenre.Text,
                ISBN = txtISBN.Text,
                Length = int.Parse(txtLength.Text),
                Title = txtTitle.Text
            };

            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e) {
            IsCanceled = true;
            this.Close();
        }

        private void btnPreview_Click(object sender, System.EventArgs e) {
            if(!IsUrlValid(txtUrl.Text)) {
                MessageBox.Show("Url is not valid!");
                return;
            }

            picBx.ImageLocation = txtUrl.Text;
        }

        public Book NewOrUpdatedBook { get; private set; }

        public string Mode {
            get {
                return this.mode;
            }
        }

        public bool IsCanceled { get; private set; }

        private bool IsUrlValid(string url) {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) && uriResult.Scheme == Uri.UriSchemeHttps;
        }

        private bool InputFieldsValid() {
            var inValid = string.IsNullOrEmpty(txtTitle.Text) ||
                string.IsNullOrEmpty(txtAuthor.Text) ||
                string.IsNullOrEmpty(txtGenre.Text) ||
                string.IsNullOrEmpty(txtCopiesAvailable.Text) ||
                string.IsNullOrEmpty(txtISBN.Text) ||
                string.IsNullOrEmpty(txtLength.Text) ||
                string.IsNullOrEmpty(txtUrl.Text) ||
                string.IsNullOrEmpty(picBx.ImageLocation);

            return !inValid;
        }
    }
}
