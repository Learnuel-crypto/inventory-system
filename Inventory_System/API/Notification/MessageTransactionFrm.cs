using System;
using System.Windows.Forms;

namespace Inventory_System.API.Notification
{
    public partial class MessageTransactionFrm : Form
    {
        public MessageTransactionFrm()
        {
            InitializeComponent();
        }
        static MessageTransactionFrm MsgBox; static DialogResult result = DialogResult.OK;
        /// <summary>
        /// Confirm money amount
        /// </summary>
        /// <param name="message">Message for confirmation</param>
        /// <param name="Caption">MessageBox title</param>
        /// <param name="btnYes"></param>
        /// <param name="btnNo"></param>
        /// <returns></returns>
        public static DialogResult Show(string message, string question, string Caption, string btnYes, string btnNo)
        {
            MsgBox = new MessageTransactionFrm();
            MsgBox.lblMessaege.Text = message;
            MsgBox.lblCaption.Text = Caption;
            MsgBox.lblQuestion.Text = question;
            MsgBox.btn2.Text = btnYes;
            MsgBox.btn1.Text = btnNo;
            MsgBox.ShowDialog();
            return result;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; MsgBox.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; MsgBox.Close();
        }
    }
}
