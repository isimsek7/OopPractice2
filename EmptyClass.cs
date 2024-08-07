using System;
namespace ClassObj
{
	public class Bebek
	{
		public Bebek()
		{
            Console.WriteLine("Ingaa!");
            DateTime tarih = DateTime.Now;
            _dogumTarihi = tarih.ToLongDateString();
        }
		public Bebek(string ad, string soyad)
		{
			Console.WriteLine("Ingaa!");
			_ad = ad;
			_soyAd = soyad;
			_dogumTarihi = DateTime.Now.ToLongDateString();
			Console.WriteLine("{0} tarihinde, {1} {2}, isimli bir bebek dunyaya geldi.", _dogumTarihi, _ad, _soyAd);
		}

		public string _ad { get; set; }
		public string _soyAd { get; set; }
		public string _dogumTarihi{ get; set; }


		public void ozet()
		{
            _dogumTarihi = DateTime.Now.ToLongDateString();
			Console.WriteLine("{0} tarihinde, {1} {2}, isimli bir bebek dunyaya geldi.", _dogumTarihi, _ad, _soyAd);
            
        }
	}
	
}

