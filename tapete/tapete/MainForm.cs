/*
 * Created by SharpDevelop.
 * User: CC2-PC20
 * Date: 20/11/2024
 * Time: 07:35 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tapete
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			area area=new area();
			area.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			cantidad cantidad=new cantidad();
			cantidad.Show();			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Precio Precio= new Precio("c");
			Precio.Show();			
		}
	}
}
