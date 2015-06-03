using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgentWinform.Model
{
  

   public  class Level
    {
       public static List<ValueAndValue> LevelData { get; set; }
       static Level()
       {
           LevelData = new List<ValueAndValue>();
           LevelData.Add(new ValueAndValue(){No="0",Name="市级"});
           LevelData.Add(new ValueAndValue(){No="1",Name="区域商"});
           LevelData.Add(new ValueAndValue(){No="2",Name="批发商"});
           LevelData.Add(new ValueAndValue(){No="3",Name="零售商"});
           LevelData.Add(new ValueAndValue(){No="4",Name="分销商"});
           LevelData.Add(new ValueAndValue() { No = "5", Name = "省级" });
       }
    }
}
