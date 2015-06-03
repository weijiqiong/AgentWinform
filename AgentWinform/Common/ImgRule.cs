using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AgentWinform.Common
{
  public  class ImgRuleV1
    {
      KeyValuePair<Point, string> ImgWater  {  get;set;}

      Dictionary<Point, string> TextWater { get; set; }

      ImgRuleV1(KeyValuePair<Point, string> imgWater, Dictionary<Point, string> textWater)
      {
          ImgWater = imgWater;
          TextWater = textWater;           
      }
    }
}
