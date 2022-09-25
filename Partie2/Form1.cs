namespace Partie2;

public partial class Form1 : Form
{
    public List<Personne> personnes;
    public string nom;
    public string prenom;
    public DateTime dateNaissance;
    public Form1()
    {
        InitializeComponent();

        btn1.Click += btn1_Click;
    }

    private void btn1_Click(object sender, EventArgs e){
       this.nom = txt1.Text;
       this.prenom = txt2.Text;
    //    this.dateNaissance = new DateTime();
    }
}
