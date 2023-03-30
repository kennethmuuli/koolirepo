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

        int bombsInGame = 5;
        int gameFieldWidthUnits = 5, gameFieldHeightUnits = 5;
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
                    for (int x = 0; x < adjacentPositions.Length; x++)
                    {

                        int nextFieldToCheck = adjacentPositions[x];

                        //kontrollin, kas ymbritseval valjal on pomm
                        if (fieldHasBomb[nextFieldToCheck])
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
            //massivi indeksite jarjestus [top left, top, top right, before, after, bottom left, bottom, bottom right] 
            int[] fieldsToCheck = new int[8];
            int[] absolutePositions = new int[8];

            //kalkuleeri kontrollitavat valja ymbritsevade valjade absoluutsed positsioonid (indeksid)
            //top left = top - 1
            absolutePositions[0] = fieldIndex - gameFieldWidthUnits - 1;
            //top i-gameFieldWidthUnits
            absolutePositions[1] = fieldIndex - gameFieldWidthUnits;
            //top right = top + 1
            absolutePositions[2] = fieldIndex - gameFieldWidthUnits + 1;
            //before i-1
            absolutePositions[3] = fieldIndex - 1;
            //after i+1
            absolutePositions[4] = fieldIndex + 1;
            //bottom left = bottom - 1
            absolutePositions[5] = fieldIndex + gameFieldWidthUnits - 1;
            //bottom i+gameFieldWidthUnits
            absolutePositions[6] = fieldIndex + gameFieldWidthUnits;
            //bottom right = bottom + 1
            absolutePositions[7] = fieldIndex + gameFieldWidthUnits + 1;
            
            for (int i = 0; i < fieldsToCheck.Length; i++)
            {
                //kontrolli, kas absoluutse positsiooni indeks on manguvalja indeksite hulgas
                if (absolutePositions[i] > -1 && absolutePositions[i] < field.Length)
                {
                    int inputFieldRow = fieldIndex / gameFieldWidthUnits;
                    int fieldToCheckRow = absolutePositions[i] / gameFieldWidthUnits;
                    int fieldToCheckColumn = absolutePositions[i] % gameFieldWidthUnits;
                    int indexDif = Math.Abs( fieldIndex - absolutePositions[i]);
                    int columnDif = Math.Abs(fieldIndex % gameFieldWidthUnits - fieldToCheckColumn);

                    //kontrolli, kas absoluutne positsioon asub vaiksemas voi suuremas reas JA kas indeksite vahe on tapselt yks VOI veergude vahe on rohkem kui yks, et valtida valede valjade lugemist
                    if (inputFieldRow > fieldToCheckRow && indexDif == 1 || columnDif > 1)
                    {
                        fieldsToCheck[i] = fieldIndex;
                    }
                    else if (inputFieldRow > fieldToCheckRow && indexDif == 1 || columnDif > 1)
                    {
                        fieldsToCheck[i] = fieldIndex;
                    }
                    else fieldsToCheck[i] = absolutePositions[i];
                }
                //kui absoluutne positsioon ei asu manguvaljakul siis maarame indeksiks meetodi sisend indeksi, kuna teame, et seal pole pommi
                else fieldsToCheck[i] = fieldIndex;
            }
            return fieldsToCheck;
        }

        private void Field_Click(object sender, EventArgs e)
        {
            int n = Array.IndexOf(field, (Button)sender);

            field[n].BackColor = Color.White;

        }

        
    }
}