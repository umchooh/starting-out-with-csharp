using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Translator
{
    public partial class languageTranslatorForm : Form
    {
        public languageTranslatorForm()
        {
            InitializeComponent();
        }

        //https://stackoverflow.com/questions/6560105/change-pictureboxs-image-to-image-from-my-resources

        private void italianbtn_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buongiorno";
            languagePictureBox.Image = Properties.Resources.Flag_of_Italy_svg;
        }

        private void spanishBtn_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos Dias";
            languagePictureBox.Image = Properties.Resources.Flag_of_Spain_svg;
        }

        private void germanBtn_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Guten Morgen";
            languagePictureBox.Image = Properties.Resources._383px_Flag_of_Germany_svg;
        }

        private void languagePictureBox_Click(object sender, EventArgs e)
        {
            //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/link-to-an-object-or-web-page-with-wf-linklabel-control?view=netframeworkdesktop-4.8
            System.Diagnostics.Process.Start(languagePictureBox.ImageLocation);
        }
    }
}
