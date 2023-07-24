using BMIdemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIdemo.MVVM.ViewModels
{
	public class BMIViewModel
	{
		public BMIModel BMI { get; set; }
		public BMIViewModel()
		{
			this.BMI = new BMIModel();
			this.BMI.Height = 180;
			this.BMI.Weight = 73;
		}
	}
}
