using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ERC.BusinessLogic
{
	public class PdfCreator
	{
		/// <summary>
		/// Convert Html page at a given URL to a PDF file using open-source tool wkhtml2pdf
		/// </summary>
		public static bool CreateFromURL(string url, string outputFilePath, bool hideBackground = false, int margin = 10)
		{
			var p = new System.Diagnostics.Process();
			p.StartInfo.FileName = HttpContext.Current.Server.MapPath(@"~\wkhtmltopdf\wkhtmltopdf.exe");

			var switches = String.Format("--print-media-type --margin-top {0}mm --margin-bottom {0}mm --margin-right {0}mm --margin-left {0}mm --page-size Letter --redirect-delay 100", margin);
			if (hideBackground) switches += "--no-background ";

			p.StartInfo.Arguments = switches + " " + url + " " + outputFilePath;

			p.StartInfo.UseShellExecute = false; // needs to be false in order to redirect output
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.RedirectStandardError = true;
			p.StartInfo.RedirectStandardInput = true; // redirect all 3, as it should be all 3 or none
			p.StartInfo.WorkingDirectory = HttpContext.Current.Server.MapPath(@"~\wkhtmltopdf\");

			p.Start();

			// read the output here...
			string output = p.StandardOutput.ReadToEnd();

			// ...then wait n milliseconds for exit (as after exit, it can't read the output)
			p.WaitForExit(60000);

			// read the exit code, close process
			int returnCode = p.ExitCode;
			p.Close();

			// if 0 or 2, it worked (not sure about other values, I want a better way to confirm this)
			return (returnCode == 0 || returnCode == 2);
		}
	}
}
