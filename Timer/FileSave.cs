using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace Timer
{
	class FileSave
	{
		private static string stAppPath = AppDomain.CurrentDomain.BaseDirectory;

		//==================================
		//Append String to file
		//==================================
		public static bool saveTimetoFile(StringBuilder stbWriteTime)
		{
			try
			{
				StreamWriter stwOutputFile = new StreamWriter(stAppPath + "history.txt", true);
				stwOutputFile.WriteLine(stbWriteTime.ToString());
				stwOutputFile.Close();
			}catch(Exception ex)
			{
				MessageBox.Show("Error");
				Debug.WriteLine(ex);
			}

			Debug.WriteLine(stAppPath);
			Debug.WriteLine(stbWriteTime.ToString());
			return true;
		}


		//==================================
		//Load from file to List
		//==================================
		public static List<String> loadTimetoList()
		{
			List<String> lstReturn = new List<string>();
			try
			{
				using (StreamReader stwInputFile = new StreamReader(stAppPath + "history.txt", true))
				{
					while (stwInputFile.Peek() >= 0)
					{
						var str = stwInputFile.ReadLine();
						if ( str != "")
						{
							lstReturn.Add(str);
						}
						
					}
				}

			}catch(Exception ex)
			{
				Debug.WriteLine(ex);
			}
			return lstReturn;
		}

	}
}
