using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;      // json
using Newtonsoft.Json.Linq; // json
using System.IO;            // 파일 관련
using ForgettingCurve.Class.Data;

namespace ForgettingCurve.Test
{
    public partial class TestForm : Form
    {
        static public string m_strJson = string.Empty;
        List<string> m_list = new List<string>();

        List<DataEntryModel> DataEntryModelList = new List<DataEntryModel>();
        IReadOnlyList<DataEntryModel> dataEntryModelList = new List<DataEntryModel>();

        public TestForm()
        {
            InitializeComponent();

            // 현재 프로젝트 이름
            string strProjectJson = Application.ProductName + ".Json";

            // 실행 파일 경로 + 프로젝트 이름
            m_strJson = System.IO.Directory.GetCurrentDirectory() + "/" + strProjectJson;
            label1.Text = m_strJson;
        }

        private void Create_Json_Button_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss");

            //// Create Json Structure
            //JObject vehicle = new JObject();
            //vehicle.Add("FirstTime", strTime);
            //vehicle.Add("LastTime", strTime);
            //vehicle.Add("ForgCurvLevel", 1);
            //vehicle.Add("ForgCurvScalar", (double)25);
            //vehicle.Add("RemembrRatio", (double)100);
            //vehicle.Add("Text", "ComeIn");

            //// List에 Json주입
            //m_list.Add(vehicle.ToString());
            //string strMessage = string.Join("\r\n", m_list.ToArray());


            //// 텍스트 박스에 Json쓰기
            //Json_textBox.Text = strMessage;

            //// 파일에 쓰기
            //File.WriteAllText(m_strJson, vehicle.ToString());



            DataEntryModel entry = new DataEntryModel()
            {
                FirstEntryTime = DateTime.Now.ToString("yyyy-MM-dd"),
                LastEntryTime = DateTime.Now.ToString("yyyy-MM-dd"),
                ForgCurvLevel = 1,
                ForgCurvScalar = 25,
                RemembrRatio = 100,
                Contents = Json_AppendBox.Text
            };

            Json_AppendBox.Text = "";

            m_list.Add(JsonConvert.SerializeObject(entry, Formatting.Indented));

            Json_textBox.Text = string.Join("\r\n", m_list.ToArray());

            FileManager.SaveToFile(m_strJson, new List<DataEntryModel> { entry });
        }

        private void Append_Json_Button_Click(object sender, EventArgs e)
        {
            string _now = DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss");

            DataEntryModel _entry = new DataEntryModel()
            {
                FirstEntryTime = DateTime.Now.ToString("yyyy-MM-dd"),
                LastEntryTime = DateTime.Now.ToString("yyyy-MM-dd"),
                ForgCurvLevel = 1,
                ForgCurvScalar = 25,
                RemembrRatio = 100,
                Contents = Json_AppendBox.Text
            };

            Json_AppendBox.Text = "";
            Json_textBox.Text = "";

            FileManager.AppendToFile(m_strJson, _entry);

            m_list.Clear();
            DataEntryModelList.Clear();

            m_list.Add(JsonConvert.SerializeObject(FileManager.LoadFromFile(m_strJson)));

            Json_textBox.Text = string.Join("\r\n\r\n", m_list.ToArray());
        }

        private void DataScan_Click(object sender, EventArgs e)
        {
            JsonFileDataRepository _repo = new JsonFileDataRepository(m_strJson);

            //       DataEntryModelList = FileManager.LoadFromFile(m_strJson);

            dataEntryModelList = _repo.GetAll();


            int _count = 0;
            DateTime _dateTime = DateTime.Now;
            string _strDateTime = _dateTime.ToString("yyyy-MM-dd");

            IReadOnlyList<DataEntryModel> _list = new List<DataEntryModel>();
            _list = _repo.Search(x => x.FirstEntry.Date == _dateTime.Date);


            //       foreach (DataEntryModel _entry in DataEntryModelList)
            //       {
            //           if (_entry.FirstEntryTime == _strDateTime)
            //           {
            //              _count++;
            //            }
            //       }

            DataMetaLabel.Text = _list.Count().ToString();
        }
    }
}
