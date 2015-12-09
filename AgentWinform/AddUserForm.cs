using AgentWinform.Common;
using AgentWinform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AgentWinform
{
    public partial class AddUserForm : Form
    {
        const string PhotoPath = "ImgData\\";

        const string ConSavePath = "AuthPic\\";

        const string CityXMLPath = "CityContent.xml";

        //只有页面第一次load打开时才给城市控件赋值；
        bool isLoad = true;

        //判断是只保存，还是生成授权图保存
        bool isSave = false;
        /// <summary>
        /// 用户数据
        /// </summary>
        public UserInfo UserInfo { get; set; }

        public List<UserInfo> LsUser { get; set; }

        XDocument xDoc { get; set; }

        public bool IsEdit { get; set; }
        public AddUserForm()
        {
            UserInfo = new UserInfo();
            IsEdit = false;
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            cbLevel.DataSource = Level.LevelData;

            if (UserInfo != null)//记住上一次
            {
                dtAuthNow.Value = UserInfo.AuthNow;
                dtDateStart.Value = UserInfo.AuthStart;
                dtDateEnd.Value = UserInfo.AuthEnd;
            }

            xDoc = XDocument.Load(CityXMLPath);


            var areaData = from item in xDoc.Descendants("province")
                           select new ValueAndValue() { Name = item.Attribute("name").Value.ToString(), No = item.Attribute("No").Value.ToString() };


            //省市数据Excel生成，粘贴用，正常系统请勿开启；
            //var areaDataTest =( from item in xDoc.Descendants("province")
            //               select  item.Attribute("name").Value.ToString()).ToList();


            //var CityDataTest = ( from item in xDoc.Descendants("province").Elements()

            //                     select item.Attribute("No").Value.ToString()).ToList();
            //var ttt = string.Empty;
            //foreach (var item in CityDataTest)
            //{
            //    ttt += item + "\r";
            //}


            cbArea.DataSource = areaData.ToList();
            cbArea.DisplayMember = "Name";
            cbArea.ValueMember = "No";


            cbLevel.DataSource = Level.LevelData;
            cbLevel.DisplayMember = "Name";
            cbLevel.ValueMember = "No";

            if (IsEdit)
            {
                cbIsNoEdit.Enabled = true;
                btnQuery.Enabled = false;
                Init();
            }


        }



        private void Init()
        {
            txtName.Text = UserInfo.Name == null ? string.Empty : UserInfo.Name;
            txtNameNo.Text = UserInfo.NameNo == null ? string.Empty : UserInfo.NameNo;
            txtTaobaoName.Text = UserInfo.TaobaoName == null ? string.Empty : UserInfo.TaobaoName;
            txtWeixinNo.Text = UserInfo.WeixinNo == null ? string.Empty : UserInfo.WeixinNo;
            dtAuthNow.Value = UserInfo.AuthNow;
            dtDateStart.Value =  UserInfo.AuthStart;
            dtDateEnd.Value =  UserInfo.AuthEnd;
            pbPhoto.ImageLocation = UserInfo.photoPath == null ? string.Empty : UserInfo.photoPath;
            txtAuthNo.Text = UserInfo.AuthNo == null ? string.Empty : UserInfo.AuthNo;
            txtNameSX.Text = UserInfo.NameSX == null ? string.Empty : UserInfo.NameSX;

            cbArea.SelectedItem = ValueAndValue.FindByText(cbArea, UserInfo.AreaName);
            cbLevel.SelectedItem = ValueAndValue.FindByValue(cbLevel, UserInfo.Level);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            isSave = true;
            if (SaveData())
            {

                DialogResult = DialogResult.OK;
            }

        }

        private bool SaveData()
        {
            if (txtNameSX.Text.Length<1)
            {
                MessageBox.Show("请填写姓名缩写");
                return false;
            }

            if (txtNameNo.Text.Length < 18)
            {
                MessageBox.Show("请填写18位身份证号");
                return false;
            }
            UserInfo.Name = txtName.Text;
            UserInfo.NameNo = txtNameNo.Text;
            UserInfo.TaobaoName = txtTaobaoName.Text;
            UserInfo.WeixinNo = txtWeixinNo.Text;
            txtNameSX.Text = txtNameSX.Text.Trim();
            UserInfo.NameSX = txtNameSX.Text.Substring(0, 1).ToUpper() + txtNameSX.Text.Substring(1, txtNameSX.Text.Length - 1);
           
           
           
            UserInfo.LevelName = cbLevel.SelectedItem.ToString();
            UserInfo.AuthNow = dtAuthNow.Value;
            UserInfo.AuthStart = dtDateStart.Value;
            UserInfo.AuthEnd = dtDateEnd.Value;
            UserInfo.photoPath = pbPhoto.ImageLocation;

            if (cbIsNoEdit.Checked)
            {
                UserInfo.AuthNo = txtAuthNo.Text;
            }

            var tagLevel = cbLevel.SelectedItem as ValueAndValue;
            if (tagLevel != null)
            {
                UserInfo.Level = tagLevel.No;
                UserInfo.LevelName = tagLevel.Name;
            }


            var tagArea = cbArea.SelectedItem as ValueAndValue;
            if (tagArea != null)
            {
                UserInfo.Area = tagArea.No;
                UserInfo.AreaName = tagArea.Name;
            }

            var tagCity = cbCity.SelectedItem as ValueAndValue;
            if (tagCity != null)
            {
                UserInfo.City = tagCity.No;
                UserInfo.CityName = tagCity.Name;
            }

           

            return true;
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            if (ofPhotoFile.ShowDialog() == DialogResult.OK)
            {
                UserInfo.photoPath = CopyImg(ofPhotoFile.FileName);
                pbPhoto.ImageLocation = UserInfo.photoPath;
            }

        }

        private string CopyImg(string path)
        {
            string strPath = PhotoPath;
            string str = Guid.NewGuid() + ".JPG";
            if (!Directory.Exists(strPath))
            {
                Directory.CreateDirectory(strPath);
            }
            File.Copy(path, strPath + str);
            return PhotoPath + str;
        }

        public void MakPic()
        {
            if (isSave)
            {
                return;
            }
            string strArea = string.Empty;
            string strCity = string.Empty;
            string strLevel = string.Empty;
            string strLevelNo = string.Empty;

            if (cbArea.SelectedItem!=null)
            {
                strArea = ((ValueAndValue)cbArea.SelectedItem).Name;
            }
            if (cbCity.SelectedItem != null)
            {
                strCity = ((ValueAndValue)cbCity.SelectedItem).Name;
            }
            if (cbLevel.SelectedItem != null)
            {
                strLevel = ((ValueAndValue)cbLevel.SelectedItem).Name;
                strLevelNo = ((ValueAndValue)cbLevel.SelectedItem).No;
            }
        

           
            ImgAddModel imgWater = null; 
            if (pbPhoto.Image != null)
            {
                //水印图片
                System.Drawing.Image wrImage = pbPhoto.Image;
                Image ims = ImgEdit.ZommImg(wrImage, 303, 423);
                imgWater = new ImgAddModel() { Point = new Point(125, 1141), Image = ims };
            }

            var textWater = new List<TextAddModel>();
            Color TarColor = new Color();
            TarColor = Color.White;
            //正文
            string contentText = string.Empty;
          
            string strAreaAndeCity = string.Empty;
            string strTitleArea = string.Empty;
            //直辖市问题
            if (strArea == "北京" || strArea == "天津" || strArea == "上海" || strArea == "重庆")
            {
                if (strCity == "全部")
                {
                    strAreaAndeCity = strArea + "市" ;
                    strTitleArea = strArea + "市代理授权";
                }
                else
                {
                    strAreaAndeCity = strArea + "市" + strCity;
                    strTitleArea = strArea + strCity + "代理授权";
                }
            }
            else
            {
                strAreaAndeCity = strArea + "省" + strCity + "市";
                strTitleArea = strArea + strCity + "市代理授权";
            }



            //标题
            string strTitle = UserInfo.Name;
            //textWater.Add(new TextAddModel() { Point = new Point(1212 - (strTitle.Length * 35), 1132), Text = strTitle, fontWater = new Font("黑体", 50, FontStyle.Bold), brushWater = new SolidBrush(TarColor) });
            var namePoint = UserInfo.Name.Length == 2 ? new Point(1365, 830) : new Point(1320, 830);
            textWater.Add(new TextAddModel() { Point = namePoint, Text = strTitle, fontWater = new Font("黑体", 85, FontStyle.Bold), brushWater = new SolidBrush(TarColor) });
            
            //编号
            string strAuthNo = "授权编号：" + UserInfo.AuthNo;
            textWater.Add(new TextAddModel() { Point = new Point(1600, 170), Text = strAuthNo, fontWater = new Font("黑体", 50, FontStyle.Bold), brushWater = new SolidBrush(TarColor) });

         
            
            //微信号
            string strWeixinNo = "微信号："+ UserInfo.WeixinNo;
            var fontWeixinNo= new Font("黑体", 50, FontStyle.Bold);
            Graphics graphicsWeixinNo = CreateGraphics();

            SizeF sizeWeixinNo = graphicsWeixinNo.MeasureString(strWeixinNo, fontWeixinNo);

            textWater.Add(new TextAddModel() { Point = new Point((int)(1212 - sizeWeixinNo.Width / 2), 2075), Text = strWeixinNo, fontWater = fontWeixinNo, brushWater = new SolidBrush(TarColor) });

            //授权时效
            string authTime = string.Format("有效期：{0}起{1}止", dtDateStart.Value.ToString("yyyy年MM月dd日"), dtDateEnd.Value.ToString("yyyy年MM月dd日"));
            var fontAuthTime = new Font("黑体", 50, FontStyle.Bold);
            Graphics graphicsAuthTime = CreateGraphics();
            SizeF sizeAuthTime = graphicsAuthTime.MeasureString(authTime, fontAuthTime);

            textWater.Add(new TextAddModel() { Point = new Point((int)(1212 - sizeAuthTime.Width / 2), 2356), Text = authTime, fontWater = fontAuthTime, brushWater = new SolidBrush(TarColor) });

            //身份证号
            string strNameNo = txtNameNo.Text;
            if ( txtNameNo.Text.Length >= 6)
            {
                strNameNo = strNameNo.Substring(0, 6) + "******" + strNameNo.Substring(strNameNo.Length-6, 6);
            }

            strNameNo = "身份证号：" + strNameNo;
            var fontNameNo = new Font("黑体", 50, FontStyle.Bold);
            Graphics graphicsNameNo = CreateGraphics();
            SizeF sizeNameNo = graphicsNameNo.MeasureString(strNameNo, fontNameNo);

            textWater.Add(new TextAddModel() { Point = new Point((int)(1212 - sizeNameNo.Width / 2), 2222), Text = strNameNo, fontWater = fontNameNo, brushWater = new SolidBrush(TarColor) });



     
            string Template1Path = string.Format("ImgTemplate\\{0}.jpg", strLevelNo);
            string SavePath = ConSavePath + strArea + "\\" + strCity + "\\" + txtName.Text + "-" + Guid.NewGuid().ToString() + ".Jpg";
            try
            {
                ImgEdit.ZoomAuto(Template1Path, SavePath, 2474, 3500, textWater, imgWater);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            UserInfo.AuthPhotoPath = SavePath;

        }

        private void btnMakePic_Click(object sender, EventArgs e)
        {
            isSave = false;
            if (!SaveData())
            {
                return;
            }
            if (IsEdit)
            {
                MakPic();
            }
            DialogResult = DialogResult.OK;
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vaule = cbArea.SelectedItem as ValueAndValue;
            if (vaule == null)
            {
                return;
            }
            var cityData = from item in xDoc.Descendants("province")
                           where item.Attribute("name").Value == vaule.Name
                           select item;
            cbCity.DataSource = cityData.FirstOrDefault().Elements().Select(item => new ValueAndValue() { Name = item.Value, No = item.Attribute("No").Value }).ToList();
            cbCity.DisplayMember = "Name";
            cbCity.ValueMember = "No";

            if (IsEdit)
            {
                var cityData1 = ValueAndValue.FindByText(cbCity, UserInfo.CityName);
                if (cityData1!=null)
                {
                    cbCity.SelectedItem = cityData1;                    
                }
               
            }
        }

        private void cbIsNoEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsNoEdit.Checked)
            {
                txtAuthNo.Enabled = true;
            }
            else
            {
                txtAuthNo.Enabled = false;
                txtAuthNo.Text = UserInfo.AuthNo;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (LsUser != null)
            {
                var reusultData = from item in LsUser
                                  where item.NameNo != null && item.NameNo.IndexOf(txtNameNo.Text) > -1
                                  select item;
                var resultUserInfo = reusultData.FirstOrDefault();
                if (resultUserInfo == null)
                {
                    MessageBox.Show("没有查到该身份证号");
                    return;
                }
                UserInfo = resultUserInfo;
                Init();
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtNameSX.Text = HZ2PY.GetFirstPY(txtName.Text).ToLower();
        }

    }
}
