using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using standControl.Library;
using Microsoft.Office.Interop.Word;
using System.Diagnostics;

using Task = System.Threading.Tasks.Task;
using System.Windows;

namespace standControl.application.GUI.Model
{
    [Serializable]
    public class MainModel
    {
        Microsoft.Office.Interop.Word.Application wordApp;
        static DateTime StartT, StopT;
        static fileBalkan balkan;
        static ModbusPLC modbusPLC;
        static float[] Point01;
        static float[] Point02;
        static float[] Point03;
        static float[] Point04;
        static float[] Point05;
        static float[] Point06;
        static float[] Point07;
        static float[] Point08;
        static float[] Point09;
        static float[] Point10;
        static float[] Point11;
        static float[] Point12;
        static float[] Point13;
        static float[] Point14;
        #region Tags Write


        public string prodName { get; set; }

        public string modName { get; set; }

        public string modTime { get; set; }
        public string expPlace { get; set; }
        public string expType { get; set; }
        public string expClass { get; set; }
        public string expDate { get; set; }
        public string protNumb { get; set; }
        public string prot { get; set; }
        public string client { get; set; }
        public string pump { get; set; }
        public string pumpNumb { get; set; }
        public string pumpMode { get; set; }
        public string orderNumb { get; set; }
        public string orderNum { get; set; }
        public double d2Out { get; set; }
        public double d1In { get; set; }
        public double dWork { get; set; }
        public double Zm1 { get; set; }
        public double Zm2 { get; set; }
        public double dZm { get; set; }
        public double ZtempAir { get; set; }
        public double bPress { get; set; }

        public string driveMode { get; set; }
        public string driveType { get; set; }
        public double drivePhase { get; set; }
        public double drivePow { get; set; }
        public double driveSpeed { get; set; }
        public double driveCurr { get; set; }
        public double driveVolt { get; set; }

        public double qNom { get; set; }
        public double hNom { get; set; }
        public double speedNom { get; set; }
        public double KPDNom { get; set; }
        public double powNom { get; set; }
        public double pH { get; set; }
        public double kVz { get; set; }
        public double Ksmog { get; set; }
        #endregion
        #region Modbus Tags
        /// Modbus value
        static public float Power_A { get; private set; }
        static public float Power_B { get; private set; }
        static public float Power_C { get; private set; }
        static public float Power_me110 { get; private set; }
        static public float Voltage_A { get; private set; }
        static public float Voltage_B { get; private set; }
        static public float Voltage_C { get; private set; }
        static public float Voltage_me110 { get; private set; }
        static public float Current_A { get; private set; }
        static public float Current_B { get; private set; }
        static public float Current_C { get; private set; }
        static public float Current_me110 { get; private set; }
        static public float Frequency { get; private set; }
        static public float Frequency_me110 { get; private set; }
        static public float TempH2o01 { get; private set; }
        static public float TempH2o02 { get; private set; }
        static public float TempPodsh101 { get; private set; }
        static public float TempPodsh201 { get; private set; }
        static public float TempPodsh102 { get; private set; }
        static public float TempPodsh202 { get; private set; }

        static public float Pressure01 { get; private set; }
        static public float Pressure02 { get; private set; }
        static public float Rate01 { get; private set; }
        static public float Rate02 { get; private set; }
        static public int Pump01StatusOn { get; private set; }
        static public int Pump02StatusOn { get; private set; }
        static public bool ModbusStatusOk { get; private set; }
        #endregion
        #region Balkan Tags
        //Balkan

        static public float speed { get; private set; }
        static public float vibroOne { get; private set; }
        static public float vibroTwo { get; private set; }
        static public float phaseOne { get; private set; }
        static public float phaseTwo { get; private set; }
        static public bool BalkanStatusOk { get; private set; }
        #endregion
        //math prop

        static public bool set01 { get; set; }
        static public bool set02 { get; set; }
        static public bool set03 { get; set; }
        static public bool set04 { get; set; }
        static public bool set05 { get; set; }
        static public bool set06 { get; set; }
        static public bool set07 { get; set; }
        static public bool set08 { get; set; }
        static public bool set09 { get; set; }
        static public bool set10 { get; set; }
        static public bool set11 { get; set; }
        static public bool set12 { get; set; }
        static public bool set13 { get; set; }
        static public bool set14 { get; set; }



