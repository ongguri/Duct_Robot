using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

using System.IO;
using System.IO.Ports;

// 필요한 openCM 파일 이름
// ID_change -> 모터 ID 설정
// SerialReadUSB3 -> 모터 조정

namespace Duct_Robot
{
    public partial class Form1 : Form
    {
        string cam_path = "http://192.168.0.81:81/stream";

        VideoCapture vc = new VideoCapture();

        byte[] _writeBuffer = new byte[30];
        byte[] _motor = new byte[3];
        int[] _sensor = new int[6];

        string[] B_mode = { "강도 선택", "약", "중", "강", "정지" };

        public Form1()
        {
            InitializeComponent();

            serialPort1.PortName = "COM6";
      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 스틸이미지를 저장할 공간을 만듦
            Mat image = new Mat();
            // 스틸이미지 한장을 읽어옴
            vc.Read(image);

            // 읽어온 이미지를 픽처박스에 드로잉
            Video_Screen.ImageIpl = image;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vc.Open(cam_path);

            comboBox1.Items.AddRange(B_mode);
            comboBox1.SelectedIndex = 0;
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            // 타이머가 멈춰있으면
            if (timer1.Enabled == false)
            {
                // 작동시킴
                timer1.Start();
            }

            if(!serialPort1.IsOpen)
            {
                serialPort1.Open();
                label1.Text = "Open";
            }
        }

        void SendMotorAngles()
        {
            _writeBuffer[0] = (byte)'S';
            _writeBuffer[1] = (byte)'y';

            _writeBuffer[2] = _motor[0];
            _writeBuffer[3] = _motor[1];
            _writeBuffer[4] = _motor[2]; // temp

            int size = 5;
            serialPort1.Write(_writeBuffer, 0, size);

        }

        private void End_Button_Click(object sender, EventArgs e)
        {
            // 타이머가 작동중이면
            if (timer1.Enabled == true)
            {
                // 타이머를 멈춤
                timer1.Stop();
            }

            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                label1.Text = "Close";
            }
        }

        private void Forward_Bar_Scroll(object sender, EventArgs e)
        {
            if (label2.Text == "비상 멈춤")
            {
                label4.Text = "청소 동작 상태 라벨";
            }

            label2.Text = "앞으로 " + Forward_Bar.Value.ToString() + "속도로 가는중...";

            if(Forward_Bar.Value == 0)
            {
                label2.Text = "현재 덕트로봇이 멈춰있습니다^^";
            }

            _motor[1] = (byte)Forward_Bar.Value;
            SendMotorAngles();
        }

        private void Back_Bar_Scroll(object sender, EventArgs e)
        {
            if (label2.Text == "비상 멈춤")
            {
                label4.Text = "청소 동작 상태 라벨";
            }

            label2.Text = "뒤로 " + Back_Bar.Value.ToString() + "속도로 가는중...";

            if (Back_Bar.Value == 0)
            {
                label2.Text = "현재 덕트로봇이 멈춰있습니다^^";
            }

            _motor[1] = (byte)(Back_Bar.Value+128);
            SendMotorAngles();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (label4.Text == "비상 멈춤")
            {
                label2.Text = "안녕하세요?";
            }

            if (comboBox1.SelectedIndex == 1)
            {
                label4.Text = "현재 약 으로 청소 중 입니다.";
                _motor[0] = 0;
                SendMotorAngles();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label4.Text = "현재 중 으로 청소 중 입니다.";
                _motor[0] = 1;
                SendMotorAngles();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label4.Text = "현재 강 으로 청소 중 입니다.";
                _motor[0] = 2;
                SendMotorAngles();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label4.Text = "덕트로봇 근무태만";
                _motor[0] = 3;
                SendMotorAngles();
            }
        }

        private void Emergency_Click(object sender, EventArgs e)
        {
            _motor[0] = 3;
            _motor[1] = 0;
            Forward_Bar.Value = 0;
            Back_Bar.Value = 0;
            comboBox1.SelectedIndex = 0;
            
            label2.Text = "비상 멈춤";
            label4.Text = "비상 멈춤";
            SendMotorAngles();
        }
    }
}
