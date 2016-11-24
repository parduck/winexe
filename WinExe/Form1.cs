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

namespace WinExe
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
        }

     
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            //일반
            //System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(".");
            //테스트
            //내꺼
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"roms");
            foreach (System.IO.DirectoryInfo d in di.GetDirectories())
            {
                listBox1.Items.Add(d.Name);
            }
        
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            
            String exStr = listBox1.SelectedItem.ToString();
           

           // string exeCmd = @"ons_win_kr\onscripter.exe -r roms\"+exStr+@"\";
            //string exeCmd = "cmd";

           // MessageBox.Show(exeCmd);

            //MessageBox.Show("\"" + @"roms\" + exStr + @"\pause.bat" + "\"");
            
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.EnableRaisingEvents = false;
           
            //테스트용
            //process.StartInfo.FileName = "\""  + exStr +@"\pause.bat" + "\""; //테스트용
           //process.StartInfo.FileName = @"cmd"; //테스트용 잘됨
            //process.StartInfo.FileName = "\"" +@"roms\" + exStr + @"\pause.bat" + "\"";
            
            //for HD
           // process.StartInfo.FileName = "\""+ exStr+@"\main.exe "+"\""; //현동이꺼

            //내꺼
            
            process.StartInfo.FileName = @"ons_win_kr\onscripter.exe ";
            process.StartInfo.Arguments =  @"-r "+@"roms\"+exStr+@"\";
                                  

            process.Start();
       
        }

        private void mouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                btn_run_Click(sender, e);
            }
        }

        private void listboxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_run_Click(sender, e);
            }
        }

       

        
    }


}
