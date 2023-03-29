using System.Security.Cryptography;

namespace Minesweeper_Game
{
    public partial class Minesweeper : Form
    {
        /// <FULL>
        //Vali s.t. raskusaste A mitu pommi + opt.B, kui suur on valjak + opt.C elude arv
        //Kuva valja alles jaanud elud ja avada jaanud valjade arv
        //Loo nuppude massiiv
        //Genereeri pommide positsioonid (loo uus pommi indeksite massiiv, et parast kiiremini labi loopida)
        //pommita valjadel liida kokku, mitu pommi on selle ymber ja kuva see number valja valjale
        //ava koik pommita seotud valjad
        //kaotasid elu kui vajutad pommile
        //game over state kui elud otsas
        //game won state kui koik valjad on avatud peale pommide
        /// </FULL>

        /// <MVP>
        //hardcoded pommide arv
        //Loo nuppude massiiv
        //Genereeri pommide positsioonid (loo uus pommi indeksite massiiv, et parast kiiremini labi loopida)
        //pommita valjadel liida kokku, mitu pommi on selle ymber ja kuva see number valja valjale
        //game over state kui elud otsas (esimene pomm)
        //game won state kui koik valjad on avatud peale pommide
        /// </MVP>

        int bombsInGame = 2;
        int gameFieldWidthUnits = 3, gameFieldHeightUnits = 3;
        //valjade massiiv
        Button[] field;
        //List, mis hoiab iga valja kohta booleani, kas antud valjal on pomm
        List<bool> fieldHasBomb = new List<bool>();
        List<int> fieldAdjacentBombs = new List<int>();

   
        public Minesweeper()
        {
            InitializeComponent();
            field = new Button[gameFieldWidthUnits * gameFieldHeightUnits];
            GenerateGameField();
            PlaceBombs();
            CalculateAdjacentBombsNumber();
        }

        private void GenerateGameField()
        {
            int dx = GameArea.Width / gameFieldWidthUnits;
            int dy = GameArea.Height / gameFieldHeightUnits;

            for (int i = 0; i < field.Length; i++)
            {
                field[i] = new Button();
                GameArea.Controls.Add(field[i]);
                field[i].Width = dx;
                field[i].Height = dy;
                int rida = i / gameFieldWidthUnits;
                int veerg = i % gameFieldWidthUnits;
                field[i].Left = veerg * dx;
                field[i].Top = rida * dy;
                //field[i].Text = i.ToString();
                //field[i].ForeColor = Color.Red;
                field[i].BackColor = Color.LightGray;
                field[i].Click += new EventHandler(Field_Click);
                fieldAdjacentBombs.Add(0);
                fieldHasBomb.Add(false);
            }
            //field[0].Text = "";
            //field[0].BackColor = Color.White;
        }

        private void PlaceBombs()
        {
            ///
            //50-50 voimalus, et valjale genetakse pomm
            //kui pomm genetakse vota bombsLeftToPlace maha 1, muidu jargmine field index
            //loopi seni kuni on jatkuvalt bombsLeftToPlace on 0
            //kui jouab viimase fieldini ja bomsLeftToPlace pole ikka 0, siis alusta uuesti nullist
            //jargmistel loopidel, kui isBomb bool true siis skip to next index
            ///

            //sea paigutatavate pommide arv vordseks mangus olevate pommidega
            int bombsToPlace = bombsInGame;

            //alusta pommide paigaldamist ja jooksuta seni kuni koik pommid on paigaldatud
            do
            {
                for (int i = 0; i < field.Length; i++)
                {

                    //kontrolli, kas valjal on juba pomm, kui ei siis jatka && kontrolli ka jooksvalt, kas pomme on jaanud veel paigaldada
                    //PS! jooksev kontroll on oluline, kuna pommid voivad ka for loobi kaigus otsa saada, s.t. ennem kui joutakse jargmise while loop kontrollini
                    if (!fieldHasBomb[i] && bombsToPlace > 0)
                    {
                        Random random = new Random();
                        int randomNumber = random.Next(1, 101);

                        if (randomNumber > 75)
                        {
                            field[i].Text = "X";
                            field[i].ForeColor = Color.Red;
                            fieldHasBomb[i] = true;
                            bombsToPlace--;
                        }
                    }

                }
            }
            while (bombsToPlace > 0);

        }

        private void CalculateAdjacentBombsNumber()
        {
            ///
            //vota field uks
            //kontrolli, kas seal on pomm, kui ei siis jatka
            //leia ymbritsevad positsioonid
            //kontrolli kas ymbritsevatel positsioonidel on pomm
            //kuva tulemus valjale
            ///

            int adjacentBombsCounter = 0;

            //kain labi koik valjad ukshaaval
            for (int i = 0; i < field.Length; i++)
            {
                //kontrollin, kas konkreetse indeksiga valjal on pomm, kui ei siis jatkan
                if (!fieldHasBomb[i])
                {
                    //tagastan ymbritsevate valjade indeksi massiivi
                    int[] adjacentPositions = FieldsToCheck(i);

                    //kain labi iga ymbritseva valja ja kontrollin, kas seal on pomm
                    for (int x = 0; x < adjacentPositions.Length; i++)
                    {
                        bool isInBounds = adjacentPositions[x] > -1 && adjacentPositions[x] < field.Length;

                        //kui konkreetne ymbritsev positsioon manguvaljal (s.t. not out of bounds) JA kontrollitava indeksiga valjal on pomm siis suurenda pommi loendurit
                        if (adjacentPositions[x] > -1 && adjacentPositions[x] < field.Length && fieldHasBomb[adjacentPositions[x]])
                        {
                            adjacentBombsCounter++;
                        }
                        
                    }

                    //salvesta valja tulemus
                    fieldAdjacentBombs[i]  = adjacentBombsCounter;
                    //kuva tulemus valjale
                    field[i].Text = fieldAdjacentBombs[i].ToString();
                    adjacentBombsCounter = 0;
                }
            }

        }

        private int[] FieldsToCheck(int fieldIndex)
        {
            //array [top left, top, top right, before, after, bottom left, bottom, bottom right] 
            int[] fieldsToCheck = new int[8];

            //top left = top - 1
            fieldsToCheck[0] = fieldIndex - gameFieldWidthUnits - 1;
            //top i-gameFieldWidthUnits
            fieldsToCheck[1] = fieldIndex - gameFieldWidthUnits;
            //top right = top + 1
            fieldsToCheck[2] = fieldIndex - gameFieldWidthUnits + 1;
            //before i-1
            fieldsToCheck[3] = fieldIndex - 1;
            //after i+1
            fieldsToCheck[4] = fieldIndex + 1;
            //bottom left = bottom - 1
            fieldsToCheck[5] = fieldIndex + gameFieldWidthUnits - 1;
            //bottom i+gameFieldWidthUnits
            fieldsToCheck[6] = fieldIndex + gameFieldWidthUnits;
            //bottom right = bottom + 1
            fieldsToCheck[7] = fieldIndex + gameFieldWidthUnits + 1;

            return fieldsToCheck;
        }

        private void Field_Click(object sender, EventArgs e)
        {
            int n = Array.IndexOf(field, (Button)sender);

            field[n].BackColor = Color.White;

        }

        
    }
}