        //
        public int rashReg { get; set; }
        public int exspReg { get; set; }
        static public float procPers { get; private set; }

        public MainModel()
        {
            balkan = new fileBalkan();
            modbusPLC = new ModbusPLC();
            modbusPLC.Notify += ModbusPLC_Notify;
            modbusPLC.NotifyErr += ModbusPLC_NotifyErr;
            balkan.Notify += Balkan_Notify;
            balkan.NotifyErr += Balkan_NotifyErr;
        }

        private void Balkan_NotifyErr(object sender, BalkanEventArgs e)
        {
            BalkanStatusOk = balkan.statusOk;
        }

        private void ModbusPLC_NotifyErr(object sender, ModbusClientEventArgs e)
        {
            ModbusStatusOk = modbusPLC.statusOk;
        }

        private void ModbusPLC_Notify(object sender, ModbusClientEventArgs e)
        {

            Console.WriteLine("Modbus varieble = {0} ", e.Array);


            Power_A = modbusPLC.Power_A;
            Power_B = modbusPLC.Power_B;
            Power_C = modbusPLC.Power_C;
            Power_me110 = modbusPLC.Power_me110;
            Voltage_A = modbusPLC.Voltage_A;
            Voltage_B = modbusPLC.Voltage_B;
            Voltage_C = modbusPLC.Voltage_C;
            Voltage_me110 = modbusPLC.Voltage_me110;
            Current_A = modbusPLC.Current_A;
            Current_B = modbusPLC.Current_B;
            Current_C = modbusPLC.Current_C;
            Current_me110 = modbusPLC.Current_me110;
            Frequency = modbusPLC.Frequency;
            Frequency_me110 = modbusPLC.Frequency_me110;
            TempH2o01 = modbusPLC.TempH2o01;
            TempH2o02 = modbusPLC.TempH2o02;
            TempPodsh101 = modbusPLC.TempPodsh101;
            TempPodsh201 = modbusPLC.TempPodsh201;
            TempPodsh102 = modbusPLC.TempPodsh102;
            TempPodsh202 = modbusPLC.TempPodsh202;
            Pressure01 = modbusPLC.Pressure01;
            Pressure02 = modbusPLC.Pressure02;
            Rate01 = modbusPLC.Rate01;
            Rate02 = modbusPLC.Rate02;
            Pump01StatusOn = modbusPLC.Pump01StatusOn;
            Pump02StatusOn = modbusPLC.Pump02StatusOn;
            ModbusStatusOk = modbusPLC.statusOk;
            Console.WriteLine(Pump01StatusOn);
        }

