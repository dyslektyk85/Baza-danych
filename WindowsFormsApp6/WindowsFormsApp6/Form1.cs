using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string g="zap.jpg";
            InitializeComponent();
           
     
            Image image1 = Image.FromFile(g);
            pictureBox1.Image = image1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random los = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x=0;
            string y;
            int seed= System.DateTime.Now.Millisecond;
            System.Random los = new Random(seed);

            if (radioButton2.Checked == true)
            {
                x = los.Next(1, 8);

                y = x.ToString() + ".jpg";
                Image image1 = Image.FromFile(y);
                pictureBox1.Image = image1;
            }
            if (radioButton1.Checked == true)
            {
                x = los.Next(8, 15);

                y = x.ToString() + ".jpg";
                Image image1 = Image.FromFile(y);
                pictureBox1.Image = image1;
            }

            if (x==1)
            {
                textBox1.Text = "Albert Einstein - uważany za jednego z największych lub największego fizyka XX wieku, obok lub przed innymi twórcami mechaniki kwantowej jak Paul Dirac, Werner Heisenberg czy Erwin Schrödinger. Jego ogólna teoria względności jest uważana za jeden z największych przełomów w fizyce XX wieku, obok wspomnianej teorii kwantów.";
            }
            if (x == 2)
            {
                textBox1.Text = "Belizariusz, łac. Belisarius, gr. Βελισάριος, właściwie Flavius Belisarius (ur. ok. 505, zm. w marcu 565) – wódz bizantyjski, który prowadził zwycięskie kampanie wojenne w czasach panowania Justyniana I Wielkiego.";
            }
            if (x == 3)
            {
                textBox1.Text = "Neron (Lucius Domitius Ahenobarbus, po adopcji przez Klaudiusza Nero Claudius Caesar Drusus Germanicus, ur. 15 grudnia 37 w Ancjum, zm. 9 czerwca 68 w Rzymie) – piąty cesarz rzymski w latach 54–68, syn Gnejusza Domicjusza Ahenobarbusa i Agrypiny Młodszej, późniejszej żony cesarza Klaudiusza.";
                    }
            if (x == 4)
            {
                textBox1.Text = "Łosoś szlachetny, łosoś atlantycki, łosoś pospolity, łosoś europejski, łosoś (Salmo salar) – ryba z rodziny łososiowatych (Salmonidae). W północnej części Atlantyku, w rzekach Ameryki Północnej, w Europie od Portugalii po Morze Białe, Północne i Bałtyk. W jeziorach Ładoga i Onega tworzy formy wyłącznie słodkowodne.";
                    }
            if (x==5)
            {
                textBox1.Text = "Usama ibn Ladin, Osama bin Laden (arab. أسامة بن لادن, Usāma ibn Lādin; ur. 10 marca 1957 w Rijadzie, zm. 2 maja 2011 w Abbottabadzie) – saudyjski terrorysta i milioner, współzałożyciel i przywódca Al-Ka’idy.";
            }
            if (x == 6)
            {
                textBox1.Text = "Bolesław I Chrobry (Wielki) (ur. 967, zm. 17 czerwca 1025) – władca Polski z dynastii Piastów, pierwszy koronowany król Polski (od 1025), w latach 1003–1004 także książę Czech jako Bolesław IV, książę Polski od 992. Był synem Mieszka I, księcia Polski i Dobrawy, czeskiej księżniczki. Objął rządy w 992, wypędzając krótko potem swoją macochę Odę i przyrodnich braci.";
            }
            if(x==7)
            {
                textBox1.Text = "Gajusz Juliusz Cezar (Gaius Iulius Caesar), ur. 12 lipca 100 p.n.e. (13 lipca 102 r. p.n.e. – koncepcja Mommsena i Diona) w Rzymie, zm. 15 marca 44 r. p.n.e. tamże – rzymski polityk, wódz, dyktator i pisarz. Jeden z członków stronnictwa popularów, spowinowacony z Cynną i Mariuszem. Po ich śmierci piastował kolejno urzędy kwestora, edyla, pretora, konsula, imperatora oraz dyktatora. Sławę zdobył dzięki namiestnictwu w Galii i dzięki pomocy swych żołnierzy udało się mu pokonać opozycję, skupioną wokół senatu i Pompejusza.";
            }
            if (x==8)
            {
                textBox1.Text = "Joanna d’Arc (fr. Jeanne d’Arc, IPA: /ʒan daʁk/), znana także jako Dziewica Orleańska (ur. prawdopodobnie 6 stycznia 1412 w Domrémy-la-Pucelle, zm. 30 maja 1431 w Rouen) – francuska bohaterka narodowa, święta Kościoła katolickiego, patronka Francji. Podczas wojny stuletniej poprowadziła armię francuską do kilku ważnych zwycięstw, twierdząc, że działa kierowana przez Boga. Została schwytana przez Burgundczyków i przekazana Anglikom, osądzona przez sąd kościelny i spalona na stosie w wieku 19 lat.";
            }
            if (x == 9)
            {
                textBox1.Text = "Bona Sforza d’Aragona (ur. 2 lutego 1494 w Vigevano, zm. 19 listopada 1557 w Bari) – od 1518 królowa Polski i wielka księżna litewska, księżna Rusi, Prus i Mazowsza itd., księżna Bari i Rosano, spadkobierczyni pretensji do Królestwa Jerozolimy od 1524. Żona Zygmunta Starego, matka Zygmunta Augusta i Anny Jagiellonki.";
            }
            if (x == 10)
            {
                textBox1.Text = "Eva Anna Paula Braun, od 29 kwietnia 1945 Eva Hitler (ur. 6 lutego 1912 w Monachium, zm. 30 kwietnia 1945 w Berlinie) – niemiecka sprzedawczyni, od 1932 konkubina, a przez ostatnie chwile swojego życia żona kanclerza III Rzeszy Adolfa Hitlera. Braun spotkała Hitlera w Monachium, kiedy miała 17 lat, pracując jako asystentka i modelka osobistego fotografa Hitlera. Dwa lata później zaczęła z nim coraz częściej się spotykać. Na początku ich znajomości próbowała dwukrotnie popełnić samobójstwo.";
               }
            if (x == 11)
            {
                textBox1.Text = "Marilyn Monroe, właściwie Norma Jeane Mortenson (ur. 1 czerwca 1926 w Los Angeles, zm. 5 sierpnia 1962 tamże) – amerykańska aktorka, modelka, piosenkarka i producentka filmowa, gwiazda filmowa, ikona kultury popularnej oraz seksbomba lat 50. i 60. XX w. American Film Institute umieścił ją na szóstym miejscu na liście największych aktorek wszech czasów (The 50 Greatest American Screen Legends)";
            }
            if(x==12)
            {
                textBox1.Text = "Katarzyna II Aleksiejewna Wielka, ros. Екатерина II Алексеевна; urodzona jako Zofia Fryderyka Augusta, niem. Sophie Friederike Auguste zu Anhalt-Zerbst-Dornburg (ur. 2 maja 1729 w Szczecinie, zm. 6 listopada?/17 listopada 1796 w Petersburgu) – księżniczka anhalcka, żona wielkiego księcia, później cesarza rosyjskiego Piotra III, a po dokonaniu zamachu stanu samodzielna cesarzowa Rosji w latach 1762-1796.";
            }
                if (x == 13)
            {
                textBox1.Text = "Łosoś szlachetny, łosoś atlantycki, łosoś pospolity, łosoś europejski, łosoś (Salmo salar) – ryba z rodziny łososiowatych (Salmonidae). W północnej części Atlantyku, w rzekach Ameryki Północnej, w Europie od Portugalii po Morze Białe, Północne i Bałtyk. W jeziorach Ładoga i Onega tworzy formy wyłącznie słodkowodne.";
            }
                if (x==14)
            {
                textBox1.Text = "Kleopatra VII Filopator, Kleopatra Wielka, gr. Κλεοπάτρα Φιλοπάτωρ, egip. Qlwpdrt – Kliupadrat (ur. 69 rok p.n.e., zm. 12 sierpnia 30 roku p.n.e. w Aleksandrii) – ostatnia królowa hellenistycznego Egiptu, panująca w latach 51–30 p.n.e. Nosiła tytuły Królowa, Nowa Bogini, Bogini Miłująca Ojca, Bogini Miłująca Ojczyznę. Była córką Ptolemeusza XII Auletesa. Po wstąpieniu na tron poślubiła swego brata Ptolemeusza XIII. Na skutek intryg dworskich opuściła Egipt i udała się do Palestyny, gdzie zdobyła poparcie Cezara.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
         

            
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            
 
        }

        private void oAplikacjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Witaj w aplikacji ''Kim byles w poprzednim wcieleniu''. Aplikacja ta na podstawie pomiarow energii ezoterycznej twojego organizmu powie ci kim lub czym byles w przeszlosci. By poznac prawde o sobie musisz jedynie zadeklarowac plec z lewej strony ekranu, a nastepnie kiliknac przycisk ''Sprawdz!''. Uwaga, pomiar pokazuje prawde jedynie za pierwszym razem.";
            Image image1 = Image.FromFile("zap.jpg");
            pictureBox1.Image = image1;
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Pawel Sliwinski IIIB";
            Image image1 = Image.FromFile("zap.jpg");
            pictureBox1.Image = image1;
        }
    }
}
