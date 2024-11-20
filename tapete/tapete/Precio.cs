/*
 * Created by SharpDevelop.
 * User: CC2-PC20
 * Date: 20/11/2024
 * Time: 07:36 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tapete
{
	/// <summary>
	/// Description of Precio.
	/// </summary>
	public partial class Precio : Form
	{
		public Precio(string text)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			string a = text;
			label6.Text=a;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
