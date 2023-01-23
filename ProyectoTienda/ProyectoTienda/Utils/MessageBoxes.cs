using System.Windows.Forms;

namespace ProyectoTienda.Utils
{
    public static class MessageBoxes
    {
        public static void ShowErrorBox(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        public static void ShowSuccessBox(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool ShowYesNoOptionBox(string message, string caption)
        {
            DialogResult result = MessageBox.Show
            (
                message, caption, 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question
            );

            return result == DialogResult.Yes;
        }
    }
}
