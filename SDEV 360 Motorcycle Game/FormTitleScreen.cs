using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;   //Regex for text related items

// Neil Little -  SDEV 360 - 
// Final Project: 
// 01 May 2020


namespace SDEV_360_Motorcycle_Game
{

    public partial class FormTitleScreen : Form
    {
        int maxspeed;  // motorcycle characteristics
        int acceleration;
        int weight;
        int newScore = 0;  // new score that is passed from the game forms.
        public FormTitleScreen()  
        {
            InitializeComponent();
        }



        private void FormTitleScreen_Load(object sender, EventArgs e)
        {
            
            maxspeed = 2;  // some default values for the code to run.  
            acceleration = 5;
            weight = 1000;

        }

        private void buttonGameStart_Click(object sender, EventArgs e)  // Loads the main game form Form1.
        {
            //MotorCycle usercycle = new MotorCycle(acceleration, maxspeed, weight);  // creating an instance to send to the game form.
            //Form1 form1 = new Form1(textBoxPlayerName.Text, usercycle);  // passing motorcycle data to the next form.
            ////Application.Run(new Form1());
            //form1.Show();  //making form 1 visible.
            //newScore = 0;
            MotorCycle usercycle = new MotorCycle(acceleration, maxspeed, weight);  // creating an instance to send to the game form.
            FormLevel2 form1 = new FormLevel2(textBoxPlayerName.Text, usercycle);  // passing motorcycle data to the next form.
            //Application.Run(new Form1());
            form1.Show();  //making form 1 visible.
            newScore = 0;


            

        }

        private void radioHarley_Click(object sender, EventArgs e)  //used to assign values for "harley" , but not used.
        {
            maxspeed = 2;
            acceleration = 5;
            weight = 1000;
        }

        private void radioKawasaki_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioKawasaki_Click(object sender, EventArgs e)
        {
            maxspeed = 1;              //will be used to change values for a Kawasaki set up.  but not used
            acceleration = 12;
            weight = 700;
        }

        private void textBoxPlayerName_MouseClick(object sender, MouseEventArgs e)
        {
            //textBoxPlayerName.Text = "";  // clears the text box when user clicks to begin typing
        }

        private void FormTitleScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();  //exits app
        }

