using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trekkers
{
    public partial class Form1 : Form
    {
        const int _TrekkerArraySize = 15;
        int _LastElementIndex = -1;


        Trekker[] _TrekkerArray = new Trekker[_TrekkerArraySize];
        Trekker _newTrekker;

        public Form1()
        {
            InitializeComponent();
        }

        private int findLastElementIndex()
        {

            for (int i = 0; i < _TrekkerArraySize; i++)
            {
                if (_TrekkerArray[i] == null)
                {
                    return i - 1;
                }
            }
            return _TrekkerArraySize - 1;
        }


        private void FillPhoneArray()
        {
            Array.Clear(_TrekkerArray, 0, _TrekkerArray.Length);
            _TrekkerArray[0] = new Trekker("Fendt", "1050", 517, 380000.00);
            _TrekkerArray[1] = new Trekker("John deere", "6250r", 300, 280000.00);
            _TrekkerArray[2] = new Trekker("New Holland", "T7.270", 270, 253000.00);
            _TrekkerArray[3] = new Trekker("Case IH", "Puma 200", 240, 210000.00);
            _TrekkerArray[4] = new Trekker("Massey Ferguson", "7718", 210, 176000.00);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
