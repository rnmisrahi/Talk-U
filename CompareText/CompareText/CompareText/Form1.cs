using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CompareText
{
  public partial class Form1 : Form
  {
    char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n', '\r' };
    string[] words;
    Pair unique = null;

    Dictionary<String, Pair> dictionary;

    public Form1()
    {
      InitializeComponent();
    }

    private void btnFile1_Click(object sender, EventArgs e)
    {
      DialogResult dr = openFileDialog1.ShowDialog();
      if (dr == DialogResult.OK)
      {
        textFile1.Text = openFileDialog1.FileName;
        textBox1.Text = File.ReadAllText(textFile1.Text);
        //CountWords(textBox1.Text, true);
      }
    }

    private void CountWords(string text, bool isLeft)
    {
      string st;
      Pair pair;
      words = text.Split(delimiterChars);
      foreach (string s in words)
      {
        st = s.Trim().ToLower();
        st = st.Replace("*", "");
        if (!String.IsNullOrEmpty(st))
        {
          if (dictionary.ContainsKey(st))
          {
            pair = dictionary[st];
            if (isLeft)
              pair.a++;
            else
              pair.b++;
            dictionary[st] = pair;
          }
          else
          {
            if (isLeft)
            {
              dictionary.Add(st, new Pair(1, 0));
              unique.a++;
            }
            else
            {
              dictionary.Add(st, new Pair(0, 1));
              unique.b++;
            }              
          }
        }
      }
    }

    private void btnFile2_Click(object sender, EventArgs e)
    {
      DialogResult dr = openFileDialog1.ShowDialog();
      if (dr == DialogResult.OK)
      {
        textFile2.Text = openFileDialog1.FileName;
        textBox2.Text = File.ReadAllText(textFile2.Text);
      }
    }

    private void btnCompare_Click(object sender, EventArgs e)
    {
      dictionary = new Dictionary<String, Pair>();
      unique = new Pair(0, 0);
      CountWords(textBox1.Text, true);
      CountWords(textBox2.Text, false);
      int d = LevenshteinDistance.Compute(textBox1.Text, textBox2.Text);
      Comparison dlg = new Comparison(dictionary, d, unique);
      dlg.ShowDialog(this);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }
  }
}
