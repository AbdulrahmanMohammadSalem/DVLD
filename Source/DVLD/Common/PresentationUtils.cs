using DVLD.Properties;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Common {
    internal class PresentationUtils {
        internal static void DisplayBubbleNotification_ReportExportSuccess(string fullPath) {
            var _ni = new NotifyIcon {
                BalloonTipIcon = ToolTipIcon.Info,
                BalloonTipTitle = Resources.msg_success,
                BalloonTipText = Resources.msg_documentExportedSuccessfully,
                Icon = Resources.DVLD_Logo,
                Visible = true,
                Tag = fullPath
            };

            _ni.BalloonTipClicked += NotifyIcon1_BalloonTipClicked;
            _ni.BalloonTipClosed += NotifyIcon1_BalloonTipClosed;

            _ni.ShowBalloonTip(0);
        }

        private static void NotifyIcon1_BalloonTipClosed(object sender, EventArgs e) => _EndNotifyIcon(sender as NotifyIcon);

        private static void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e) {
            var _sender = (NotifyIcon) sender;

            BusinessUtils.FileUtils.HighlightFileInExplorer(_sender.Tag.ToString());

            _EndNotifyIcon(_sender);
        }

        private static void _EndNotifyIcon(NotifyIcon ni) {
            ni.Visible = false;

            ni.BalloonTipClicked -= NotifyIcon1_BalloonTipClicked;
            ni.BalloonTipClosed -= NotifyIcon1_BalloonTipClosed;

            ni.Dispose();
        }
    }
}
