using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Net;
using System.Diagnostics;


namespace Fahrplanapplikation
{
    public partial class Form1 : Form
    {
        private AutoComplete AutoCompleteDeparture;
        private AutoComplete AutoCompleteDestination;

        public Form1()
        {
            InitializeComponent();
            AutoCompleteDeparture = new AutoComplete(comboBoxDeparture);
            AutoCompleteDestination = new AutoComplete(comboBoxDestination);
        }

        //AutoComplete Eventhandler
        private void comboBoxDeparture_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isKeyValid(e)) return;
            AutoCompleteDeparture.UpdateSuggestions();
        }

        //AutoComplete Eventhandler
        private void comboBoxDestination_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isKeyValid(e)) return;
            AutoCompleteDestination.UpdateSuggestions();
        }
        //Check if the entered Key is valid
        private bool isKeyValid(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Tab)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Sets the Visible state of the Destination Label and Combobox
        private void rBtnYes_CheckedChanged(object sender, EventArgs e)
        {
            bool state = comboBoxDestination.Visible;

            comboBoxDestination.Visible = !state;
            lblDestination.Visible = !state;
        }

        //Swaps Content from Depart to Destination Combobox and vice versa
        private void btnSwap_Click(object sender, EventArgs e)
        {
            string tempText = comboBoxDeparture.Text;

            comboBoxDeparture.Text = comboBoxDestination.Text;
            comboBoxDestination.Text = tempText;
        }

        private void btnSearchConncections_Click(object sender, EventArgs e)
        {

            //clear and refresh the dataGrid
            dataGridViewConnection.Rows.Clear();
            dataGridViewConnection.Refresh();

            if (rBtnNo.Checked == true)
            {
                if (comboBoxDeparture.Text == "" || comboBoxDestination.Text == "")
                {
                    MessageBox.Show("Please enter Departure AND Destination Station!");
                }
                else
                {
                    foreach (DataGridViewRow item in this.dataGridViewConnection.SelectedRows)
                    {
                        dataGridViewConnection.Rows.RemoveAt(item.Index);
                    }

                    Transport tp = new Transport();

                    string date = datePicker.Value.ToString("yyyy-MM-dd");
                    string time = timePicker.Value.ToString("HH:mm");

                    Connections connections = tp.GetConnectionsWithTime(comboBoxDeparture.Text, comboBoxDestination.Text, date, time);

                    //fill Data into the DataGrid
                    foreach (Connection connection in connections.ConnectionList)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridViewConnection);
                        row.Cells[0].Value = connection.From.Station.Name;
                        row.Cells[2].Value = connection.From.Platform;
                        row.Cells[3].Value = connection.To.Station.Name;
                        row.Cells[4].Value = connection.To.Platform;
                        row.Cells[5].Value = Convert.ToDateTime(connection.From.Departure).ToString("HH:mm");
                        row.Cells[6].Value = Convert.ToDateTime(connection.To.Arrival).ToString("HH:mm");
                        row.Cells[7].Value = connection.Duration.Substring(3, 2) + "h " + connection.Duration.Substring(6, 2) + "min";

                        dataGridViewConnection.Rows.Add(row);
                    }
                }
            }
            else
            {
                if (comboBoxDeparture.Text == "")
                {
                    MessageBox.Show("Please enter Departure Station!");
                }
                else
                {
                    Transport tp = new Transport();
                    Stations stations = tp.GetStations(comboBoxDeparture.Text);
                    foreach (Station station in stations.StationList)
                    {
                        String id = station.Id;
                        StationBoardRoot stationBoardRoot = tp.GetStationBoard(comboBoxDeparture.Text, id);

                        //fill Data into the DataGrid
                        foreach (StationBoard stationBoard in stationBoardRoot.Entries)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridViewConnection);
                            row.Cells[0].Value = comboBoxDeparture.Text;
                            row.Cells[1].Value = stationBoard.Name;
                            row.Cells[3].Value = stationBoard.To;
                            row.Cells[5].Value = stationBoard.Stop.Departure.ToString("HH:mm:ss");

                            dataGridViewConnection.Rows.Add(row);
                        }
                    }
                }
            }
        }

        private void btnSearchMapDeparture_Click(object sender, EventArgs e)
        {
            searchOnGoogle(comboBoxDeparture);
        }

        private void btnSearchMapDestination_Click(object sender, EventArgs e)
        {
            searchOnGoogle(comboBoxDestination);
        }

        //Opens a Google Maps Website in your Default Browser providing x and y coordinates of the Station the User wants to search.
        private void searchOnGoogle(ComboBox cbBox)
        {
            Transport tp = new Transport();
            Stations stationDeparture = tp.GetStations(cbBox.Text);
            foreach (Station station in stationDeparture.StationList)
            {
                Coordinate coordinates = station.Coordinate;
                string xValue = coordinates.XCoordinate.ToString().Replace(",", ".");
                string yValue = coordinates.YCoordinate.ToString().Replace(",", ".");
                string url = "https://www.google.ch/maps/?q=loc:" + xValue + "+" + yValue;
                Process.Start(url);
            }
        }

        private void dataGridViewConnection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
