using System.Data;
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

        int bombsInGame = 1;
        int gameFieldWidthUnits = 5, gameFieldHeightUnits = 5;
        int fieldsLeftToWin = 0;
        //valjade massiiv
        Button[] fields;
        //List, mis hoiab iga valja kohta booleani, kas antud valjal on pomm
        List<bool> fieldHasBomb = new List<bool>();
        List<int> fieldAdjacentBombs = new List<int>();
        
        List<bool> fieldRevealed = new List<bool>();

        //Y= kuva valjade vaartuseid koguaeg, N = kuva valja vaartust peale valja avamist
        bool testMode = true;
        

        string gameStateMessage;
   
        public Minesweeper()
        {
            InitializeComponent();
            StartGame();
            
        }

        private void StartGame()
        {
            
            fields = new Button[gameFieldWidthUnits * gameFieldHeightUnits];
            fieldsLeftToWin = gameFieldWidthUnits * gameFieldHeightUnits - bombsInGame;
            FieldsLeftCounterLabel.Text = fieldsLeftToWin.ToString();
            GenerateGameField();
            PlaceBombs();
            CalculateAdjacentBombsNumber();

            GameOverLabel.Visible = false;
            RestartButton.Visible = false;
        }

        private void GenerateGameField()
        {
            int dx = GameArea.Width / gameFieldWidthUnits;
            int dy = GameArea.Height / gameFieldHeightUnits;

            for (int i = 0; i < fields.Length; i++)
            {
                fields[i] = new Button();
                GameArea.Controls.Add(fields[i]);
                fields[i].Width = dx;
                fields[i].Height = dy;
                int rida = i / gameFieldWidthUnits;
                int veerg = i % gameFieldWidthUnits;
                fields[i].Left = veerg * dx;
                fields[i].Top = rida * dy;
                //field[i].Text = i.ToString();
                //field[i].ForeColor = Color.Red;

                //maara valja algne stiil
                fields[i].BackColor = Color.LightGray;
                //seo valja "nupu" objektile syndmuse "jalgija"
                fields[i].Click += new EventHandler(Field_Click);
                //lisa valjale default muutujad
                fieldAdjacentBombs.Add(0);
                fieldHasBomb.Add(false);
                fieldRevealed.Add(false);
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
                for (int i = 0; i < fields.Length; i++)
                {

                    //kontrolli, kas valjal on juba pomm, kui ei siis jatka && kontrolli ka jooksvalt, kas pomme on jaanud veel paigaldada
                    //PS! jooksev kontroll on oluline, kuna pommid voivad ka for loobi kaigus otsa saada, s.t. ennem kui joutakse jargmise while loop kontrollini
                    if (!fieldHasBomb[i] && bombsToPlace > 0)
                    {
                        Random random = new Random();
                        int randomNumber = random.Next(1, 101);

                        if (randomNumber > 75)
                        {
                            fields[i].Text = "X";

                            ShowHideFieldValue(i);
                            
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
            for (int i = 0; i < fields.Length; i++)
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
                    fields[i].Text = fieldAdjacentBombs[i].ToString();
                    ShowHideFieldValue(i);
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
                if (absolutePositions[i] > -1 && absolutePositions[i] < fields.Length)
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

            int n = Array.IndexOf(fields, (Button)sender);
            fields[n].BackColor = Color.White;
            fieldRevealed[n] = true;
            ShowHideFieldValue(n);

            //kontrolli, kas valjal on pomm voi mitte
            if (fieldHasBomb[n])
            {
                GameOver();
            }
            else
            {
                fieldsLeftToWin--;
                FieldsLeftCounterLabel.Text = fieldsLeftToWin.ToString();

                if (fields[n].Text == "0")
                {
                    
                    ConnectedZeroField(n);

                }
            }

            //kui pommideta valjad on otsas, siis on mang voidetud
            if (fieldsLeftToWin == 0)
            {
                GameWon();
            }

        }

        private void ConnectedZeroField(int fieldIndex)
        {

            int[] adjacentPositions = FieldsToCheck(fieldIndex);

            //Kain esmalt leitud 0 valja ymbritsevad positsioonid labi ja avan koik leitud jargmised 0 valjad
            for (int x = 0; x < adjacentPositions.Length; x++)
            {
                int nextFieldToCheck = adjacentPositions[x];

                if (fields[nextFieldToCheck].Text == "0" && !fieldRevealed[nextFieldToCheck])
                {
                    fieldRevealed[nextFieldToCheck] = true;
                    fields[nextFieldToCheck].BackColor = Color.White;
                    ShowHideFieldValue(nextFieldToCheck);
                    fieldsLeftToWin--;
                    FieldsLeftCounterLabel.Text = fieldsLeftToWin.ToString();
                }
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {

            //field = null;
            //fieldHasBomb.Clear();
            //fieldAdjacentBombs.Clear();

            //InitializeComponent();
            //StartGame();
            Application.Restart();

        }

        private void GameOver()
        {

            gameStateMessage = "Game Over!";
            GameHasEnded(gameStateMessage);
        }

        private void GameWon()
        {
            gameStateMessage = "Game Won!";
            GameHasEnded(gameStateMessage);
        }

        private void GameHasEnded(string messageToPlayer)
        {
            foreach (var field in fields)
            {
                field.Enabled = false;
            }

            GameOverLabel.Text = messageToPlayer;
            GameOverLabel.BackColor = Color.Transparent;
            GameOverLabel.Visible = true;
            RestartButton.Visible = true;

        }

        private void ShowHideFieldValue(int fieldIndex)
        {
            
            //kontrolli, kas testMode on aktiivne
            if (testMode)
            {
                fields[fieldIndex].ForeColor = Color.Black;
            }
            else
            {
                if (fieldRevealed[fieldIndex])
                {
                    if (fieldHasBomb[fieldIndex])
                    {
                        fields[fieldIndex].ForeColor = Color.Red;
                    }
                    else
                    {
                        fields[fieldIndex].ForeColor = Color.Black;
                    }
                }
                else
                {
                    fields[fieldIndex].ForeColor = Color.LightGray;
                }
            }

        }
    }
}