        private void Balkan_Notify(object sender, BalkanEventArgs e)
        {
            speed = e.Speed;
            Console.WriteLine("Speed={0}", e.Speed.ToString());
            vibroOne = e.VibroOne;
            Console.WriteLine("VibroOne={0}", e.VibroOne.ToString());
            vibroTwo = e.VibroTwo;
            Console.WriteLine("VibroTwo={0}", e.VibroTwo.ToString());
            phaseOne = e.PhaseOne;
            Console.WriteLine("PhaseOne={0}", e.PhaseOne.ToString());
            phaseTwo = e.PhaseTwo;
            Console.WriteLine("PhaseTwo={0}", e.PhaseTwo.ToString());
            BalkanStatusOk = balkan.statusOk;
        }
        public void PunmpRun()
        {
            StartT = DateTime.Now;
            modbusPLC.RunPump(1);
        }
        public void PunmpStop()
        {
            modbusPLC.StopPump(1);
        }
        public void PointClear()
        {

            for (int i = 0; i < 33; i++)
            {
                if (set01)
                {
                    Point01[i] = 0;
                    set01 = false;
                }
                if (set02)
                {
                    Point02[i] = 0;
                    set02 = false;
                }
                if (set03)
                {
                    Point03[i] = 0;
                    set03 = false;
                }
                if (set04)
                {
                    Point04[i] = 0;
                    set04 = false;
                }
                if (set05)
                {
                    Point05[i] = 0;
                    set05 = false;
                }
                if (set06)
                {
                    Point06[i] = 0;
                    set06 = false;
                }
                if (set07)
                {
                    Point07[i] = 0;
                    set07 = false;
                }
                if (set08)
                {
                    Point08[i] = 0;
                    set08 = false;
                }
                if (set09)
                {
                    Point09[i] = 0;
                    set09 = false;
                }
                if (set10)
                {
                    Point10[i] = 0;
                    set10 = false;
                }
                if (set11)
                {
                    Point11[i] = 0;
                    set11 = false;
                }
                if (set12)
                {
                    Point12[i] = 0;
                    set12 = false;
                }
                if (set13)
                {
                    Point13[i] = 0;
                    set13 = false;
                }
                if (set14)
                {
                    Point14[i] = 0;
                    set14 = false;
                }
            }
        }
        public void SetPoint(int numb)
        {
            switch (numb)
            {
                case 1: Point01 = ResolvTable(); set01 = true; break;
                case 2: Point02 = ResolvTable(); set02 = true; break;
                case 3: Point03 = ResolvTable(); set03 = true; break;
                case 4: Point04 = ResolvTable(); set04 = true; break;
                case 5: Point05 = ResolvTable(); set05 = true; break;
                case 6: Point06 = ResolvTable(); set06 = true; break;
                case 7: Point07 = ResolvTable(); set07 = true; break;
                case 8: Point08 = ResolvTable(); set08 = true; break;
                case 9: Point09 = ResolvTable(); set09 = true; break;
                case 10: Point10 = ResolvTable(); set10 = true; break;
                case 11: Point11 = ResolvTable(); set11 = true; break;
                case 12: Point12 = ResolvTable(); set12 = true; break;
                case 13: Point13 = ResolvTable(); set13 = true; break;
                case 14: Point14 = ResolvTable(); set14 = true; break;
            }

        }
        float[] ResolvTable()
        {
            float[] Data = new float[33];
            float d;
            var deltaT = DateTime.Now - StartT;
            Data[0] = (float)deltaT.TotalMinutes;
            Data[1] = speed;
            if (rashReg == 1)
            {
                Data[2] = Rate02;
                d = Convert.ToSingle(dWork);
            }
            else
            {
                Data[2] = Rate01;
                d = Convert.ToSingle(dWork);
            }

            var Q = mathConvert.pumpQ(mathConvert.PlotnH20(TempH2o02), mathConvert.qMhConvertLs(Data[2]));
            Data[3] = Q/360F;
            Data[4] = Pressure01*1000F ;
            Data[5] = Pressure02*1000F;
            Data[6] = Pressure01*1000F ;
            Data[7] = Pressure02 *1000F;
            // Data[8] =0;
            var dZ = Convert.ToSingle(Zm2 - Zm1);
            Data[9] = dZ;
            var Pm1 = mathConvert.PaConvert(Pressure01);
            var Pm2 = mathConvert.PaConvert(Pressure02);
            var plt = mathConvert.PlotnH20(TempH2o01);
            var d1 = Convert.ToSingle(d1In);
            var d2 = Convert.ToSingle(d2Out);
            var H = mathConvert.pumpHver2(Pm1, Pm2, plt, Q, d1, d2, Convert.ToSingle(Zm1),Convert.ToSingle(Zm2));
            Data[10] = H;
            Data[11] = mathConvert.U22G(Q, d);
            // Data[12] = 0;
            Data[13] = (Power_B + Power_A) / 2;
            Data[14] = (Voltage_B + Voltage_A) / 2F;
            Data[15] = (Current_B + Current_A) / 2F;
            Data[16] = Power_B;
            Data[17] = Power_A;
            var P = (Power_B + Power_A) / 2;
            Data[18] = P;
            // Data[19] = 0;
           // Data[20] = Convert.ToSingle(KPDNom) / P;
            Console.WriteLine(Data[20]);
            // Data[21] = 0;
            // Data[22] = 0;
            Data[23] = mathConvert.pumpKpd(plt, Q, H, P)*100F;
            if (Data[22]==0)
            {
                Data[20] = Data[23];
            }
            Data[23] = mathConvert.pumpKpd(plt, Q, H, P);
            Console.WriteLine(Data[23]);
            /// Data[24] = 0;
            Data[25] = Q / Convert.ToSingle(qNom);
            Data[26] = H / Convert.ToSingle(hNom);
            Data[27] = P / Convert.ToSingle(powNom);
            // Data[28] = 0;
            Data[29] = vibroOne;
            Data[30] = phaseOne;
            Data[31] = vibroTwo;
            Data[32] = phaseTwo;
            return Data;
        }
        private static void ReplaceWordStub(string stubToReplace, string text, ref Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
        public async void CreateProtocol()
        {
            try
            {
                await Task.Run(() =>
            {
                procPers = 0F;

                string path = @"C:\Protocols";
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                if (File.Exists(@"C:\Protocols\TemplayProtocol.docx"))
                {
                    File.Delete(@"C:\Protocols\TemplayProtocol.docx");
                }
                File.Copy("TemplayProtocol.docx", @"C:\Protocols\TemplayProtocol.docx");
                wordApp = new Microsoft.Office.Interop.Word.Application();

                wordApp.Visible = false;
                var wordDocument = wordApp.Documents.Open(@"C:\Protocols\TemplayProtocol.docx");
                procPers += 5;
                ReplaceWordStub("{productName}", prodName, ref wordDocument);
                ReplaceWordStub("{productMade}", modName, ref wordDocument);
                ReplaceWordStub("{exspDate}", expDate, ref wordDocument);
                ReplaceWordStub("{expDate}", expDate, ref wordDocument);
                ReplaceWordStub("{exspPlace}", expPlace, ref wordDocument);
                ReplaceWordStub("{exspType}", expType, ref wordDocument);
                ReplaceWordStub("{exspClass}", expClass, ref wordDocument);
                ReplaceWordStub("{client}", client, ref wordDocument);
                ReplaceWordStub("{prot}", prot, ref wordDocument);
                ReplaceWordStub("{ModeNumb}", pumpNumb, ref wordDocument);
                ReplaceWordStub("{protNumb}", protNumb, ref wordDocument);
                ReplaceWordStub("{OrderNum}", orderNum, ref wordDocument);
                ReplaceWordStub("{OrderNumb}", orderNumb, ref wordDocument);
                ReplaceWordStub("{D1}", string.Format("{0:0.000}", d1In), ref wordDocument);
                ReplaceWordStub("{D2}", string.Format("{0:0.000}", d2Out), ref wordDocument);
                ReplaceWordStub("{DWork}", string.Format("{0:0.000}", dWork), ref wordDocument);
                ReplaceWordStub("{QNom}", string.Format("{0:0.00}", qNom), ref wordDocument);
                ReplaceWordStub("{HNom}", string.Format("{0:0.00}", hNom), ref wordDocument);
                ReplaceWordStub("{SpeedNom}", string.Format("{0}", speedNom), ref wordDocument);
                ReplaceWordStub("{PowNom}", string.Format("{0:0.00}", powNom), ref wordDocument);
                ReplaceWordStub("{KPDNom}", string.Format("{0:0.00}", KPDNom), ref wordDocument);
                ReplaceWordStub("{temH2o}", string.Format("{0:0.00}", TempH2o02), ref wordDocument);
                ReplaceWordStub("{pltH2o}", string.Format("{0:0.00}", mathConvert.PlotnH20(TempH2o02)), ref wordDocument);
                ReplaceWordStub("{Psmog}", string.Format("{0:0.00}", Ksmog), ref wordDocument);
                ReplaceWordStub("{Kvz}", string.Format("{0:0.00}", kVz), ref wordDocument);
                ReplaceWordStub("{PH}", string.Format("{0:0.00}", pH), ref wordDocument);
                ReplaceWordStub("{MadeName}", driveMode, ref wordDocument);
                ReplaceWordStub("{TypeDrive}", driveType, ref wordDocument);
                ReplaceWordStub("{PowDrive}", string.Format("{0:0.00}", drivePow), ref wordDocument);
                ReplaceWordStub("{SpeedDrive}", string.Format("{0}", driveSpeed), ref wordDocument);
                ReplaceWordStub("{PhaseDrive}", string.Format("{0}", drivePhase), ref wordDocument);
                ReplaceWordStub("{VoltDrive}", string.Format("{0}", driveVolt), ref wordDocument);
                ReplaceWordStub("{CurrDrive}", string.Format("{0}", driveCurr), ref wordDocument);
                ReplaceWordStub("{tempAir}", string.Format("{0:0.00}", ZtempAir), ref wordDocument);
                ReplaceWordStub("{temp}", string.Format("{0:0.00}", TempH2o02), ref wordDocument);
                ReplaceWordStub("{bp}", string.Format("{0:0.00}", bPress), ref wordDocument);
                ReplaceWordStub("{Zmd}", string.Format("{0:0.00}", dZm), ref wordDocument);
                ReplaceWordStub("{Zm1}", string.Format("{0:0.00}", Zm1), ref wordDocument);
                ReplaceWordStub("{Zm2}", string.Format("{0:0.00}", Zm2), ref wordDocument);
                procPers += 5;
                if (set01)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p1-" + i + "}", Point01[i] != 0f ? string.Format("{0:0.00}", Point01[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p1-" + i + "}", Point01[i] != 0f ? string.Format("{0:0}", Point01[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p1-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set02)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p2-" + i + "}", Point02[i] != 0f ? string.Format("{0:0.00}", Point02[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p2-" + i + "}", Point02[i] != 0f ? string.Format("{0:0}", Point02[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p2-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set03)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p3-" + i + "}", Point03[i] != 0f ? string.Format("{0:0.00}", Point03[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p3-" + i + "}", Point03[i] != 0f ? string.Format("{0:0}", Point03[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p3-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set04)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p4-" + i + "}", Point04[i] != 0f ? string.Format("{0:0.00}", Point04[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p4-" + i + "}", Point04[i] != 0f ? string.Format("{0:0}", Point04[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p4-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set05)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p5-" + i + "}", Point05[i] != 0f ? string.Format("{0:0.00}", Point05[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p5-" + i + "}", Point05[i] != 0f ? string.Format("{0:0}", Point05[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p5-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set06)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p6-" + i + "}", Point06[i] != 0f ? string.Format("{0:0.00}", Point06[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p6-" + i + "}", Point06[i] != 0f ? string.Format("{0:0}", Point06[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p6-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set07)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p7-" + i + "}", Point07[i] != 0f ? string.Format("{0:0.00}", Point07[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p7-" + i + "}", Point07[i] != 0f ? string.Format("{0:0}", Point07[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p7-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set08)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p8-" + i + "}", Point08[i] != 0f ? string.Format("{0:0.00}", Point08[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p8-" + i + "}", Point08[i] != 0f ? string.Format("{0:0}", Point08[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p8-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set09)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p9-" + i + "}", Point09[i] != 0f ? string.Format("{0:0.00}", Point09[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p9-" + i + "}", Point09[i] != 0f ? string.Format("{0:0}", Point09[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p9-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set10)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p10-" + i + "}", Point10[i] != 0f ? string.Format("{0:0.00}", Point10[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p10-" + i + "}", Point10[i] != 0f ? string.Format("{0:0}", Point10[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p10-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set11)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p11-" + i + "}", Point11[i] != 0f ? string.Format("{0:0.00}", Point11[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p11-" + i + "}", Point11[i] != 0f ? string.Format("{0:0}", Point11[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p11-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set12)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p12-" + i + "}", Point12[i] != 0f ? string.Format("{0:0.00}", Point12[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p12-" + i + "}", Point12[i] != 0f ? string.Format("{0:0}", Point12[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p12-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set13)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p13-" + i + "}", Point13[i] != 0f ? string.Format("{0:0.00}", Point13[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p13-" + i + "}", Point13[i] != 0f ? string.Format("{0:0}", Point13[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p13-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                if (set14)
                {
                    for (int i = 0; i < 33; i++)
                    {
                        if (i > 2)
                        {
                            ReplaceWordStub("{p14-" + i + "}", Point14[i] != 0f ? string.Format("{0:0.00}", Point14[i]) : "", ref wordDocument);
                        }
                        else
                        {
                            ReplaceWordStub("{p14-" + i + "}", Point14[i] != 0f ? string.Format("{0:0}", Point14[i]) : "", ref wordDocument);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 33; i++)
                    {
                        ReplaceWordStub("{p14-" + i + "}", "", ref wordDocument);
                    }
                }
                procPers += 5;
                wordDocument.SaveAs2((@"C:\Protocols\ProtNumb" + protNumb + ".pdf"), WdSaveFormat.wdFormatPDF);
                wordDocument.Close();
                wordApp.Visible = false;
                wordApp.Quit();
                procPers += 5;
                File.Delete(@"C:\Protocols\TemplayProtocol.docx");
                Process.Start(@"C:\Protocols\");

                procPers = 0f;
            });
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