        private void radioHarley_CheckedChanged(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)  //adds data to the table.
        {
            {
                try
                {


                    if (Regex.IsMatch(textBoxPlayerName.Text, @"^[a-zA-Z0-9_-]+$"))  // validating input.  
                                                                                     //allows numbers, letters, underscores and hypens.
                    {


                        string theQuery = "";
                        SQLDatabaseConnection dbC = new SQLDatabaseConnection();
                        QueryString str = new QueryString();
                        ExecuteSQL sql = new ExecuteSQL();
                        int iResult;

                        theQuery = str.BuildMemberQuery(QueryString.QueryType.Insert, textBoxPlayerName.Text, Convert.ToString(newScore));
                        iResult = sql.InsertRecord(dbC.dbConn(), theQuery, textBoxPlayerName.Text, Convert.ToString(newScore));

                        if (iResult == 0)
                        {
                            MessageBox.Show("Insert Failed!");
                        }
                        btnGetRecords_Click(sender, e);  // forces the data table to update and reflect the new changes.
                    }
                    else
                    {
                        MessageBox.Show("Special characters other than an underscore or hyphen are not permitted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnGetRecords_Click(object sender, EventArgs e)  //Loads existing records.
        {
            try
            {

                string theQuery = "";
                SQLDatabaseConnection dbC = new SQLDatabaseConnection();
                QueryString str = new QueryString();
                ExecuteSQL sql = new ExecuteSQL();
                DataTable theTable = new DataTable();

                theQuery = str.BuildMemberQuery(QueryString.QueryType.ReturnData);

                theTable = sql.GetRecords(dbC.dbConn(), str.BuildMemberQuery(QueryString.QueryType.ReturnData));

                dataGridView1.DataSource = theTable;
                string sTempList;  
                List<int> listLINQ = new List<int>();
                foreach (DataRow row in theTable.Rows)
                 
                {
                    
                    sTempList = (row["Score"].ToString());
                    listLINQ.Add( Convert.ToInt32(sTempList));

                }
                decimal maxNumber = listLINQ.Max();
                labelLINQ.Text = "The current High Score is \t" + Convert.ToString(maxNumber) + "          Here are the rest of the lower scores:   ";
              

                // Get numbers bigger then 20
                var lessthan = from num in listLINQ
                               where num < maxNumber
                           orderby num
                           select num;

                foreach (var i in lessthan)
                {                                                                                         
                    labelLINQ.Text = " - " + labelLINQ.Text + Convert.ToString(i) + "   ";

                }
                dbC = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        public void btnUpdate_Click(object sender, EventArgs e)  // Updates records.
        {
            try
            {
                string theQuery = "";
                SQLDatabaseConnection dbC = new SQLDatabaseConnection();
                QueryString str = new QueryString();
                ExecuteSQL sql = new ExecuteSQL();
                int iResult;
                if (txtHiddenMemberID.Text != "")
                {
                    theQuery = str.BuildMemberQuery(QueryString.QueryType.Update, textBoxPlayerName.Text, txtHiddenMemberID.Text, Convert.ToString(newScore));
                    iResult = sql.UpdateRecord(dbC.dbConn(), theQuery);

                    if (iResult == 0)
                    {
                        MessageBox.Show("Delete Failed!");

                    }//end if (iResult

                    int rowIndex = 0;
                    foreach (DataGridViewRow Row in dataGridView1.Rows)
                    {
                        if (Row.Cells[0].FormattedValue.ToString() == txtHiddenMemberID.Text)
                        {
                            Row.Cells[1].Value = textBoxPlayerName.Text;
                        }
                        rowIndex++;
                    }

                }//end If
                else
                {
                    MessageBox.Show("There must be a user selected before update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string theQuery = "";
                SQLDatabaseConnection dbC = new SQLDatabaseConnection();
                QueryString str = new QueryString();
                ExecuteSQL sql = new ExecuteSQL();
                DataTable theTable = new DataTable();

                theQuery = str.BuildMemberQuery(QueryString.QueryType.ReturnData);

                theTable = sql.GetRecords(dbC.dbConn(), str.BuildMemberQuery(QueryString.QueryType.ReturnData));

                dataGridView1.DataSource = theTable;
                string sTempList;
                List<int> listLINQ = new List<int>();
                foreach (DataRow row in theTable.Rows)

                {

                    sTempList = (row["Score"].ToString());
                    listLINQ.Add(Convert.ToInt32(sTempList));

                }
                decimal maxNumber = listLINQ.Max();
                labelLINQ.Text = "The current High Score is \t" + Convert.ToString(maxNumber) + "          Here are the rest of the lower scores:   ";


                // Get numbers bigger then 20
                var lessthan = from num in listLINQ
                               where num < maxNumber
                               orderby num
                               select num;

                foreach (var i in lessthan)
                {
                    labelLINQ.Text = " - " + labelLINQ.Text + Convert.ToString(i) + "   ";

                }
                dbC = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)  // changing user name selections in box.
        {
            try
            {


                DataGridViewCell cell = null;
                foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }
                if (cell != null)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txtHiddenMemberID.Text = row.Cells["Id"].Value.ToString();
                    textBoxPlayerName.Text = row.Cells["FirstName"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e) //deletes the selected record.
        {
            try
            {


                string theQuery = "";
                SQLDatabaseConnection dbC = new SQLDatabaseConnection();
                QueryString str = new QueryString();
                ExecuteSQL sql = new ExecuteSQL();
                int iResult;
                //MemberID: txtHiddenMemberID.Text allows us to specify an optional parameter
                theQuery = str.BuildMemberQuery(QueryString.QueryType.Delete, Id: txtHiddenMemberID.Text);
                iResult = sql.DeleteRecord(dbC.dbConn(), theQuery);

                if (iResult == 0)
                {
                    MessageBox.Show("Delete Failed!");

                }

                //Remove the deleted row from the data grid based on the Id
                List<DataGridViewRow> RowsToDelete = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    if (row.Cells[0].Value != null &&
                         row.Cells[0].Value.ToString() == txtHiddenMemberID.Text) RowsToDelete.Add(row);
                foreach (DataGridViewRow row in RowsToDelete) dataGridView1.Rows.Remove(row);
                RowsToDelete.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */
        public void EndGame(int newscore) //method for ending the game and transfer score.
        {
            this.newScore = newscore;
            labelNewScore.Visible = true;
            labelNewScore.Text = "Your new score is " + Convert.ToString(newScore);
        }
        
    }
    }
