namespace PertemuanEnam
{
	public class Guru
	{
        public string NIP { get; set; }

		public virtual void Mengajar()
		{
			Console.WriteLine("Guru sedang mengajar");
		}

		private void Menyapa()
		{
			Console.WriteLine("Hallo murid-murid");
		}
    }

	public class GuruBahasaIndonesia : Guru
	{
        public string Nama { get; set; }

        public override void Mengajar()
        {
            Console.WriteLine("Guru sedang mengajar pelajaran bahasa indoneisa");
        }
    }


	public abstract class Handphone
	{
		public abstract void Kamera();
	}

	public class Redmi : Handphone
	{
        public override void Kamera()
        {
			Console.WriteLine("Menyalakan kamera");
        }
    }
}