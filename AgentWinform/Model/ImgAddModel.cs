using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AgentWinform.Model
{
   public class ImgAddModel
    {
       public Point Point { get; set; }
       public Image Image { get; set; }
    }

   public class TextAddModel
   {
       public Point Point { get; set; }
       public String Text { get; set; }

       public Font fontWater { get; set; }
       public Brush brushWater { get; set; }
   }
}
