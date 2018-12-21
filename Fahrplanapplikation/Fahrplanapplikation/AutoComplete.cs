
using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Fahrplanapplikation
{
    class AutoComplete
    {
        private ITransport trnsprt = new Transport();
        private ComboBox cmbBox;
        private List<string> stationNames = new List<string>();
        private System.Windows.Forms.Timer cooldown = new System.Windows.Forms.Timer();

        //declars the cooldown of the search interval in ms.
        public AutoComplete(ComboBox cmbBox)
        {
            this.cmbBox = cmbBox;
            cooldown.Interval = 667;
            cooldown.Tick += new EventHandler(EndCooldown);
        }

        //lists all the suggestions in the combobox.
        public void UpdateSuggestions(bool isDoneWithCooldown = false)
        {
            if (!isDoneWithCooldown)
            {
                if (cooldown.Enabled) return;

                cooldown.Start();
                cooldown.Enabled = true;
            }

            string text = cmbBox.Text;
            stationNames.Clear();
            var Stations = trnsprt.GetStations(cmbBox.Text).StationList;

            foreach (var Station in Stations)
            {
                stationNames.Add(Station.Name);
            }

            cmbBox.DataSource = null;
            cmbBox.DataSource = stationNames;
            cmbBox.Text = text;
            cmbBox.SelectionStart = text.Length;
            cmbBox.SelectionLength = 0;
            cmbBox.DroppedDown = true;
        }

        private void EndCooldown(object sender, EventArgs e)
        {
            cooldown.Stop();
            cooldown.Enabled = false;
            UpdateSuggestions(true);
        }
    }
}
