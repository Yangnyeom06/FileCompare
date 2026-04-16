namespace FileCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopyFromLeft_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를 선택하세요.";

                if (!string.IsNullOrWhiteSpace(txtLeftDir.Text) && Directory.Exists(txtLeftDir.Text))
                {
                    dlg.SelectedPath = txtLeftDir.Text;
                }
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtLeftDir.Text = dlg.SelectedPath;
                    PopulateListView(lvwLeftDir, dlg.SelectedPath);

                    if (!string.IsNullOrWhiteSpace(txtRightDir.Text))
                    {
                        CompareAndDisplay(txtLeftDir.Text, txtRightDir.Text);
                    }
                }
            }
        }

        private void btnCopyFromRight_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를 선택하세요.";

                if (!string.IsNullOrWhiteSpace(txtLeftDir.Text) && Directory.Exists(txtLeftDir.Text))
                {
                    dlg.SelectedPath = txtLeftDir.Text;
                }
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRightDir.Text = dlg.SelectedPath;
                    PopulateListView(lvwRightDir, dlg.SelectedPath);

                    if (!string.IsNullOrWhiteSpace(txtLeftDir.Text))
                    {
                        CompareAndDisplay(txtRightDir.Text, txtLeftDir.Text);
                    }
                }
            }
        }

        private void PopulateListView(ListView lv, string folderPath)
        {
            lv.BeginUpdate(); lv.Items.Clear();
            try
            {
                var dirs = Directory.EnumerateDirectories(folderPath).Select(p => new DirectoryInfo(p)).OrderBy(d => d.Name);
                foreach (var d in dirs)
                {
                    var item = new ListViewItem(d.Name); item.SubItems.Add("<DIR>");
                    item.SubItems.Add(d.LastWriteTime.ToString("g"));
                    lv.Items.Add(item);
                }

                var files = Directory.EnumerateFiles(folderPath).Select(p => new FileInfo(p)).OrderBy(f => f.Name);
                foreach (var f in files)
                {
                    var item = new ListViewItem(f.Name);
                    item.SubItems.Add(f.Length.ToString("N0") + " 바이트");
                    item.SubItems.Add(f.LastWriteTime.ToString("g"));
                    lv.Items.Add(item);
                }

                for (int i = 0; i < lv.Columns.Count; i++)
                {
                    lv.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(this, "폴더를 찾을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, "입출력 오류: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lv.EndUpdate();
            }
        }
        private void CompareAndDisplay(string leftPath, string rightPath)
        {
            lvwLeftDir.Items.Clear();
            lvwRightDir.Items.Clear();

            var leftFiles = Directory.GetFiles(leftPath)
                .Select(f => new FileInfo(f)).ToList();

            var rightFiles = Directory.GetFiles(rightPath)
                .Select(f => new FileInfo(f)).ToList();

            var allNames = leftFiles.Select(f => f.Name)
                .Union(rightFiles.Select(f => f.Name));

            foreach (var name in allNames)
            {
                var lf = leftFiles.FirstOrDefault(f => f.Name == name);
                var rf = rightFiles.FirstOrDefault(f => f.Name == name);

                // 👉 여기부터 네 코드 그대로 사용
                if (lf != null)
                {
                    var litem = new ListViewItem(lf.Name);
                    litem.SubItems.Add(lf.Length.ToString());
                    litem.SubItems.Add(lf.LastWriteTime.ToString("g"));

                    if (rf != null)
                    {
                        if (lf.LastWriteTime == rf.LastWriteTime)
                            litem.ForeColor = Color.Black;
                        else if (lf.LastWriteTime > rf.LastWriteTime)
                            litem.ForeColor = Color.Red;
                        else
                            litem.ForeColor = Color.Gray;
                    }
                    else
                    {
                        litem.ForeColor = Color.Purple;
                    }

                    lvwLeftDir.Items.Add(litem);
                }

                if (rf != null)
                {
                    var ritem = new ListViewItem(rf.Name);
                    ritem.SubItems.Add(rf.Length.ToString());
                    ritem.SubItems.Add(rf.LastWriteTime.ToString("g"));

                    if (lf != null)
                    {
                        if (rf.LastWriteTime == lf.LastWriteTime)
                            ritem.ForeColor = Color.Black;
                        else if (rf.LastWriteTime > lf.LastWriteTime)
                            ritem.ForeColor = Color.Red;
                        else
                            ritem.ForeColor = Color.Gray;
                    }
                    else
                    {
                        ritem.ForeColor = Color.Purple;
                    }

                    lvwRightDir.Items.Add(ritem);
                }
            }
        }
    }
}