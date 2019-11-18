using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zork_Common;


namespace Zork_Builder
{
    public partial class directionButton : UserControl
    {
        public WorldViewModel ViewModel { get; set; }

        public Room Neighbor
        {
            get => mNeighbor;
            set
            {
                mNeighbor = value;
                neighborLabel.Text = value != null ? value.Name : "<None>";
            }
        }

        public Room Room
        {
            get => mRoom;
            set
            {
                mRoom = value;
                if (mRoom != null)
                {
                    //Neighbor = mRoom.Neighbors.TryGetValue(Directions, new Room neighbor) ? neighbor : null;
                }
                else
                {
                    Neighbor = null;
                }
            }
        }

        private void neighborButton_Click(object sender, EventArgs e)
        {
            //using (neighborButton.ShowDialog() == DialogResult:OK)
            //{

            //}
        }
        public Room mNeighbor { get; private set; }
        // public Room neighbor { get; private set; }
        public object Directions { get; private set; }
        public Room mRoom { get; private set; }

        public void Clear()
        {
            Room = null;
            Neighbor = null;
        }

        public directionButton()
        {
            InitializeComponent();
        }
    }
}
