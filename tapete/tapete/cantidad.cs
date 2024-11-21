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
	/// Description of cantidad.
	/// </summary>
	public partial class cantidad : Form
	{
		public cantidad(string area)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			label12.Text=area;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int multi=0;
		void Button2Click(object sender, EventArgs e)
		{
			//Convertir datos a enteros
			int a = Int32.Parse(txt_asr.Text);
			int a2 = Int32.Parse(textBox2.Text);
			int a3 = Int32.Parse(textBox3.Text);
			int a4 = Int32.Parse(textBox4.Text);
			int a5 = Int32.Parse(textBox5.Text);
			int a6 = Int32.Parse(textBox6.Text);
			int a7 = Int32.Parse(textBox7.Text);
			int a8 = Int32.Parse(textBox8.Text);
			int a9 = Int32.Parse(textBox9.Text);
			//Sumar los datos
			a=a+a2+a3+a4+a9;
			multi=(a5*a8)*a6;
			multi=multi+(a7*a5);
			label11.Text=a.ToString();
			//Pasar los datos al siguente Form (Precio)
			string pass=a.ToString();
			string pass1=label12.Text;
			string pass2=multi.ToString();
			Precio Precio=new Precio(pass1, pass, pass2);
			Precio.Show();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//Volver
			this.Close();
		}
	}
}
