using standControl.application.GUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace standControl.application.GUI.ViewModel
{
    class MnemoshemViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #region Tags
        private string statusRun;
        public string sStatusRun
        {
            get { return statusRun; }
            set { if (statusRun != value) { statusRun = value; OnPropertyChanged(); GC.Collect(); } }

        }

        private string statusStop;
        public string sStatusStop
        {
            get { return statusStop; }
            set { if (statusStop != value) { statusStop = value; OnPropertyChanged(); GC.Collect(); } }

        }

        private string Q50;
        public string sQ50
        {
            get { return Q50; }
            set { if (Q50 != value) { Q50 = value; OnPropertyChanged(); GC.Collect(); } }

        }
        private string Q200;
        public string sQ200
        {
            get { return Q200; }
            set { if (Q200 != value) { Q200 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string vPump;
        public string svPump
        {
            get { return vPump; }
            set { if (vPump != value) { vPump = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string hPump;
        public string shPump
        {
            get { return hPump; }
            set { if (hPump != value) { hPump = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private Timer aTimer;
       
        private string valve;
        public string sValve
        {
            get { return valve; }
            set { if (valve != value) { valve = value; OnPropertyChanged(); GC.Collect(); } }
        }
       

        


        private string wayP1;
        public string sWayP1
        {
            get { return wayP1; }
            set { if (wayP1 != value) { wayP1 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string wayP2;
        public string sWayP2
        {
            get { return wayP2; }
            set { if (wayP2 != value) { wayP2 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string wayV;
        public string sWayV
        {
            get { return wayV; }
            set { if (wayV != value) { wayV = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string wayPV;
        public string sWayPV
        {
            get { return wayPV; }
            set { if (wayPV != value) { wayPV = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string wayQ50;
        public string sWayQ50
        {
            get { return wayQ50; }
            set { if (wayQ50 != value) { wayQ50 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string wayQ200;
        public string sWayQ200
        {
            get { return wayQ200; }
            set { if (wayQ200 != value) { wayQ200 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string wayOn;
        public string sWayOn
        {
            get { return wayOn; }
            set { if (wayOn != value) { wayOn = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string pm01;
        public string sPm01
        {
            get { return pm01; }
            set { if (pm01 != value) { pm01 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string pm02;
        public string sPm02
        {
            get { return pm02; }
            set { if (pm02 != value) { pm02 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string pm03;
        public string sPm03
        {
            get { return pm03; }
            set { if (pm03 != value) { pm03 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string pm04;
        public string sPm04
        {
            get { return pm04; }
            set { if (pm04 != value) { pm04 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string pm05;
        public string sPm05
        {
            get { return pm05; }
            set { if (pm05 != value) { pm05 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        
        private string tm01;
        public string sTm01
        {
            get { return tm01; }
            set { if (tm01 != value) { tm01 = value; OnPropertyChanged(); GC.Collect(); } }
        }
      
        private string tm03;
        public string sTm03
        {
            get { return tm03; }
            set { if (tm03 != value) { tm03 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string tm04;
        public string sTm04
        {
            get { return tm04; }
            set { if (tm04 != value) { tm04 = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string tm09;
        public string sTm09
        {
            get { return tm09; }
            set { if (tm09 != value) { tm09 = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string tm10;
        public string sTm10
        {
            get { return tm10; }
            set { if (tm10 != value) { tm10 = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string tm11;
        public string sTm11
        {
            get { return tm11; }
            set { if (tm11 != value) { tm11 = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string tm12;
        public string sTm12
        {
            get { return tm12; }
            set { if (tm12 != value) { tm12 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string speed01;
        public string sSpeed01
        {
            get { return speed01; }
            set { if (speed01 != value) { speed01 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string speed02;
        public string sSpeed02
        {
            get { return speed02; }
            set { if (speed02 != value) { speed02 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string r200;
        public string sR200
        {
            get { return r200; }
            set { if (r200 != value) { r200 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string r50;
        public string sR50
        {
            get { return r50; }
            set { if (r50 != value) { r50 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string rTab;
        public string sRtab
        {
            get { return rTab; }
            set { if (rTab != value) { rTab = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string mbStat;
        public string sMbStat
        {
            get { return mbStat; }
            set { if (mbStat != value) { mbStat = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string blStat;
        public string sBlStat
        {
            get { return blStat; }
            set { if (blStat != value) { blStat = value; OnPropertyChanged(); GC.Collect(); } }
        }



        #endregion
        #region Support func
        bool GetBoll(string input)
        {
            if (input == "True")
                return true;
            else return false;
        }
        string GetString(bool input)
        {
            if (input)
                return "True";
            else return "False";
        }
        #endregion
        void Visual()
        {
            sMbStat = GetString(MainModel.ModbusStatusOk);
            sBlStat = GetString(MainModel.BalkanStatusOk);
            if (MainModel.Pump01StatusOn == 1)
            {
                sStatusRun = "True";
                sStatusStop = "False";

            }
            else
            {
                sStatusRun = "False";
                sStatusStop = "True";
            }

            if (MainViewModel.mainModel.exspReg == 1)
            {
                svPump = "False";
                shPump = "True";
                sValve = "False";
            }

            if (MainViewModel.mainModel.exspReg == 2)
            {
                svPump = "True";
                shPump = "False";
                sValve = "False";
            }
            if (MainViewModel.mainModel.exspReg == 3)
            {
                svPump = "False";
                shPump = "False";
                sValve = "True";
            }

            if (MainViewModel.mainModel.rashReg == 1)
            {
                sQ50 = "True";
                sQ200 = "False";
            }
            else
            {
                sQ200 = "True";
                sQ50 = "False";
            }
            //String.Format("{0:0.00}", );
            sWayOn = "True";
            sWayQ50 = GetString(GetBoll(sQ50));
            sWayQ200 = GetString(GetBoll(sQ200));
            sWayP1 = GetString(GetBoll(shPump));
            sWayP2 = GetString(GetBoll(svPump));
            sWayV = GetString(GetBoll(sValve));
            sWayPV = GetString((GetBoll(sValve) || GetBoll(shPump)));
            if (GetBoll(sStatusRun))
            {
                if (GetBoll(shPump))
                {
                    sPm01 = String.Format("{0:0.00}", 0);
                    sPm02 = String.Format("{0:0.00}", MainModel.Pressure01);
                    sPm03 = String.Format("{0:0.00}", MainModel.Pressure02);
                    sPm04 = String.Format("{0:0.00}", 0);
                    sPm05 = String.Format("{0:0.00}", 0);
                   
                    sSpeed01 = String.Format("{0:0}", MainModel.speed);
                    sSpeed02 = String.Format("{0:0}", 0);
                   
                    sTm01 = String.Format("{0:0.00}", MainModel.TempH2o01);
                    sTm03 = String.Format("{0:0.00}", MainModel.TempPodsh201);
                    sTm04 = String.Format("{0:0.00}", 0);
                    sTm09 = String.Format("{0:0.00}", MainModel.TempPodsh101);
                    sTm10 = String.Format("{0:0.00}", MainModel.TempH2o02);
                    sTm11 = String.Format("{0:0.00}", 0);
                    sTm12 = String.Format("{0:0.00}", 0);
                }
                if (GetBoll(svPump))
                {
                    sPm01 = String.Format("{0:0.00}", MainModel.Pressure02);
                    sPm02 = String.Format("{0:0.00}", 0);
                    sPm03 = String.Format("{0:0.00}", 0);
                    sPm04 = String.Format("{0:0.00}", 0);
                    sPm05 = String.Format("{0:0.00}", 0);
                    sSpeed01 = String.Format("{0:0}", 0);
                    sSpeed02 = String.Format("{0:0}", MainModel.speed); 
                    sTm01 = String.Format("{0:0.00}", 0);
                    sTm03 = String.Format("{0:0.00}", 0);
                    sTm04 = String.Format("{0:0.00}", MainModel.TempPodsh202);
                    sTm09 = String.Format("{0:0.00}", 0);
                    sTm10 = String.Format("{0:0.00}", 0);
                    sTm11 = String.Format("{0:0.00}", 0);
                    sTm12 = String.Format("{0:0.00}", MainModel.TempH2o01);


                }
                if (GetBoll(sValve))
                {
                    sPm01 = String.Format("{0:0.00}", 0);
                    sPm02 = String.Format("{0:0.00}", 0);
                    sPm03 = String.Format("{0:0.00}", 0);
                    sPm04 = String.Format("{0:0.00}", MainModel.Pressure01);
                    sPm05 = String.Format("{0:0.00}", MainModel.Pressure02);
                    sSpeed01 = String.Format("{0:0}", MainModel.speed);
                    sSpeed02 = String.Format("{0:0}", 0);                  
                    sTm01 = String.Format("{0:0.00}", MainModel.TempH2o01);              
                    sTm03 = String.Format("{0:0.00}", MainModel.TempPodsh201);
                    sTm04 = String.Format("{0:0.00}", 0);
                    sTm09 = String.Format("{0:0.00}", MainModel.TempPodsh101);
                    sTm10 = String.Format("{0:0.00}", 0);
                    sTm11 = String.Format("{0:0.00}", MainModel.TempH2o02);
                    sTm12 = String.Format("{0:0.00}", 0);


                }
                if (GetBoll(sQ200))
                {
                    sR200 = String.Format("{0:0.00}",  MainModel.Rate01/3600F);
                    sR50 = String.Format("{0:0.00}", 0);
                    sRtab = String.Format("{0:0.00}", MainModel.Rate01/3600F);
                }
                if (GetBoll(sQ50))
                {
                    sR200 = String.Format("{0:0.00}", 0);
                    sR50 = String.Format("{0:0.00}", MainModel.Rate02 / 3600F);
                    sRtab = String.Format("{0:0.00}", MainModel.Rate02 / 3600F);
                }
               
            }
            else
            {
                sPm01 = String.Format("{0:0.00}", 0);
                sPm02 = String.Format("{0:0.00}", 0);
                sPm03 = String.Format("{0:0.00}", 0);
                sPm04 = String.Format("{0:0.00}", 0);
                sPm05 = String.Format("{0:0.00}", 0);
              
                sSpeed01 = String.Format("{0:0}", 0);
                sSpeed02 = String.Format("{0:0}", 0);
              
                sR200 = String.Format("{0:0.00}", 0);
                sR50 = String.Format("{0:0.00}", 0);
                sRtab = String.Format("{0:0.00}", 0);
                sTm01 = String.Format("{0:0.00}", 0);
              
                sTm03 = String.Format("{0:0.00}", 0);
                sTm04 = String.Format("{0:0.00}", 0);
                sTm09 = String.Format("{0:0.00}", 0);
                sTm10 = String.Format("{0:0.00}", 0);
                sTm11 = String.Format("{0:0.00}", 0);
                sTm12 = String.Format("{0:0.00}", 0);

            }
            if (Convert.ToDouble(sTm03) < 0 || Convert.ToDouble(sTm03) > 200)
            {
                sTm03 = "Error";
            }
            
            if (Convert.ToDouble(sTm09) < 0 || Convert.ToDouble(sTm09) > 200)
            {
                sTm09 = "Error";
            }
            
        }
        public MnemoshemViewModel()
        {
            sQ50 = "True";
            shPump = "True";
            aTimer = new Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;
            // Start the timer
            aTimer.Enabled = true;
        }
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Visual();
        }
    }
}
