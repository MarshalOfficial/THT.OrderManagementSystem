using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THT.OrderManagementSystem.Framework
{
    public static class ErrorLog
    {
        public static void SaveLog(Exception ex)
        {
            var Error =
                        ex.Message + (ex.InnerException?.Message ?? "") +
                        (ex.InnerException?.InnerException?.Message ?? "");
            System.IO.File.AppendAllText(Path.GetDirectoryName(Application.ExecutablePath) + @"\ErrorLog.txt", Error + Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine);
        }
    }
}
//test