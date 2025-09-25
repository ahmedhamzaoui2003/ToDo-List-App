using System;
using System.Windows.Forms;

namespace Learning_C_
{
    public partial class frmToDoListApp : Form
    {
        public frmToDoListApp()
        {
            InitializeComponent();
        }

        // hedhi kif tenzel 3al enter you can add automatically el task mte3ek 

        private void tbNewTask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAddNewTask.PerformClick();
            }
        }

        private bool IsTaskExistent(string task)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.Items[i].ToString().ToLower() == task.ToLower())
                    return true;
            }
            return false;
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            if (tbNewTask.Text == "")
            {
                MessageBox.Show("Please enter a task before adding it !", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if (IsTaskExistent(tbNewTask.Text))
            {
                MessageBox.Show("This task already exists in your to-do list !", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tbNewTask.Text = "";
                return;
            }
            checkedListBox1.Items.Add(tbNewTask.Text);
            tbNewTask.Text = "";
        }

        private void btnShowSelectedTasks_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Zero Checked Tasks !", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
        }

        private void btnRemoveAllTasks_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("Cannot not remove all the tasks !", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            checkedListBox1.Items.Clear();
        }

        private void btnCheckAllTasks_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("Zero tasks to Check!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, true);
        }

        private void btnUncheckAllTasks_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("Zero tasks to Uncheck!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
        }

        private void btnRemoveSelectedTask_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem == null || checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("NO task is selected / No task to remove !", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            byte selectedTask = ((byte)checkedListBox1.SelectedIndex);
            checkedListBox1.Items.RemoveAt(selectedTask);
        }



    }
}
