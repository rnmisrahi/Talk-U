using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompareText
{
    public partial class Comparison : Form
    {
        Dictionary<String, Pair> dictionary;
        int ld; //Levenshtein Distance
        Pair unique = null;
        Pair totalWords = null;

        public Comparison(Dictionary<String, Pair> dictionary, int ld, Pair unique)
        {
            InitializeComponent();
            this.dictionary = dictionary;
            this.ld = ld;
        }

        public Comparison()
        {
            InitializeComponent();
        }

        private void countWords(Func<KeyValuePair<string, Pair>, int> doThis)
        {
            dgv.Rows.Clear();
            int same = 0;
            int left = 0;
            int right = 0;
            var items = from p in dictionary
                        orderby p.Key ascending
                        select p;
            unique = new Pair(0, 0);
            totalWords = new Pair(0, 0);
            string ttrLeft, ttrRight;
            foreach (KeyValuePair<string, Pair> p in items)
            {
                doThis(p);
                totalWords.a += p.Value.a;
                totalWords.b += p.Value.b;
                //dgv.Rows.Add(p.Key, p.Value.a, p.Value.b, p.Value.a - p.Value.b);
                if (p.Value.a == p.Value.b)
                {
                    same += p.Value.a;
                }
                else if (p.Value.a > p.Value.b)
                {
                    same += p.Value.b;
                    left += (p.Value.a - p.Value.b);
                }
                else
                {
                    same += p.Value.a;
                    right += (p.Value.b - p.Value.a);
                }
                if (p.Value.a > 0)
                    unique.a++;
                if (p.Value.b > 0)
                    unique.b++;
            }
            ttrLeft = (totalWords.a == 0) ? "NA" : String.Format("{0:0.00}", (double)unique.a / totalWords.a).ToString();
            ttrRight = (totalWords.b == 0) ? "NA" : String.Format("{0:0.00}", (double)unique.b / totalWords.b).ToString();
            lblResults.Text = string.Format("Frequency: {0} words concide. {1} more words on Left. {2} More words on Right. ({3:p})", same, left, right, (double)same / (same + left + right));
            lblLD.Text = string.Format("Levenshtein distance: {0}. ", ld);
            label1.Text = String.Format("Total && Unique words on Left: {0} && {1} - on Right: {2} && {3}", totalWords.a, unique.a, totalWords.b, unique.b);
            lblTTR.Text = String.Format("TTR Left: {0} - on Right: {1}", ttrLeft, ttrRight);
        }

        private int addAll(KeyValuePair<string, Pair> p)
        {
            dgv.Rows.Add(p.Key, p.Value.a, p.Value.b, p.Value.a - p.Value.b);
            return 0;
        }

        private int addDiff(KeyValuePair<string, Pair> p)
        {
            if (p.Value.a != p.Value.b)
                dgv.Rows.Add(p.Key, p.Value.a, p.Value.b, p.Value.a - p.Value.b);
            return 0;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            countWords(addAll);
            if (true)
                return;
            dgv.Rows.Clear();
            int same = 0;
            int left = 0;
            int right = 0;
            var items = from p in dictionary
                        orderby p.Key ascending
                        select p;
            foreach (KeyValuePair<string, Pair> p in items)
            {
                dgv.Rows.Add(p.Key, p.Value.a, p.Value.b, p.Value.a - p.Value.b);
                if (p.Value.a == p.Value.b)
                {
                    same += p.Value.a;
                }
                else if (p.Value.a > p.Value.b)
                {
                    same += p.Value.b;
                    left += (p.Value.a - p.Value.b);
                }
                else
                {
                    same += p.Value.a;
                    right += (p.Value.b = p.Value.a);
                }
            }
        }

        private void Comparison_Load(object sender, EventArgs e)
        {
            countWords(addDiff);
        }

        private void btnDifferences_Click(object sender, EventArgs e)
        {
            countWords(addDiff);
            if (true) return;
            dgv.Rows.Clear();
            var items = from p in dictionary
                        orderby p.Key ascending
                        select p;
            foreach (KeyValuePair<string, Pair> p in items)
            {
                if (p.Value.a != p.Value.b)
                    dgv.Rows.Add(p.Key, p.Value.a, p.Value.b, p.Value.a - p.Value.b);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
