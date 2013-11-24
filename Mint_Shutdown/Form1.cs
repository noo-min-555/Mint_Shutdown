using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ส่วนนี้ที่เพิ่มเข้ามาสำคัญนะครับ ทำให้ใช้คำสั่งปิดเครื่องได้ครับ
using System.Diagnostics;

namespace Mint_Shutdown
{
    public partial class ShutDown : Form
    {
        public ShutDown()
        {
            InitializeComponent();
                    }
       // เหมือนเคยครับกำหนดตัวแปลที่จำเป็นต้องใช้ก่อนเลย 
        DateTime d1 = DateTime.Now;// บรรทัดนี้เพื่อเวลาเท่ากับเวลาจริงครับ
        int d2minute;
        int d2hour;
        int dlhour;
        int dlminute;
     //   ส่วนนี้สำหรับปุ่มตั้งเวลาครับ มาดูกัน
        private void buttonshutdown_Click(object sender, EventArgs e)
        {
            //กำหนดเงื่อนไขครับว่าต้องใส่ค่าก่อนเท่านั้นครับถึงจะดำเนินการ
            if ((comboBox1.Text == "ชั่วโมง") || (comboBox2.Text == "นาที"))
            {
                MessageBox.Show("กรุณาเลือก ชั่วโมงและนาที ก่อน", "ผิดพลาด");
            }
                       //ส่วนนี้เองครับที่ผมบอกยังไม่ 100% เพราะผมกำหนดให้
           //ใส่ได้แค่เวลาที่มากกว่าเวลาปัจจุบันครับ
            else
            {
                d2hour = Convert.ToInt32(comboBox1.Text);
                d2minute = Convert.ToInt32(comboBox2.Text);
                if (d2hour < d1.Hour)
                {
                    MessageBox.Show("กรุณาตั้งเวลาให้ถูกต้อง", "ผิดพลาด");
                }
                else if ((d2minute < d1.Minute) && (d2hour == d1.Hour))
                {
                    MessageBox.Show("กรุณาตั้งเวลาให้ถูกต้อง", "ผิดพลาด");
                }
              //  ถ้าทุกอย่างถูกต้องก็เริ่มทำการเลยครับ
                else
                {
                    MessageBox.Show("เวลาที่คุณตั้งคือ "+d2hour+" : "+d2minute+" น.", "ตั้งเวลาปิด");
                    timer1.Enabled = true;
                    label7.Visible = true;
                    label6.Visible = true;
                    label5.Visible = true;
                }
            }




  //  ตอนโหลดฟอรมครับผมไม่แสดงเวลาที่เหลือครับ

        }

        private void ShutDown_Load(object sender, EventArgs e)
        {
            
            comboBox1.Text = "ชั่วโมง";
            comboBox2.Text = "นาที";
            timer2.Enabled = true;
            label7.Visible = false;
            label6.Visible = false;
        }
        // ส่วนสำคัญอยู่ตรงนี้

        private void timer1_Tick(object sender, EventArgs e)
        
        {
            //   แน่นอนครับต้องแปลงข้อมูลให้เป็นฟอแมทที่เราต้องการก่อนเพื่อการคำนวณและแน่นอนต้องตั้งเวลาให้เป็นปัจจุบันอยู่เสมอครับ
            timer2.Enabled = false;
            DateTime d1 = DateTime.Now;

            dlhour = d2hour - Convert.ToInt32(d1.Hour);
            dlminute = d2minute - Convert.ToInt32(d1.Minute);
          //  ส่วนนี้ผมกำหนดให้ถ้านาทีนับลงครบ จาก 60-0 แล้ว ให้ชั่วโมงลดลง 1 ครับ และเปลี่ยนนาทีเป็น 60 เช่นเคย
            if (dlminute <= 0) { dlhour -= 1; dlminute += 60; }
            if (dlhour < 0) { dlhour = 0; }
           // ส่วนนี้เป็นส่วนแสดงผลครับ
            labeltime.Text = Convert.ToString(d1.Hour) + " : " + Convert.ToString(d1.Minute) + " : " + Convert.ToString(d1.Second) + " น. ";
            if (dlminute == 60)
            {
                labeltimeleft.Text = Convert.ToString(dlhour) + " : 0 นาที ";
            }
            else
            {
                labeltimeleft.Text = Convert.ToString(dlhour) + " ชั่วโมง " + Convert.ToString(dlminute) + " นาที ";
            }
           // นี่ไงครับ พระเอกของเราอยู่ตรงนี้ สั่งให้ปิดเครื่องเมื่อเวลาถึงตามที่กำหนดครับ
            if ((d1.Hour==d2hour) && (d1.Minute==d2minute))
            {
                //คำสั่งปิดเครื่องครับ
                Process.Start("shutdown.exe", "-s -t 00");
            }
        }

        private void buttonshutdown_DragOver(object sender, DragEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void วธใชToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("เลือกเวลา ชั่้วโมงและนาที จากนั้นกดปุ่ม ตั้งเวลาปิด เสร็จแล้วห้ามปิดโปรแกรมนะครับ\n"+"พอครบเวลาเครื่องจะ Shut down เองครับ","วิธีใช้");
        }

        private void เกยวกบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mint_Shut : โปรแกรมตั้งเวลาปิดเครื่องคอมพิวเตอร์ \n\nโดย : นางสาวกันต์กนิษฐ์ อรุณบรรเจิดกุล 553266101 16.3 ", "เกี่ยวกับ");
        }

        private void ปดเครองToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-s -t 00");
        }

        private void รสตารทToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 00");
        }

        private void ปดโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    

        }

  
        

   
    }


