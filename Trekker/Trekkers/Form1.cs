using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Trekkers
{
    public partial class Form1 : Form
    {
        const int _TrekkerArraySize = 15;
        int _LastElementIndex = -1;

        //Array met trekkers
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

        private void FillTrekkerArry()
        {
            Array.Clear(_TrekkerArray, 0, _TrekkerArray.Length);

            _TrekkerArray[0] = new Trekker("Fendt", "1050 Vario", 517, 383000.00);
            _TrekkerArray[1] = new Trekker("John deere", "6250r", 300, 210000.00);
            _TrekkerArray[2] = new Trekker("New Holland", "T7.270", 270, 178000.00);
            _TrekkerArray[3] = new Trekker("Case", "Optum 300", 300, 200000.00);
            _TrekkerArray[4] = new Trekker("Massey Ferguson", "7620 DYNA VT", 200, 158000.00);

            _LastElementIndex = findLastElementIndex();
        }

        private void AddTrekkerTolistbox()
        {
            lbxTrekker.BeginUpdate();
            lbxTrekker.Items.Clear();
            for (int i = 0; i <_TrekkerArraySize; i++)
            {

                if (_TrekkerArray[i] != null)
                {
                    lbxTrekker.Items.Add(_TrekkerArray[i].ToString());
                }

            }
            lbxTrekker.SelectedIndex = 0;
            lbxTrekker.EndUpdate();
        }

        private void PrintDebug_TrekkerArray()
        {
            _LastElementIndex = findLastElementIndex();
            Debug.WriteLine("============================================================");
            for (int i = 0; i <= _LastElementIndex; i++)
            {
                Debug.WriteLine(_TrekkerArray[i].ToString());
            }
            Debug.WriteLine("=============================================================");
        }

        private void AddTrekkerToListBox(Trekker trekker)
        {
            lbxTrekker.BeginUpdate();
            lbxTrekker.Items.Add(trekker.ToString());
            lbxTrekker.SelectedIndex = lbxTrekker.Items.Count - 1;
            lbxTrekker.EndUpdate();
        }

        private  void AddTrekkerToArray(Trekker trekker)
        {
            Debug.WriteLine("Adding trekker to array");
            _LastElementIndex = findLastElementIndex();
            if (_LastElementIndex == _TrekkerArraySize - 1)
            {
                Debug.WriteLine("Array Full");
                return;
            }
            _newTrekker = new Trekker(trekker);
            _TrekkerArray[_LastElementIndex + 1] = _newTrekker;
            _LastElementIndex = findLastElementIndex();
            PrintDebug_TrekkerArray();

        }

        private void DeleteTrekkerFromListbox(int index)
        {
            lbxTrekker.BeginUpdate();
            lbxTrekker.Items.RemoveAt(index);
            if (lbxTrekker.Items.Count > 0)
            {
                lbxTrekker.SelectedIndex = 0;
            }
            lbxTrekker.EndUpdate();
        }

        private void DeleteTrekkerFromArray(int index)
        {
            _LastElementIndex = findLastElementIndex();
            Debug.WriteLine("=============================================================");
            Debug.WriteLine("Deleting element {0}", index);
            // laatste element
            //if (index == _LastElementIndex)
            //{
            //    _TrekkerArray[_LastElementIndex] = null;
            //    return;
            //}
            Debug.WriteLine("_LastElementIndex: {0}", _LastElementIndex);
          

        }
    }
}
