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
		//Obtener datos de otro form
		public Precio(string area, string mat, string obra)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//Guardar los datos
			string a = area;
			label6.Text=a;
			lbl_mat.Text=mat;
			label7.Text=obra;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//Hacer el calculo final
			int a = Int32.Parse(lbl_mat.Text);	
			int a2 = Int32.Parse(label7.Text);	
			label9.Text=a+a2.ToString();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//Volver
			this.Close();
		}
	}
}
