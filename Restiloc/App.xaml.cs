using Restiloc.Modeles;

namespace Restiloc;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Expertise E1 = new Pool_Garage("lieu", "adresse", "immatriculation", "marque", "modele", new DateTime(2022, 11, 29));
		E1.ChangerEtatExpertise();
        Expertise E2= new RDV_Client("nc","tel","mail","lieu", "adresse", "immatriculation", "marque", "modele", new DateTime(2022, 11, 29));
        E2.ChangerEtatExpertise();
        MainPage = new AppShell();
	}
}
