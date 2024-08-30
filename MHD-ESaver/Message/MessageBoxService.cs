using System;
using System.Windows.Forms;

namespace MHD_ESaver.Message
{
    public enum MessageBoxType
    {
        INFORMATION,
        SUCCESS,
        WARNING,
        ERROR,
    }

    public class MessageBoxService
    {
        /// <summary>
        /// Sends the user a messagebox with two choices "yes" or "no".
        /// Returns true when the user clicks yes.
        /// </summary>
        /// <returns></returns>
        public bool SendChoice(String message)
        {
            var result = MessageBox.Show(message, MessageConstants.MESSAGEBOX_PREFIX_TITLE + MessageConstants.MESSAGEBOX_TITLE_QUESTION, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return result.Equals(DialogResult.OK);
           
        }
        public void Send(MessageBoxType type, String message)
        {
            switch (type)
            {
                case MessageBoxType.INFORMATION:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_PREFIX_TITLE + MessageConstants.MESSAGEBOX_TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case MessageBoxType.SUCCESS:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_PREFIX_TITLE + MessageConstants.MESSAGEBOX_TITLE_SUCCESS, MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
                case MessageBoxType.WARNING:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_PREFIX_TITLE + MessageConstants.MESSAGEBOX_TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case MessageBoxType.ERROR:
                    MessageBox.Show(message, MessageConstants.MESSAGEBOX_PREFIX_TITLE + MessageConstants.MESSAGEBOX_TITLE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
