using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

namespace RTPark.Util
{
    public class ImprimeCupom : PrintDocument
    {
        TextBox cupom;
        private Font bold = new Font("Bitstream Vera Sans Mono", 8, FontStyle.Bold);
        private Font regular = new Font("Bitstream Vera Sans Mono", 8, FontStyle.Regular);

        public ImprimeCupom(TextBox cupom)
        {
            this.cupom = cupom;
            PrinterSettings settings = new PrinterSettings();
            this.PrinterSettings.PrinterName = settings.PrinterName;
            this.OriginAtMargins = false;
            this.PrintPage += new PrintPageEventHandler(printPage);
        }

        private void printPage(object send, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawString(cupom.Text, bold, Brushes.Black, 0, 0);
           
            e.HasMorePages = false;
        }
    }
}
