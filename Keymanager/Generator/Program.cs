using System;
using System.Windows.Forms;

namespace Generator
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002FC1 File Offset: 0x000011C1
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Generator());
		}
	}
}
