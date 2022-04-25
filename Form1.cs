using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Factorio_App
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			textBox1.BorderStyle = BorderStyle.None;
			textBox2.BorderStyle = BorderStyle.None;
			textBox3.BorderStyle = BorderStyle.None;
			textBox4.BorderStyle = BorderStyle.None;
			textBox5.BorderStyle = BorderStyle.None;
			textBox6.BorderStyle = BorderStyle.None;
			textBox7.BorderStyle = BorderStyle.None;
			textBox8.BorderStyle = BorderStyle.None;
			textBoxn.BorderStyle = BorderStyle.None;
		}
		string ChartName;
		string code = "";
		double MinX = 10000, MinY = 10000, MaxX = -10000, MaxY = -10000;
		char CaseLetter;
		double[] Function_Terms = new double[100];
		double x,y;
		double PowExponent = 1;
		int[] Function_Sign = new int[99];
		bool[,] ButtonWasClicked = new bool[33, 100];
		bool AreButtonsPressable = false;
		string[] UsedName = new string[6];

		int k = 1, FunctionsCont = 1;

		public void UnpressableButtons()
		{
			button1.Enabled = AreButtonsPressable;
			button2.Enabled = AreButtonsPressable;
			button3.Enabled = AreButtonsPressable;
			button4.Enabled = AreButtonsPressable;
			button5.Enabled = AreButtonsPressable;
			button6.Enabled = AreButtonsPressable;
			button7.Enabled = AreButtonsPressable;
			button8.Enabled = AreButtonsPressable;
			button9.Enabled = AreButtonsPressable;
			button10.Enabled = AreButtonsPressable;
			button11.Enabled = AreButtonsPressable;
			button12.Enabled = AreButtonsPressable;
			button13.Enabled = AreButtonsPressable;
			button14.Enabled = AreButtonsPressable;
			button15.Enabled = AreButtonsPressable;
			button16.Enabled = AreButtonsPressable;
			button17.Enabled = AreButtonsPressable;
			button18.Enabled = AreButtonsPressable;
			button19.Enabled = AreButtonsPressable;
			button20.Enabled = AreButtonsPressable;
			button21.Enabled = AreButtonsPressable;
			button22.Enabled = AreButtonsPressable;
			button23.Enabled = AreButtonsPressable;
			button24.Enabled = AreButtonsPressable;
			button25.Enabled = AreButtonsPressable;
			button26.Enabled = AreButtonsPressable;
			button27.Enabled = AreButtonsPressable;
			button28.Enabled = AreButtonsPressable;
			button29.Enabled = AreButtonsPressable;
			button30.Enabled = AreButtonsPressable;
			button31.Enabled = AreButtonsPressable;
			button32.Enabled = AreButtonsPressable;
		}
		public void LastButtonClear()
		{
			int i;
			for (i = 1; i <= 32; i++)
				ButtonWasClicked[i, k] = false;
		}
		public void Final_y()
		{
			int i;
			y = 0;
			for (i = 1; i <= k; i++)
				y = y + Function_Terms[i] * Function_Sign[i];
			Console.WriteLine("y= " + y);
		}
		public void Stringsep()
		{
			int r = 0;
			k = 1;
			Function_Sign[1] = 1;
			char[] characters = code.ToCharArray();
			for (int i = 1; i <= 99; i++)
				Function_Terms[i] = 1;
			while (r<code.Length)
			{
				CaseLetter = characters[r];
				//Console.WriteLine("code length= " + code.Length + ", r= " + r + ", case letter= " + CaseLetter);
				if (CaseLetter == 'j' || CaseLetter == 'o')
				{
					if (CaseLetter == 'j')
						Function_Sign[k+1] = 1;
					else
						Function_Sign[k+1] = -1;
					Console.WriteLine("Function Sign= " + Function_Sign[k]);
					k++;
					Console.WriteLine("k= " + k);
				}
				else
					Calculator();
				r++;
			}
			Final_y();
		}

		public void DoMathForLastFunction(double l)
		{
			if (ButtonWasClicked[4, k] == true)
				Function_Terms[k] = Function_Terms[k] * Math.Sqrt(l);
			else
						if (ButtonWasClicked[5, k] == true)
			{
				Function_Terms[k] = Function_Terms[k] * Math.Abs(l);
				textBox8.Text += "|";
			}
			else
						if (ButtonWasClicked[9, k] == true)
				Function_Terms[k] = Function_Terms[k] * Math.Pow(PowExponent, l);
			else
						if (ButtonWasClicked[13, k] == true)
				Function_Terms[k] = Function_Terms[k] * Math.Log(l);
			else
			            if (ButtonWasClicked[27, k] == true)
				Function_Terms[k] = Function_Terms[k] / x;
			else
						if (ButtonWasClicked[28, k] == true)
				Function_Terms[k] = Function_Terms[k] * Math.Sin(l);
			else
						if (ButtonWasClicked[29, k] == true)
				Function_Terms[k] = Function_Terms[k] * Math.Cos(l);
			else
						if (ButtonWasClicked[31, k] == true)
				Function_Terms[k] = Function_Terms[k] * Math.Tan(l);
			else
						if (ButtonWasClicked[32, k] == true)
				Function_Terms[k] = Function_Terms[k] * Math.Cos(l) / Math.Sin(l);
			else
				Function_Terms[k] = Function_Terms[k] * l;
		}
		public void Calculator()
		{
			switch (CaseLetter)
			{
				case 'a':
					DoMathForLastFunction(x);
					break;
				case 'b':
					break;
				case 'c':

					break;
				case 'd':

					break;
				case 'e':

					break;
				case 'f':
					Function_Terms[k] = Math.Pow(Function_Terms[k], double.Parse(textBoxn.Text));
					break;
				case 'g':
					DoMathForLastFunction(7);
					break;
				case 'h':
					DoMathForLastFunction(8);
					break;
				case 'i':
					DoMathForLastFunction(9);
					break;
				case 'j':

					break;
				case 'k':
					Function_Terms[k] = Math.Log(Function_Terms[k]);
					break;
				case 'l':
					DoMathForLastFunction(4);
					break;
				case 'm':
					DoMathForLastFunction(5);
					break;
				case 'n':
					DoMathForLastFunction(6);
					break;
				case 'o':
					break;
				case 'p':
					DoMathForLastFunction(Math.E);
					break;
				case 'q':
					DoMathForLastFunction(1);
					break;
				case 'r':
					DoMathForLastFunction(2);
					break;
				case 's':
					DoMathForLastFunction(3);
					break;
				case 't':
					break;
				case 'u':
					int m;
					for (m = 1; m <=x; m++)
						Function_Terms[k] = Function_Terms[k] * m;
					Console.WriteLine(Function_Terms[k]);
					break;
				case 'v':
					Function_Terms[k] = Math.Pow(x, 2);
					break;
				case 'w':
					DoMathForLastFunction(0);
					break;
				case 'x':
					break;
				case 'y':
					//Function_Terms[k] = Function_Terms[k] / x;
					break;
				case 'z':
					if (textBoxn.Text == "x")
						Function_Terms[k] = Function_Terms[k] * Math.Sin(x);
					else
						Function_Terms[k] = Function_Terms[k] * Math.Sin(double.Parse(textBox4.Text));
					break;
				case '1':
					if (textBoxn.Text == "x")
						Function_Terms[k] = Function_Terms[k] * Math.Cos(x);
					else
						Function_Terms[k] = Function_Terms[k] * Math.Cos(double.Parse(textBox4.Text));
					break;
				case '2':
					DoMathForLastFunction(Math.PI);
					break;
				case '3':
					if (textBoxn.Text == "x")
						Function_Terms[k] = Function_Terms[k] * Math.Tan(x);
					else
						Function_Terms[k] = Function_Terms[k] * Math.Tan(double.Parse(textBox4.Text));
					break;
				case '4':
					if (textBoxn.Text == "x")
						Function_Terms[k] = Function_Terms[k] * Math.Cos(x)/Math.Sin(x);
					else
						Function_Terms[k] = Function_Terms[k] * Math.Cos(double.Parse(textBox4.Text))/ Math.Sin(double.Parse(textBox4.Text));
					break;
			}
			//Console.WriteLine("Function Terms= " + Function_Terms[k]);
		}
		public void FillChart()
		{
			for (x = double.Parse(textBox3.Text); x <= double.Parse(textBox4.Text); x=x+0.5) 
			{
				Stringsep();
				if (y >= double.Parse(textBox5.Text) && y <= double.Parse(textBox6.Text))
				{
					if (FunctionsCont == 1)
						chart1.Series[ChartName].Points.AddXY(x, y);
					else
						if (FunctionsCont == 2)
						chart1.Series[ChartName].Points.AddXY(x, y);
					else
						if (FunctionsCont == 3)
						chart1.Series[ChartName].Points.AddXY(x, y);
					else
						if (FunctionsCont == 4)
						chart1.Series[ChartName].Points.AddXY(x, y);
					else
						if (FunctionsCont == 5)
						chart1.Series[ChartName].Points.AddXY(x, y);
				}
			}
			code = "";
			textBox8.Text = "";
		}
		bool TitleWasAdded = false;
		public void button2_Click(object sender, EventArgs e)
		{
			ButtonWasClicked[2, k] = true;
			ChartName = textBox1.Text + "(x)=" + textBox8.Text;
			if (!TitleWasAdded)
			{
				TitleWasAdded = true;
				chart1.Titles.Add(ChartName);
			}
			var chart = chart1.ChartAreas[0];
			chart1.Series[FunctionsCont - 1].Name = ChartName;
			if (5 * float.Parse(textBox3.Text) / 4 < MinX)
			{
				chart.AxisX.Minimum = 5 * float.Parse(textBox3.Text) / 4;
				MinX = 5 * float.Parse(textBox3.Text) / 4;
			}
			if (5 * float.Parse(textBox4.Text) / 4 > MaxX)
			{
				chart.AxisX.Maximum = 5 * float.Parse(textBox4.Text) / 4;
				MaxX = 5 * float.Parse(textBox4.Text) / 4;
			}
			if (5 * float.Parse(textBox5.Text) / 4 < MinY)
			{
				chart.AxisY.Minimum = 5 * float.Parse(textBox5.Text) / 4;
				MinY = 5 * float.Parse(textBox5.Text) / 4;
			}
			if (5 * float.Parse(textBox6.Text) / 4 > MaxY)
			{
				chart.AxisY.Maximum = 5 * float.Parse(textBox6.Text) / 4;
				MaxY = 5 * float.Parse(textBox6.Text) / 4;
			}

			UsedName[FunctionsCont] = textBox1.Text;
			if (FunctionsCont == 1)
			{
				x = double.Parse(textBox4.Text);
				Stringsep();
				if (x < 1 && x > 0)
					chart.AxisX.Interval = x * 2;
				else
					chart.AxisX.Interval = Math.Sqrt(x);
				if (x < 1 && x > 0)
					chart.AxisX.Interval = Math.Sqrt(y * 1000);
				else
					chart.AxisY.Interval = Math.Sqrt(y);
			}
			FillChart();
			FunctionsCont++;
			AreButtonsPressable = false;
			UnpressableButtons();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			textBox1.Height = 40;
			textBox2.Text = textBox1.Text+(" :");
			textBox7.Text = textBox1.Text+"(x) =";
			int i;
			for (i = 1; i <= 99; i++)
				Function_Terms[i] = 1;
			if (textBox1.Text != "")
				AreButtonsPressable = true;
			else
				AreButtonsPressable = false;
			for (i = 1; i <= FunctionsCont; i++)
				if (UsedName[i] == textBox1.Text && FunctionsCont != i)
					AreButtonsPressable = false;
			UnpressableButtons();
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (Function_Terms[k] != 1)
				textBox8.Text += "·";
			code = code + "a";
			textBox8.Text += "x";
			ButtonWasClicked[3, k] = true;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (Function_Terms[k] != 1)
				textBox8.Text += "·";
			code = code + "b";
			textBox8.Text += "√";
			LastButtonClear();
			ButtonWasClicked[4, k] = true;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (Function_Terms[k] != 1)
				textBox8.Text += "·";
			code = code + "c";
			textBox8.Text += "|";
			LastButtonClear();
			ButtonWasClicked[5, k] = true;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (Function_Terms[k] != 1)
				textBox8.Text += "·";
			code = code + "d";
			textBox8.Text = "";
			LastButtonClear();
			ButtonWasClicked[6, k] = true;
			code = "";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (Function_Terms[k] != 1)
				textBox8.Text += "·";
			code = code + "e";
			textBox8.Text += "e";
			//LastButtonClear();
			ButtonWasClicked[7, k] = true;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (textBoxn.Text != "")
			{
				code = code + "f";
				textBox8.Text += "^" + textBoxn.Text; //de modificat
			}
			LastButtonClear();
			ButtonWasClicked[8, k] = true;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			code = code + "g";
			textBox8.Text += "7";
			//LastButtonClear();
			ButtonWasClicked[9, k] = true;
		}
		private void button10_Click(object sender, EventArgs e)
		{
			code = code + "h";
			textBox8.Text += "8";
			//LastButtonClear();
			ButtonWasClicked[10, k] = true;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			code = code + "i";
			textBox8.Text += "9";
			//LastButtonClear();
			ButtonWasClicked[11, k] = true;
		}
		private void button12_Click(object sender, EventArgs e)
		{
			code = code + "j"; 
			textBox8.Text += "+";
			LastButtonClear();
			ButtonWasClicked[12, k] = true;
			k++;
		}

		private void button13_Click(object sender, EventArgs e)
		{
			if (Function_Terms[k] != 1)
				textBox8.Text += "·";
			code = code + "k";
			textBox8.Text += "ln";
			LastButtonClear();
			ButtonWasClicked[13, k] = true;
		}

		private void button14_Click(object sender, EventArgs e)
		{
			code = code + "l";
			textBox8.Text += "4";
			//LastButtonClear();
			ButtonWasClicked[14, k] = true;
		}

		private void button15_Click(object sender, EventArgs e)
		{
			code = code + "m";
			textBox8.Text += "5";
			//LastButtonClear();
			ButtonWasClicked[15, k] = true;
		}

		private void button16_Click(object sender, EventArgs e)
		{
			code = code + "n";
			textBox8.Text += "6";
			//LastButtonClear();
			ButtonWasClicked[16, k] = true;
		}

		private void button17_Click(object sender, EventArgs e)
		{
			code = code + "o";
			textBox8.Text += "-";
			LastButtonClear();
			ButtonWasClicked[17, k] = true;
			k++;
		}

		private void button18_Click(object sender, EventArgs e)
		{
			code = code + "p";
			if (Function_Terms[k] != 1)
				textBox8.Text += "·";
			textBox8.Text += "e";
			//LastButtonClear();
			ButtonWasClicked[18, k] = true;
		}

		private void button19_Click(object sender, EventArgs e)
		{
			code = code + "q";
			textBox8.Text += "1";
			//LastButtonClear();
			ButtonWasClicked[19, k] = true;
		}

		private void button20_Click(object sender, EventArgs e)
		{
			code = code + "r";
			textBox8.Text += "2";
			//LastButtonClear();
			ButtonWasClicked[20, k] = true;
		}

		private void button21_Click(object sender, EventArgs e)
		{
			code = code + "s";
			textBox8.Text += "3";
			//LastButtonClear();
			ButtonWasClicked[21, k] = true;
		}

		private void button22_Click(object sender, EventArgs e)
		{
			code = code + "t";
			textBox8.Text += "·";
			LastButtonClear();
			ButtonWasClicked[22, k] = true;
		}

		private void button23_Click(object sender, EventArgs e)
		{
			if (Function_Terms[k] != 1)
				textBox8.Text += "·";
			code = code + "u";
			textBox8.Text += "n!";
			LastButtonClear();
			ButtonWasClicked[23, k] = true;
		}

		private void button24_Click(object sender, EventArgs e)
		{
			code = code + "v";
			textBox8.Text += "x²";
			LastButtonClear();
			ButtonWasClicked[24, k] = true;
		}

		private void button25_Click(object sender, EventArgs e)
		{
			code = code + "w";
			textBox8.Text += "0";
			//LastButtonClear();
			ButtonWasClicked[25, k] = true;
		}

		private void button26_Click(object sender, EventArgs e)
		{
			code = code + "x";
			textBox8.Text += ",";
			LastButtonClear();
			ButtonWasClicked[26, k] = true;
		}
		private void button27_Click(object sender, EventArgs e)
		{
			code = code + "y";
			textBox8.Text += ":";
			LastButtonClear();
			ButtonWasClicked[27, k] = true;
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{
			UnpressableButtons();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button28_Click(object sender, EventArgs e)
		{
			if (Function_Terms[k] != 1)
				textBox8.Text += "·";
			textBox8.Text += "sin ";
			if (textBoxn.Text != "")
			{
				code = code + "z";
				textBox8.Text += textBoxn.Text;
			}
			LastButtonClear();
			ButtonWasClicked[28, k] = true;
		}

		private void button29_Click(object sender, EventArgs e)
		{
			if (Function_Terms[k] != 1)
				textBox8.Text += "·";
			textBox8.Text += "cos ";
			if (textBoxn.Text != "")
			{
				code = code + "1";
				textBox8.Text += textBoxn.Text;
			}
			LastButtonClear();
			ButtonWasClicked[29, k] = true;
		}

		private void button30_Click(object sender, EventArgs e)
		{
			code = code + "2";
			textBox8.Text += "·π";
			//LastButtonClear();
			ButtonWasClicked[30, k] = true;
		}

		private void button31_Click(object sender, EventArgs e)
		{
			if (Function_Terms[k] != 1)
				textBox8.Text += "·";
			textBox8.Text += "tg ";
			if (textBoxn.Text != "")
			{
				code = code + "3";
				textBox8.Text += textBoxn.Text;
			}
			LastButtonClear();
			ButtonWasClicked[31, k] = true;
		}

		private void button32_Click(object sender, EventArgs e)
		{
			if (Function_Terms[k] != 1)
				textBox8.Text += "·";
			textBox8.Text += "ctg ";
			if (textBoxn.Text != "")
			{
				code = code + "4";
				textBox8.Text += textBoxn.Text;
			}
			LastButtonClear();
			ButtonWasClicked[32, k] = true;
		}

	}
}
