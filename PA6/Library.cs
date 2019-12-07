using System.Windows.Forms;

namespace PA6 {
    public partial class Library : Form {
        private readonly string cwid;

        public Library() {
            InitializeComponent();
            this.FormClosed += this.Library_FormClosed;
            this.lstBooks.SelectedValueChanged += this.LstBooks_SelectedValueChanged;
        }

        public Library(string cwid) : this() {
            this.cwid = cwid;
            LoadBooks();
        }

        private void LstBooks_SelectedValueChanged(object sender, System.EventArgs e) {
            var book = GetSelectedBook();
            if(book == null) {
                SelectItemInListBox(0);
                return;
            }

            var isRented = book.IsRented();
            this.btnRent.Enabled = !isRented;
            this.btnReturn.Enabled = !this.btnRent.Enabled;

            LoadForm(book);
        }

        private void Library_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void LoadBooks() {
            var books = BookFile.GetAllBooks(cwid);

            foreach(var book in books) {
                lstBooks.Items.Add(book);
            }

            if(books.Count > 0) {
                lstBooks.SelectedIndex = 0;
            }
        }

        private void LoadForm(Book book) {
            this.txtTitle.Text = book.Title;
            this.txtAuthor.Text = book.Author;
            this.txtGenre.Text = book.Genre;
            this.txtCopiesAvailable.Text = book.Copies.ToString();
            this.txtISBN.Text = book.ISBN.ToString();
            this.txtLength.Text = book.Length.ToString();

            this.picBx.ImageLocation = book.Cover;
            this.picBx.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnNew_Click(object sender, System.EventArgs e) {
            var upsertBook = new UpsertBook();
            upsertBook.ShowDialog();

            if(upsertBook.IsCanceled) return;

            var book = upsertBook.NewOrUpdatedBook;
            book.CWID = cwid;
            var mode = upsertBook.Mode;

            BookFile.SaveBook(book, cwid, mode);

            this.lstBooks.Items.Add(book);
        }

        private void btnEdit_Click(object sender, System.EventArgs e) {
            if(lstBooks.SelectedItem == null) {
                MessageBox.Show("Select a book to edit");
                return;
            }

            var selectedIndex = lstBooks.SelectedIndex;
            var selectedBook = lstBooks.SelectedItem as Book;
            var upsertBook = new UpsertBook(selectedBook);
            upsertBook.ShowDialog();

            if(upsertBook.IsCanceled) return;

            var book = upsertBook.NewOrUpdatedBook;
            book.CWID = cwid;
            var mode = upsertBook.Mode;

            BookFile.SaveBook(book, cwid, mode);

            lstBooks.Items.RemoveAt(selectedIndex);
            lstBooks.Items.Insert(selectedIndex, book);
            SelectItemInListBox(selectedIndex);
        }

        private void btnDelete_Click(object sender, System.EventArgs e) {
            if(lstBooks.SelectedItem == null) {
                MessageBox.Show("Select a book to edit");
                return;
            }
            
            var selectedBook = lstBooks.SelectedItem as Book;

            var message = MessageBox.Show($"Are you sure you want to delete\n'{selectedBook.Title}'", "Delete Movie", MessageBoxButtons.YesNo);
            if(message == DialogResult.No) return;

            BookFile.DeleteBook(selectedBook, cwid);

            lstBooks.Items.Remove(selectedBook);
        }

        private void btnClose_Click(object sender, System.EventArgs e) {
            this.Hide();
            var cwidForm = new CWID(cwid);
            cwidForm.ShowDialog();
        }

        private void btnRent_Click(object sender, System.EventArgs e) {
            var book = GetSelectedBook();
            var result = book.Rent();
            this.btnRent.Enabled = !result;
            this.btnReturn.Enabled = result;
            this.txtCopiesAvailable.Text = book.Copies.ToString();
        }

        private void btnReturn_Click(object sender, System.EventArgs e) {
            var book = GetSelectedBook();
            var result = book.Return();
            this.btnReturn.Enabled = !result;
            this.btnRent.Enabled = result;
            this.txtCopiesAvailable.Text = book.Copies.ToString();
        }

        private void SelectItemInListBox(int index) {
            if(lstBooks.Items.Count > index) {
                lstBooks.SelectedIndex = index;
            }
        }

        private Book GetSelectedBook() {            
            var book = lstBooks.SelectedItem as Book;
            return book;
        }
    }
}
