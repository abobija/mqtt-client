using System;
using System.Windows.Forms;

namespace MqttClient
{
    public static class Extensions
    {
        public static void Error(this Form form, Exception ex)
        {
            form.Invoke((Action)(() =>
                MessageBox.Show(form, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ));
        }
    }
}
