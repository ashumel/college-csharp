using System;

namespace lab_10
{
	public enum Vendor
	{
		Apple, Samsung, Xiaomi
	}
	public class Phone
	{
		private readonly long _imei;
		private readonly Vendor _vendor;
		private readonly string _model;

		public string GetModel => _model;

		public Phone() // Debug
		{
			_imei = 337027085314034;
			_vendor = Vendor.Apple;
			_model = "iPhone 14";
		}
		
		public Phone(long imei, Vendor vendor, string model)
		{
			this._vendor = vendor;
			this._model = model;
			_imei = imei;
		}

		public void Show()
		{
			Console.WriteLine($"Vendor: {_vendor}\n" +
			                  $"Model: {_model}\n" +
			                  $"IMEI: {_imei}");
		}
	}
}