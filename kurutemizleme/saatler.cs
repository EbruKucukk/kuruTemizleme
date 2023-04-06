using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurutemizleme
{
    public partial class saatler : Form
    {
        public saatler()
        {
            InitializeComponent();
        }
        DateTime dt = DateTime.Now;
        
        private void saatButonu1_Click(object sender, EventArgs e)
        {
           if (dt.Hour < 9) //eğer saat sabah 9'dan önceyse if yapısının içine girer
            {
                AYıkama1 ayıkama1 = new AYıkama1();
                ayıkama1.Show();

                //seçtiğimiz buton dışındaki butonları renksiz yapan switch-case yapıları
                Control saatButonu1 = ((Control)sender);
                switch (saatButonu1.BackColor.Name)
                {
                    case "Transparent":
                        saatButonu1.BackColor = Color.DarkSalmon;
                        saatButonu6.BackColor = Color.Transparent;
                        saatButonu2.BackColor = Color.Transparent;
                        saatButonu3.BackColor = Color.Transparent;
                        saatButonu4.BackColor = Color.Transparent;
                        saatButonu5.BackColor = Color.Transparent;
                        saatButonu7.BackColor = Color.Transparent;
                        saatButonu8.BackColor = Color.Transparent;
                        saatButonu9.BackColor = Color.Transparent;
                        saatButonu10.BackColor = Color.Transparent;
                        saatButonu12.BackColor = Color.Transparent;
                        break;
                    default:
                        saatButonu1.BackColor = Color.Transparent;
                        break;
                }
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--) //Bu form dışındaki açık formları kapat
                {
                    if (Application.OpenForms[i].Name == "AYıkama2")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama3")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama4")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama5")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama6")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama7")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama8")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama9")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama93")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama91")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama92")
                        Application.OpenForms[i].Close();

                }
            }
            else
            {
                messagebox5 msg5 = new messagebox5(); //eğer saat 9'u geçmişse bu saat dilimini kullanamayacağına dair uyarı verir
                msg5.Show();
            }
        }

        private void saatButonu2_Click(object sender, EventArgs e)
        {
             if (dt.Hour < 10)
              {
            AYıkama2 aykma2 = new AYıkama2();
            aykma2.Show();
            Control saatButonu2 = ((Control)sender);
                switch (saatButonu2.BackColor.Name)
                {
                    case "Transparent":
                        saatButonu2.BackColor = Color.DarkSalmon;
                        saatButonu6.BackColor = Color.Transparent;
                        saatButonu1.BackColor = Color.Transparent;
                        saatButonu3.BackColor = Color.Transparent;
                        saatButonu4.BackColor = Color.Transparent;
                        saatButonu5.BackColor = Color.Transparent;
                        saatButonu7.BackColor = Color.Transparent;
                        saatButonu8.BackColor = Color.Transparent;
                        saatButonu9.BackColor = Color.Transparent;
                        saatButonu10.BackColor = Color.Transparent;
                        saatButonu11.BackColor = Color.Transparent;
                        saatButonu12.BackColor = Color.Transparent;
                        break;
                    default:
                        saatButonu2.BackColor = Color.Transparent;
                        break;
                }
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "AYıkama1")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama3")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama4")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama5")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama6")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama7")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama8")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama9")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama93")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama91")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama92")
                        Application.OpenForms[i].Close();
                }
            }
           else
            {
                messagebox5 msg5 = new messagebox5();
                msg5.Show();
            }
        }

        private void saatButonu3_Click(object sender, EventArgs e)
        {
            if (dt.Hour < 11)
            {
                AYıkama3 ayıkma3 = new AYıkama3();
                ayıkma3.Show();
                Control saatButonu3 = ((Control)sender);
                switch (saatButonu3.BackColor.Name)
                {
                    case "Transparent":
                        saatButonu3.BackColor = Color.DarkSalmon;
                        saatButonu6.BackColor = Color.Transparent;
                        saatButonu2.BackColor = Color.Transparent;
                        saatButonu1.BackColor = Color.Transparent;
                        saatButonu4.BackColor = Color.Transparent;
                        saatButonu5.BackColor = Color.Transparent;
                        saatButonu7.BackColor = Color.Transparent;
                        saatButonu8.BackColor = Color.Transparent;
                        saatButonu9.BackColor = Color.Transparent;
                        saatButonu10.BackColor = Color.Transparent;
                        saatButonu11.BackColor = Color.Transparent;
                        saatButonu12.BackColor = Color.Transparent;
                        break;
                    default:
                        saatButonu3.BackColor = Color.Transparent;
                        break;
                }
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "AYıkama1")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama2")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama4")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama5")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama6")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama7")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama8")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama9")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama93")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama91")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama92")
                        Application.OpenForms[i].Close();
                }
            }
            else
            {
                messagebox5 msg5 = new messagebox5();
                msg5.Show();
            }
            
        }
        private void saatButonu4_Click(object sender, EventArgs e)
        {
            if (dt.Hour < 11)
            {
                AYıkama4 ayıkma4 = new AYıkama4();
                ayıkma4.Show();
                Control saatButonu4 = ((Control)sender);
                switch (saatButonu4.BackColor.Name)
                {
                    case "Transparent":
                        saatButonu4.BackColor = Color.DarkSalmon;
                        saatButonu6.BackColor = Color.Transparent;
                        saatButonu5.BackColor = Color.Transparent;
                        saatButonu3.BackColor = Color.Transparent;
                        saatButonu2.BackColor = Color.Transparent;
                        saatButonu1.BackColor = Color.Transparent;
                        saatButonu7.BackColor = Color.Transparent;
                        saatButonu8.BackColor = Color.Transparent;
                        saatButonu9.BackColor = Color.Transparent;
                        saatButonu10.BackColor = Color.Transparent;
                        saatButonu11.BackColor = Color.Transparent;
                        saatButonu12.BackColor = Color.Transparent;
                        break;
                    default:
                        saatButonu4.BackColor = Color.Transparent;
                        break;
                }
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "AYıkama1")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama3")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama2")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama5")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama6")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama7")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama8")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama9")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama93")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama91")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama92")
                        Application.OpenForms[i].Close();
                }
            }
            else
            {
                messagebox5 msg5 = new messagebox5();
                msg5.Show();
            }
            
        }
        private void saatButonu5_Click(object sender, EventArgs e)
        {
            if (dt.Hour < 12)
            {
                AYıkama5 aykma5 = new AYıkama5();
                aykma5.Show();
                Control saatButonu5 = ((Control)sender);
                switch (saatButonu5.BackColor.Name)
                {
                    case "Transparent":
                        saatButonu5.BackColor = Color.DarkSalmon;
                        saatButonu6.BackColor = Color.Transparent;
                        saatButonu4.BackColor = Color.Transparent;
                        saatButonu3.BackColor = Color.Transparent;
                        saatButonu2.BackColor = Color.Transparent;
                        saatButonu1.BackColor = Color.Transparent;
                        saatButonu7.BackColor = Color.Transparent;
                        saatButonu8.BackColor = Color.Transparent;
                        saatButonu9.BackColor = Color.Transparent;
                        saatButonu10.BackColor = Color.Transparent;
                        saatButonu11.BackColor = Color.Transparent;
                        saatButonu12.BackColor = Color.Transparent;
                        break;
                    default:
                        saatButonu5.BackColor = Color.Transparent;
                        break;
                }
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "AYıkama1")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama3")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama4")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama2")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama6")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama7")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama8")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama9")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama93")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama91")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama92")
                        Application.OpenForms[i].Close();
                }
            }
            else
            {
                messagebox5 msg5 = new messagebox5();
                msg5.Show();
            }
            
        }
        private void saatButonu6_Click(object sender, EventArgs e)
        {
            /*if (dt.Hour < 13)
            {*/
                AYıkama6 ayıkma6 = new AYıkama6();
                ayıkma6.Show();
                Control saatButonu6 = ((Control)sender);
                switch (saatButonu6.BackColor.Name)
                {
                    case "Transparent":
                        saatButonu6.BackColor = Color.DarkSalmon;
                        saatButonu4.BackColor = Color.Transparent;
                        saatButonu3.BackColor = Color.Transparent;
                        saatButonu2.BackColor = Color.Transparent;
                        saatButonu1.BackColor = Color.Transparent;
                        saatButonu5.BackColor = Color.Transparent;
                        saatButonu7.BackColor = Color.Transparent;
                        saatButonu8.BackColor = Color.Transparent;
                        saatButonu9.BackColor = Color.Transparent;
                        saatButonu10.BackColor = Color.Transparent;
                        saatButonu11.BackColor = Color.Transparent;
                        saatButonu12.BackColor = Color.Transparent;
                        break;
                    default:
                        saatButonu6.BackColor = Color.Transparent;
                        break;
                }
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "AYıkama1")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama3")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama4")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama5")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama2")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama7")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama8")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama9")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama93")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama91")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama92")
                        Application.OpenForms[i].Close();
                }
             /*   }
            else
            {
                messagebox5 msg5 = new messagebox5();
                msg5.Show();
            }*/
        }
        private void saatButonu7_Click(object sender, EventArgs e)
        {
           /* if (dt.Hour < 14)
            {*/
                AYıkama7 ayıkma7 = new AYıkama7();
                ayıkma7.Show();
                Control saatButonu7 = ((Control)sender);
                switch (saatButonu7.BackColor.Name)
                {
                    case "Transparent":
                        saatButonu7.BackColor = Color.DarkSalmon;
                        saatButonu6.BackColor = Color.Transparent;
                        saatButonu4.BackColor = Color.Transparent;
                        saatButonu3.BackColor = Color.Transparent;
                        saatButonu2.BackColor = Color.Transparent;
                        saatButonu1.BackColor = Color.Transparent;
                        saatButonu5.BackColor = Color.Transparent;
                        saatButonu8.BackColor = Color.Transparent;
                        saatButonu9.BackColor = Color.Transparent;
                        saatButonu10.BackColor = Color.Transparent;
                        saatButonu11.BackColor = Color.Transparent;
                        saatButonu12.BackColor = Color.Transparent;
                        break;
                    default:
                        saatButonu7.BackColor = Color.Transparent;
                        break;
                }
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "AYıkama1")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama3")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama4")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama5")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama6")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama2")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama8")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama9")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama93")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama91")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama92")
                        Application.OpenForms[i].Close();
                }
               /* }
           else
            {
                messagebox5 msg5 = new messagebox5();
                msg5.Show();
            }*/
        }
        private void saatButonu8_Click(object sender, EventArgs e)
        {
            if (dt.Hour < 15)
            {
                AYıkama8 ayıkma8 = new AYıkama8();
                ayıkma8.Show();
                Control saatButonu8 = ((Control)sender);
                switch (saatButonu8.BackColor.Name)
                {
                    case "Transparent":
                        saatButonu8.BackColor = Color.DarkSalmon;
                        saatButonu6.BackColor = Color.Transparent;
                        saatButonu4.BackColor = Color.Transparent;
                        saatButonu3.BackColor = Color.Transparent;
                        saatButonu2.BackColor = Color.Transparent;
                        saatButonu1.BackColor = Color.Transparent;
                        saatButonu5.BackColor = Color.Transparent;
                        saatButonu7.BackColor = Color.Transparent;
                        saatButonu9.BackColor = Color.Transparent;
                        saatButonu10.BackColor = Color.Transparent;
                        saatButonu11.BackColor = Color.Transparent;
                        saatButonu12.BackColor = Color.Transparent;
                        break;
                    default:
                        saatButonu8.BackColor = Color.Transparent;
                        break;
                }
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "AYıkama1")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama3")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama4")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama5")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama6")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama7")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama2")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama9")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama93")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama91")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama92")
                        Application.OpenForms[i].Close();
                }
                }
            else
            {
                messagebox5 msg5 = new messagebox5();
                msg5.Show();
            }
        }
        private void saatButonu9_Click(object sender, EventArgs e)
        {
           /* if (dt.Hour < 16)
            {*/
                AYıkama9 ayıkma9 = new AYıkama9();
                ayıkma9.Show();
                Control saatButonu9 = ((Control)sender);
                switch (saatButonu9.BackColor.Name)
                {
                    case "Transparent":
                        saatButonu9.BackColor = Color.DarkSalmon;
                        saatButonu6.BackColor = Color.Transparent;
                        saatButonu4.BackColor = Color.Transparent;
                        saatButonu3.BackColor = Color.Transparent;
                        saatButonu2.BackColor = Color.Transparent;
                        saatButonu1.BackColor = Color.Transparent;
                        saatButonu5.BackColor = Color.Transparent;
                        saatButonu7.BackColor = Color.Transparent;
                        saatButonu8.BackColor = Color.Transparent;
                        saatButonu10.BackColor = Color.Transparent;
                        saatButonu11.BackColor = Color.Transparent;
                        saatButonu12.BackColor = Color.Transparent;
                        break;
                    default:
                        saatButonu9.BackColor = Color.Transparent;
                        break;
                }
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "AYıkama1")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama3")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama4")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama5")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama6")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama7")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama8")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama2")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama93")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama91")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama92")
                        Application.OpenForms[i].Close();
                }
           /* }
            else
            {
                messagebox5 msg5 = new messagebox5();
                msg5.Show();
            }*/

        }
        private void saatButonu10_Click(object sender, EventArgs e)
        {

           /* if (dt.Hour < 17)
            {*/
                AYıkama93 aykma93 = new AYıkama93();
                aykma93.Show();
                Control saatButonu10 = ((Control)sender);
                switch (saatButonu10.BackColor.Name)
                {
                    case "Transparent":
                        saatButonu10.BackColor = Color.DarkSalmon;
                        saatButonu6.BackColor = Color.Transparent;
                        saatButonu4.BackColor = Color.Transparent;
                        saatButonu3.BackColor = Color.Transparent;
                        saatButonu2.BackColor = Color.Transparent;
                        saatButonu1.BackColor = Color.Transparent;
                        saatButonu5.BackColor = Color.Transparent;
                        saatButonu7.BackColor = Color.Transparent;
                        saatButonu8.BackColor = Color.Transparent;
                        saatButonu9.BackColor = Color.Transparent;
                        saatButonu11.BackColor = Color.Transparent;
                        saatButonu12.BackColor = Color.Transparent;
                        break;
                    default:
                        saatButonu10.BackColor = Color.Transparent;
                        break;
                }
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "AYıkama1")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama3")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama4")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama5")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama6")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama7")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama8")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama9")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama92")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama91")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama2")
                        Application.OpenForms[i].Close();
                }
        /*    }
            else
            {
                messagebox5 msg5 = new messagebox5();
                msg5.Show();
            }*/

        }
        private void saatButonu11_Click(object sender, EventArgs e)
        {
            
            if (dt.Hour < 17)
            {
                AYıkama91 ayıkma11 = new AYıkama91();
                ayıkma11.Show();
                Control saatButonu11 = ((Control)sender);
                switch (saatButonu11.BackColor.Name)
                {
                    case "Transparent":
                        saatButonu11.BackColor = Color.DarkSalmon;
                        saatButonu6.BackColor = Color.Transparent;
                        saatButonu4.BackColor = Color.Transparent;
                        saatButonu3.BackColor = Color.Transparent;
                        saatButonu2.BackColor = Color.Transparent;
                        saatButonu1.BackColor = Color.Transparent;
                        saatButonu5.BackColor = Color.Transparent;
                        saatButonu7.BackColor = Color.Transparent;
                        saatButonu8.BackColor = Color.Transparent;
                        saatButonu9.BackColor = Color.Transparent;
                        saatButonu10.BackColor = Color.Transparent;
                        saatButonu12.BackColor = Color.Transparent;
                        break;
                    default:
                        saatButonu11.BackColor = Color.Transparent;
                        break;
                }
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "AYıkama1")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama3")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama4")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama5")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama6")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama7")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama8")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama9")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama93")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama2")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama92")
                        Application.OpenForms[i].Close();
                }
             }
            else
            {
                messagebox5 msg5 = new messagebox5();
                msg5.Show();
            }
        }
        private void saatButonu12_Click(object sender, EventArgs e)
        {
            if (dt.Hour < 18)
            {
                AYıkama92 ayıkma12 = new AYıkama92();
                ayıkma12.Show();
                Control saatButonu12 = ((Control)sender);
                switch (saatButonu12.BackColor.Name)
                {
                    case "Transparent":
                        saatButonu12.BackColor = Color.DarkSalmon;
                        saatButonu6.BackColor = Color.Transparent;
                        saatButonu4.BackColor = Color.Transparent;
                        saatButonu3.BackColor = Color.Transparent;
                        saatButonu2.BackColor = Color.Transparent;
                        saatButonu1.BackColor = Color.Transparent;
                        saatButonu5.BackColor = Color.Transparent;
                        saatButonu7.BackColor = Color.Transparent;
                        saatButonu8.BackColor = Color.Transparent;
                        saatButonu9.BackColor = Color.Transparent;
                        saatButonu10.BackColor = Color.Transparent;
                        saatButonu11.BackColor = Color.Transparent;
                        break;
                    default:
                        saatButonu12.BackColor = Color.Transparent;
                        break;
                }
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "AYıkama1")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama2")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama3")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama4")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama5")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama6")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama7")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama8")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama9")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama93")
                        Application.OpenForms[i].Close();
                    else if (Application.OpenForms[i].Name == "AYıkama91")
                        Application.OpenForms[i].Close();
                }
            }
            else
            {
                messagebox5 msg5 = new messagebox5();
                msg5.Show();
                AYıkama92 ayıkma12 = new AYıkama92();
                ayıkma12.Close();
            }

        }
        private void saatler_Load(object sender, EventArgs e)
        {
            //arka plan rengini görünmez yapar
            this.TransparencyKey = Color.Cyan; 
            this.BackColor = Color.Cyan;

        }

        private void saatButonu13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
