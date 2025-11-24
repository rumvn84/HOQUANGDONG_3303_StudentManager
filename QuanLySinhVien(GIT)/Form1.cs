using static QuanLySinhVien_GIT_.Form1;

namespace QuanLySinhVien_GIT_
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }
        public class Student
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Class { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng sinh viên mới từ dữ liệu người dùng nhập
            Student s = new Student()
            {
                Name = txtname.Text,
                Gender = gender.Text,
                Class = txtlop.Text
            };
            // Thêm vào danh sách
            students.Add(s);
            // Hiển thị lại danh sách
            board.DataSource = null;
            board.DataSource = students;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (board.CurrentRow != null)
            {
                int index = board.CurrentRow.Index;
                students[index].Name = txtname.Text;
                students[index].Gender = gender.Text;
                students[index].Class = txtlop.Text;
                board.DataSource = null;
                board.DataSource = students;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string keyword = txtname.Text.ToLower();
            var result = students.FindAll(s => s.Name.ToLower().Contains(keyword));
            board.DataSource = null;
            board.DataSource = result;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void board_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void board_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtname.Text = board.Rows[e.RowIndex].Cells[0].Value.ToString();
                gender.Text = board.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtlop.Text = board.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string keyword = txtname.Text.ToLower();
            var result = students.FindAll(s => s.Name.ToLower().Contains(keyword));
            board.DataSource = null;
            board.DataSource = result;
        }
    }
}
