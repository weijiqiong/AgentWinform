using AgentWinform.Common;
using AgentWinform.Model;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using XmlDatabase;

namespace AgentWinform
{
    public partial class DataListForm : Form
    {
        const string CityXMLPath = "CityContent.xml";
        public List<UserInfo> UserInfoList { get; set; }

        /// <summary>
        /// 记住上次默认输入
        /// </summary>
        public UserInfo AddUserInfo { get; set; }
        public DataListForm()
        {
            InitializeComponent();
            dataGridViewList.AutoGenerateColumns = false;
            AddUserInfo = new UserInfo();
            AddUserInfo.AuthNow = DateTime.Now;
            AddUserInfo.AuthStart = DateTime.Now;
            AddUserInfo.AuthEnd = DateTime.Now.AddMonths(2);
        }

        private void DataListForm_Load(object sender, EventArgs e)
        {
            BindGvUserInfo();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var AddForm = new AddUserForm();
            AddForm.LsUser = UserInfoList;
            if (AddUserInfo != null)
            {
                AddForm.UserInfo.AuthNow = AddUserInfo.AuthNow;
                AddForm.UserInfo.AuthStart = AddUserInfo.AuthStart;
                AddForm.UserInfo.AuthEnd = AddUserInfo.AuthEnd;
            }
            if (AddForm.ShowDialog() == DialogResult.OK)
            {
                UserInfo userInfo = AddForm.UserInfo;
                AddUserInfo = new UserInfo();
                AddUserInfo.AuthNow = userInfo.AuthNow;
                AddUserInfo.AuthStart = userInfo.AuthStart;
                AddUserInfo.AuthEnd = userInfo.AuthEnd;

                try
                {
                        //自动生成编码
                    userInfo.AuthNo = "BW" + userInfo.NameSX+userInfo.NameNo.Substring(userInfo.NameNo.Length -5,5);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("编号生成失败：" + ex.Message);
                }
                finally
                {

                    AddForm.MakPic();

                    if (!XmlEntityProcess<UserInfo>.Insert(userInfo))
                    {
                        MessageBox.Show("插入失败：" + XmlEntityProcess<UserInfo>.GetLastErrMsg());

                    }
                    else
                    {
                        MessageBox.Show("更新成功,编号为：" + userInfo.AuthNo);

                        BindGvUserInfo();

                    }
                }
            }

        }

