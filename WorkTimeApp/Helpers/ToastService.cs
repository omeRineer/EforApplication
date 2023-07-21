using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeApp.Helpers
{
    public static class ToastService
    {
        static NotifyIcon Notify;
        static ToastService()
        {
            Notify = new NotifyIcon()
            {
                Visible = true,
                Icon = new Icon("./Icon/worktime.ico"),
                Tag = "Notify",
                Text = "Efor App"
            };
        }

        public static void ShowToast(string title, string message, ToolTipIcon icon, int duration = 3000)
        {
            Notify.ShowBalloonTip(duration, title, message, icon);
        }
    }
}
