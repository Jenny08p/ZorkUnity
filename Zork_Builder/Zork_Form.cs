using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Zork_Builder;
using Newtonsoft.Json;
using Zork_Common;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Zork_Builder
{
    public partial class Zork_Form : Form
    {
        public static WorldViewModel mViewModel;

        public bool IsWorldLoaded { get; set; }

        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
        public Zork_Form()
        {
            InitializeComponent();
            mViewModel = new WorldViewModel();
            IsWorldLoaded = false;

            mNeighborControls = new Dictionary<Directions, NeighborControl>
            {
                { Directions.North, northNeighborControl },
                { Directions.East, eastNeighborControl },
                { Directions.South, southNeighborControl },
                { Directions.West, westNeighborControl }
            };
        }

        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog1.FileName));
                mViewModel.Filename = openFileDialog1.FileName;
                roomsBindingSource.DataSource = mViewModel.Rooms;

                Room selectedRoom = roomsListBox.SelectedItem as Room;
                foreach (var control in mNeighborControls.Values)
                {
                    control.Room = selectedRoom;
                }

                IsWorldLoaded = true;
            }
        }

       // private readonly Dictionary<Directions, NeighborControl> mNeighborControlMap;
        private void SaveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mViewModel.SaveGame();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                mViewModel.Filename = saveFileDialog.FileName;
                mViewModel.SaveGame();
            }
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = Properties.Settings.Default.DotNetExecutable,
                    Arguments = $"{Properties.Settings.Default.ZorkGameAssembly} {Properties.Settings.Default.ZorkGameArguments}",
                    WorkingDirectory = Path.GetDirectoryName(Properties.Settings.Default.ZorkGameAssembly),
                    UseShellExecute = false
                };

                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Playing.");
            }
        }

        private void CloseWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private readonly Dictionary<Directions, NeighborControl> mNeighborControls;

        private void roomNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
   
        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoom addRoom = new AddRoom())
            {
                if (addRoom.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoom.RoomName };
                    mViewModel.Rooms.Add(room);
                }
            }
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
         if (MessageBox.Show($"Delete { ((Room)roomsListBox.SelectedItem).Name }?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
         {
             mViewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
             roomsListBox.SelectedItem = mViewModel.Rooms.FirstOrDefault();
         }
        }

        private void newWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (SaveGame() == DialogResult()
            //    mViewModel.Game = new Game
            //    {
            //         World = new World()
            //    }
            //else
            //{

            //}

            //mviewmodel.fullpath = null;
            //mviewmodel.ismodified = true;
            //worldview.RefeshData();
            //updatetitle();
            //isworldloaded = true;

        }

        private void RoomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Room selectedRoom = roomsListBox.SelectedItem as Room;
            foreach (var control in mNeighborControls.Values)
            {
                control.Room = selectedRoom;
            }
        }
    }
}


