namespace ExperienciaUsuario
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
				ApplicationConfiguration.Initialize();

				Catalogo f1 = new Catalogo();
				f1.Show();
				Application.Run();
		
		}
	}
}