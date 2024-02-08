namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new();
        Personnage dragon = new Personnage();
        public Form1()
        {
            InitializeComponent();
            joueur.PointsDeVie = 10;
            joueur.PointsDePuissance = 1;
            dragon.PointsDeVie = joueur.PointsDeVie * 3;
            dragon.PointsDePuissance = 3;



        }

        private void ActualiserLabel()
        {
            lbl_pointsVieJoueur.Text = "Vie du Joueur :" + joueur.PointsDeVie.ToString();
            lbl_pointsVieDragon.Text = "Vie du dragon :" + dragon.PointsDeVie.ToString();
            lbl_puissanceAttaqueJoueur.Text = "Attaque du joueur :" + joueur.PointsDePuissance.ToString();
            lbl_puissanceAttaqueDragon.Text = "Attaque du dragon :" + dragon.PointsDePuissance.ToString();
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointsDeVie -= joueur.PointsDePuissance;
            ActualiserLabel();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            ActualiserLabel();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            ActualiserLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLabel();
        }
    }
}