        /// <summary>
        /// 自动生成编码
        /// </summary>
        /// <param name="ui"></param>
        /// <returns></returns>
        private string GetNo(UserInfo ui)
        {

            //自动生成编码
            int temp = 0;
            var dataLiuShui = from item in  XmlEntityProcess<UserInfo>.GetAll()
                              where item.AuthNo != null
                              && item.AuthNo.Length >= 8
                              && item.AuthNo.ToUpper().IndexOf(ui.Area.ToUpper()) >= 2
                              && item.AuthNo.Substring(4,item.AuthNo.Length-4).ToLower().IndexOf(ui.City.ToLower()) >= 0
                              && int.TryParse(item.AuthNo.Substring(item.AuthNo.Length - 3, 3), out temp)
                              select int.Parse(item.AuthNo.Substring(item.AuthNo.Length - 3, 3));

            int maxCount = dataLiuShui.Count() == 0 ? 1 : dataLiuShui.Max() + 1;

            string strMax = maxCount.ToString().PadLeft(3, '0');

            return "BW" + ui.Area.ToUpper() + ui.City.ToLower() + strMax;
        }
        private void BindGvUserInfo()
        {
            try
            {
                UserInfoList = XmlEntityProcess<UserInfo>.GetAll();
                if (UserInfoList==null)
                {
                    return;
                }
                var QueryData = UserInfoList.Where(m =>
                    (
                  (txtNameNo.Text == string.Empty || string.IsNullOrEmpty(m.AuthNo) || m.AuthNo.IndexOf(txtNameNo.Text) > -1)
                    && (txtName.Text == string.Empty || string.IsNullOrEmpty(m.Name) || m.Name.IndexOf(txtName.Text) > -1)
                     && (txtWeixinNo.Text == string.Empty || string.IsNullOrEmpty(m.WeixinNo) || m.WeixinNo.IndexOf(txtWeixinNo.Text) > -1)
                     && (m.AuthNow >= dtAuthStart.Value)
                     && (m.AuthNow <= dtAuthEnd.Value)
                 )).OrderByDescending(n => n.AuthNow).ToList();
                if (null != UserInfoList && null != QueryData)
                {
                    dataGridViewList.DataSource = QueryData;
                }
                else
                {
                    MessageBox.Show("获取数据失败：" + XmlEntityProcess<UserInfo>.GetLastErrMsg());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewList.Columns[e.ColumnIndex].Name == "ColEdit")
            {
                string str = dataGridViewList.Rows[e.RowIndex].Cells["colID"].Value.ToString();
                var toData = UserInfoList.Where(m => m.ID.ToString() == str).FirstOrDefault();
                if (toData != null)
                {
                    var AddForm = new AddUserForm();
                    AddForm.IsEdit = true;
                    AddForm.UserInfo = toData;
                    if (AddForm.ShowDialog() == DialogResult.OK)
                    {
                        UserInfo userInfo = AddForm.UserInfo;

                        if (!XmlEntityProcess<UserInfo>.Update(userInfo))
                        {
                            MessageBox.Show("更新失败：" + XmlEntityProcess<UserInfo>.GetLastErrMsg());
                            return;
                        }
                        else
                        {
                            MessageBox.Show("更新成功");
                        }

                        BindGvUserInfo();
                    }
                }
                else
                {
                    MessageBox.Show("更新失败无法找到改条记录进行修改");
                    return;
                }
            }

            if (dataGridViewList.Columns[e.ColumnIndex].Name == "colDel")
            {
                if (MessageBox.Show("确定吗?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    return;
                }
                string str = dataGridViewList.Rows[e.RowIndex].Cells["colID"].Value.ToString();
                var toData = UserInfoList.Where(m => m.ID.ToString() == str).FirstOrDefault();
                if (toData != null)
                {
                    if (!XmlEntityProcess<UserInfo>.DeleteById(toData.ID))
                    {
                        MessageBox.Show("删除失败：" + XmlEntityProcess<UserInfo>.GetLastErrMsg());
                        return;
                    }
                    BindGvUserInfo();
                }
                else
                {
                    MessageBox.Show("删除失败无法找到改条记录进行修改");
                    return;
                }
            }
            if (dataGridViewList.Columns[e.ColumnIndex].Name == "colAuthPhotoPath")
            {
                var photoPath = dataGridViewList.Rows[e.RowIndex].Cells["colAuthPhotoPath"].Value;
                if (photoPath != null)
                {    string path =photoPath.ToString();
                    System.Diagnostics.Process.Start("explorer.exe", path);
                }
               
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindGvUserInfo();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < UserInfoList.Count; i++)
            {
                UserInfoList[i].Sn = i + 1;
            }


            var data = ToExcel<UserInfo>.ToExcelFile("OutData.xlsx", UserInfoList);            

            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Title = "另存为";
                saveFileDialog1.FileName = "newExcelName.xlsx"; //设置默认另存为的名字，可选
                saveFileDialog1.Filter = "Excel 文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
                saveFileDialog1.AddExtension = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(saveFileDialog1.FileName, data);
                }
            }

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            using (OpenFileDialog opfile = new OpenFileDialog())
            {
                opfile.Filter = "Excel 文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
                if (opfile.ShowDialog() == DialogResult.OK)
                {
                    filePath = opfile.FileName;
                    Dictionary<string, string> KeyTo = new Dictionary<string, string>();

                    KeyTo.Add("姓名", "Name");
                    KeyTo.Add("身份证号", "NameNo");
                    KeyTo.Add("淘宝", "TaobaoName");
                    KeyTo.Add("微信", "WeixinNo");
                    KeyTo.Add("授权时间", "AuthNow");
                    KeyTo.Add("授权有效起始时间", "AuthStart");
                    KeyTo.Add("授权有效结束时间", "AuthEnd");
                    KeyTo.Add("代理级别", "LevelName");
                    KeyTo.Add("省", "AreaName");
                    KeyTo.Add("市", "CityName");
                    KeyTo.Add("授权编号（可以不填）", "AuthNo");
                    try
                    {
                        string StrResult = string.Empty;
                        var ResultData = UserInfoImport<UserInfo>.ExcelImport(filePath, KeyTo, out StrResult);



                        if (StrResult != string.Empty)
                        {
                            MessageBox.Show(StrResult);
                            return;
                        }


                        var xDoc = XDocument.Load(CityXMLPath);


                        var areaData = (from item in xDoc.Descendants("province")
                                        select new ValueAndValue() { Name = item.Attribute("name").Value.ToString(), No = item.Attribute("No").Value.ToString() }
                                       ).ToList();

                        var cityData = (from item in xDoc.Descendants("province").Elements()
                                        select new ValueAndValue() { Name = item.Value, No = item.Attribute("No").Value }).ToList();

                        foreach (var item in ResultData)
                        {
                            string AreaNo = areaData.Where(m => m.Name == item.AreaName).Select(n => n.No).FirstOrDefault();
                            var cityNo = cityData.Where(m => m.Name == item.CityName).Select(n => n.No).FirstOrDefault();
                            var levelNo = Level.LevelData.Where(m => m.Name == item.LevelName).Select(n => n.No).FirstOrDefault();
                            if (!string.IsNullOrEmpty(AreaNo))
                            {
                                item.Area = AreaNo;
                            }
                            if (!string.IsNullOrEmpty(cityNo))
                            {
                                item.City = cityNo;
                            }
                            if (!string.IsNullOrEmpty(levelNo))
                            {
                                item.Level = levelNo;
                            }

                            if (string.IsNullOrEmpty(item.AuthNo))
                            {
                                item.AuthNo = GetNo(item);
                            }


                            if (!XmlEntityProcess<UserInfo>.Insert(item))
                            {
                                MessageBox.Show("插入失败：" + XmlEntityProcess<UserInfo>.GetLastErrMsg());

                            }
                        }

                        MessageBox.Show("导入成功");
                        BindGvUserInfo();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

        }



    }
}
