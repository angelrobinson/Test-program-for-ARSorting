using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARSorting;
using System.IO;
using System.Diagnostics;

namespace SortingAlgorithms_WinForm
{
    public partial class Form1 : Form
    {
        SortAccess perform = new SortAccess();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filePathTextBox.Text = openFileDialog1.FileName;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"\DataFiles";
            openFileDialog1.ShowDialog();
        }



        private void OtherRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (otherRadio.Checked)
            {
                otherAmtText.Enabled = true;
            }
            else
            {
                otherAmtText.Enabled = false;
            }
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {

            //if generate check box is checked
            if (generateCheckBox.Checked)
            {
                perform.randomGen = true;
            }
            else
            {
                //get file path
                perform.filePath = filePathTextBox.Text;
            }

            //get how many elements to put in unsorted array
            foreach (RadioButton item in ammountGroup.Controls)
            {

                if (item.Checked)
                {
                    perform.elements = int.Parse(item == otherRadio ? otherAmtText.Text : item.Text);
                }
            }

            //get what type of data structure to get
            foreach (RadioButton item in dataTypeGroup.Controls)
            {
                if (item.Checked)
                {
                    perform.structureType = item.Text.ToLower();
                }
            }

            //get the sort type to do
            foreach (RadioButton item in sortTypeGroup.Controls)
            {
                if (item.Checked)
                {
                    perform.sortType = item.Text.ToLower();
                }
            }

            //run the sort
            TimeSpan time =  perform.RunSort();

            MessageBox.Show(time.ToString());
        }

        private void GenerateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (generateCheckBox.Checked)
            {
                filePathTextBox.Enabled = false;
                browseButton.Enabled = false;
                ammountGroup.Enabled = true;
                //foreach (RadioButton item in ammountGroup.Controls)
                //{
                //    item.Enabled = true;                    
                //}
            }
            else
            {
                filePathTextBox.Enabled = true;
                browseButton.Enabled = true;
                ammountGroup.Enabled = false;
                //foreach (RadioButton item in ammountGroup.Controls)
                //{
                //    item.Enabled = false;
                //}
            }
        }
    }

    class SortAccess
    {
        Sorting sort = new Sorting();
        Stopwatch runTime = new Stopwatch();
        int[] array;
        List<int> slist;
        LinkedList<int> dlist;

        public int elements;
        public string structureType;
        public string sortType;
        public bool randomGen;
        public string filePath;


        public SortAccess()
        {
            elements = 10;
            structureType = "array";
            sortType = "bubble";
            randomGen = false;
            filePath = Application.StartupPath + @"\DataFiles\num10.dat";
        }

        public SortAccess(int ele, string structType, string srtType, bool ran, string path)
        {
            elements = ele;
            structureType = structType;
            sortType = srtType;
            randomGen = ran;
            filePath = path;
        }

        public TimeSpan RunSort()
        {
            SetUpStructure();
            
            runTime.Restart();
            switch (sortType)
            {
                case "insertion":
                    if (dlist != null)
                    {
                        sort.InsertionSort(ref dlist);
                    }
                    else if (slist != null)
                    {
                        sort.InsertionSort(ref slist);
                    }
                    else
                    {
                        sort.InsertionSort(ref array);
                    }
                    break;
                case "merge":
                    if (dlist != null)
                    {
                        sort.MergeSort(ref dlist);
                    }
                    else if (slist != null)
                    {
                        sort.MergeSort(ref slist);
                    }
                    else
                    {
                        sort.MergeSort(ref array);
                    }
                    break;
                default:
                    //bubble sort
                    if (dlist != null)
                    {
                        sort.BubbleSort(ref dlist);
                    }
                    else if (slist != null)
                    {
                        sort.BubbleSort(ref slist);
                    }
                    else
                    {
                        sort.BubbleSort(ref array);
                    }
                    break;
            }
            runTime.Stop();

            return runTime.Elapsed;

        }

        void SetUpStructure()
        {

            //initialize data structure
            switch (structureType)
            {
                case "array":
                    array = new int[elements];
                    break;
                case "single linked list":
                    slist = new List<int>();
                    break;
                case "doubly linked list":
                    dlist = new LinkedList<int>();
                    break;
                default:
                    break;
            }

            if (randomGen)
            {
                //populate data structures 
                Random ran = new Random();

                for (int i = 0; i < elements; i++)
                {
                    if (dlist != null)
                    {
                        dlist.AddLast(ran.Next());
                    }
                    else if (slist != null)
                    {
                        slist.Add(ran.Next());
                    }
                    else
                    {
                        array[i] = ran.Next();
                    }
                }
            }
            else
            {
                //read in file
                string[] lines = File.ReadAllLines(filePath);

                if (structureType == "array")
                {
                    array = new int[lines.Length];
                }

                int index = 0;

                foreach (var line in lines)
                {
                    int parsed = int.Parse(line);

                    if (dlist != null)
                    {
                        dlist.AddLast(parsed);
                    }
                    else if (slist != null)
                    {
                        slist.Add(parsed);
                    }
                    else
                    {
                        array[index] = parsed;
                        index++;
                    }
                }
            }
        }
    }
}
