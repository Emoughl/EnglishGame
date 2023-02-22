using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Dictionary : Form
    {
        public Dictionary()
        {
            InitializeComponent();            
               string dir =System.IO.Path.GetDirectoryName(
      System.Reflection.Assembly.GetExecutingAssembly().Location);

    string fileName = @"C:\Users\Admin\Test\Test\Data\Vocabulary.txt";
        using (var streamReader = new StreamReader(fileName, Encoding.UTF8))
         {
             string line;
         while ((line = streamReader.ReadLine()) != null)
         {
        addLabel(line);
         }
}

        }
        
        private void addLabel(string word)
        {
            Label newlable = new Label();
            newlable.Size= new Size(500,30);
            newlable.Text= word;
            this.flowLayoutPanel1.Controls.Add(newlable);
            
        }
    }
}
