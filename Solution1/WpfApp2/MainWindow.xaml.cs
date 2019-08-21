﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
	/// <summary>
	/// MainWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class MainWindow : Window
	{
		tmpbnd ttmpbnd = new tmpbnd();

		public MainWindow()
		{
			InitializeComponent();
			//this.DataContext = this;
			Binding binding = new Binding("Text");
			binding.Source = textBox;
			textBox1.SetBinding(TextBox.TextProperty, binding);
		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}
	}

	public class tmpbnd
	{
		public string tmpbind { get; set; }

	}
}