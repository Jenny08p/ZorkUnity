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
    public partial class NeighborControl : UserControl
    {
        public Directions Direction
        {
            get => mDirection;
            set
            {
                mDirection = value;
                directionTextBox.Text = value.ToString();
            }
        }

        public Room Room
        {
            get => mRoom;
            set
            {
                if (mRoom != value)
                {
                    mRoom = value;
                    if (mRoom != null)
                    {
                        var rooms = new List<Room>(Zork_Form.mViewModel.Rooms);
                        rooms.Insert(0, NoRoom);
                        neighborsComboBox.SelectedIndexChanged -= NeighborsComboBox_SelectedIndexChanged;
                        neighborsComboBox.DataSource = rooms;
                        Neighbor = mRoom.Neighbors.TryGetValue(Direction, out Room neighbor) ? neighbor: NoRoom;
                        neighborsComboBox.SelectedIndexChanged += NeighborsComboBox_SelectedIndexChanged;
                    }

                    else
                    {
                        neighborsComboBox.DataSource = null;
                    }
                }
            }
        }

        public Room Neighbor
        {
            get => (Room)neighborsComboBox.SelectedItem;
            set => neighborsComboBox.SelectedItem = value;
        }

        public NeighborControl()
        {
            InitializeComponent();
        }
        private void worldViewModelBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void NeighborsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mRoom != null)
            {
               
                Room selectedRoom = (Room)neighborsComboBox.SelectedItem;
                if (selectedRoom == NoRoom)
                {
                    mRoom.Neighbors.Remove(Direction);
                }
                else
                {
                    mRoom.Neighbors[Direction] = selectedRoom;
                }
            }
        }

        private readonly Room NoRoom = new Room() { Name = "None" };
        private Directions mDirection;
        private Room mRoom;

    }
}

