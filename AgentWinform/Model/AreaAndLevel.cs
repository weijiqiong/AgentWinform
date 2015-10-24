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
           LevelData.Add(new ValueAndValue(){No="0",Name="精英"});
           LevelData.Add(new ValueAndValue(){No="1",Name="精英二级"});
           LevelData.Add(new ValueAndValue(){No="2",Name="精英一级"});
           LevelData.Add(new ValueAndValue(){No="3",Name="全国总代"});
           LevelData.Add(new ValueAndValue(){No="4",Name="销售经理"});
       }
    }
}
