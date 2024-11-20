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
	/// Description of area.
	/// </summary>
	public partial class area : Form
	{
		public area()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Button3Click(object sender, EventArgs e)
		{
			int a = Int32.Parse(txt_cua.Text);
			a = a*a;
			string pass;
			pass = a.ToString();
			Precio Precio =new Precio(pass);
			Precio.Show();
		}
	}
}
