using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;
using standControl.application.GUI.Model;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Controls;

namespace standControl.application.GUI.ViewModel
{
    class MainViewModel: INotifyPropertyChanged
    {
        Page viewMain;
        static public  MainModel mainModel;
        static Timer aTimer;
        static View.ProtocolWindow ProtocolWindows;
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

        private string valve;
        public string sValve
        {
            get { return valve; }
            set { if (valve != value) { valve = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string setStat01;
        public string sSetStat01
        {
            get { return setStat01; }
            set { if (setStat01 != value) { setStat01 = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string setStat02;
        public string sSetStat02
        {
            get { return setStat02; }
            set { if (setStat02 != value) { setStat02 = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string setStat03;
        public string sSetStat03
        {
            get { return setStat03; }
            set { if (setStat03 != value) { setStat03 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string setStat04;
        public string sSetStat04
        {
            get { return setStat04; }
            set { if (setStat04 != value) { setStat04 = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string setStat05;
        public string sSetStat05
        {
            get { return setStat05; }
            set { if (setStat05 != value) { setStat05 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string setStat06;
        public string sSetStat06
        {
            get { return setStat06; }
            set { if (setStat06 != value) { setStat06 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string setStat07;
        public string sSetStat07
        {
            get { return setStat07; }
            set { if (setStat07 != value) { setStat07 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string setStat08;
        public string sSetStat08
        {
            get { return setStat08; }
            set { if (setStat08 != value) { setStat08 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string setStat09;
        public string sSetStat09
        {
            get { return setStat09; }
            set { if (setStat09!= value) { setStat09 = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string setStat10;
        public string sSetStat10
        {
            get { return setStat10; }
            set { if (setStat10 != value) { setStat10 = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string setStat11;
        public string sSetStat11
        {
            get { return setStat11; }
            set { if (setStat11 != value) { setStat11 = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string setStat12;
        public string sSetStat12
        {
            get { return setStat12; }
            set { if (setStat12 != value) { setStat12 = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string setStat13;
        public string sSetStat13
        {
            get { return setStat13; }
            set { if (setStat13 != value) { setStat13 = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string setStat14;
        public string sSetStat14
        {
            get { return setStat14; }
            set { if (setStat14 != value) { setStat14 = value; OnPropertyChanged(); GC.Collect(); } }
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
        private string pm06;
        public string sPm06
        {
            get { return pm06; }
            set { if (pm06 != value) { pm06 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string pm07;
        public string sPm07
        {
            get { return pm07; }
            set { if (pm07 != value) { pm07 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string tm01;
        public string sTm01
        {
            get { return tm01; }
            set { if (tm01 != value) { tm01 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string tm02;
        public string sTm02
        {
            get { return tm02; }
            set { if (tm02 != value) { tm02 = value; OnPropertyChanged(); GC.Collect(); } }
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
        private string tm05;
        public string sTm05
        {
            get { return tm05; }
            set { if (tm05 != value) { tm05 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string tm06;
        public string sTm06
        {
            get { return tm06; }
            set { if (tm06 != value) { tm06 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string tm07;
        public string sTm07
        {
            get { return tm07; }
            set { if (tm07 != value) { tm07 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string tm08;
        public string sTm08
        {
            get { return tm08; }
            set { if (tm08 != value) { tm08 = value; OnPropertyChanged(); GC.Collect(); } }
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
            set { if (tm12 != value) { tm12= value; OnPropertyChanged(); GC.Collect(); } }
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
        private string speedTab;
        public string sSpeedTab
        {
            get { return speedTab; }
            set { if (speedTab != value) { speedTab = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string powA;
        public string sPowA
        {
            get { return powA; }
            set { if (powA != value) { powA = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string powB;
        public string sPowB
        {
            get { return powB; }
            set { if (powB != value) { powB = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string powC;
        public string sPowC
        {
            get { return powC; }
            set { if (powC != value) { powC = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string voltA;
        public string svoltA
        {
            get { return voltA; }
            set { if (voltA != value) { voltA = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string voltB;
        public string svoltB
        {
            get { return voltB; }
            set { if (voltB != value) { voltB = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string voltC;
        public string svoltC
        {
            get { return voltC; }
            set { if (voltC != value) { voltC = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string currA;
        public string sCurrA
        {
            get { return currA; }
            set { if (currA != value) { currA = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string currB;
        public string sCurrB
        {
            get { return currB; }
            set { if (currB != value) { currB = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string currC;
        public string sCurrC
        {
            get { return currC; }
            set { if (currC != value) { currC = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string vib1;
        public string sVib1
        {
            get { return vib1; }
            set { if (vib1 != value) { vib1 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string vib2;
        public string sVib2
        {
            get { return vib2; }
            set { if (vib2 != value) { vib2 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string vf1;
        public string sVf1
        {
            get { return vf1; }
            set { if (vf1 != value) { vf1 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string vf2;
        public string sVf2
        {
            get { return vf2; }
            set { if (vf2 != value) { vf2 = value; OnPropertyChanged(); GC.Collect(); } }
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
            set { if (r50 != value) { r50= value; OnPropertyChanged(); GC.Collect(); } }
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
        private float procPrs;
        public float sprocPrs
        {
            get { return procPrs; }
            set { if (procPrs != value) { procPrs = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string procVis;
        public string sprocVis
        {
            get { return procVis; }
            set { if (procVis != value) { procVis = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private Page _currentPage;
        private float proc;

        public Page CurrentPage
        {
            get { return _currentPage; }
            set
            {
                _currentPage = value;
                OnPropertyChanged("CurrentPage");
                GC.Collect();
            }
        }

        #endregion
        #region Button
        public ICommand IProtocol
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    ProtocolWindows = new View.ProtocolWindow();
                    ProtocolWindows.Show();
                });

            }

        }
        public ICommand IRun
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    mainModel.PunmpRun();
                   // sStatusRun = "True";
                   // sStatusStop= "False";
                });

            }

        }
        public ICommand IQ50
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun != "True")
                    {
                        mainModel.rashReg = 1;
                        
                    }
                });

            }

        }
        public ICommand IQ200
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun != "True")
                    {
                        mainModel.rashReg = 2;
                        
                    }
                });

            }

        }
        public ICommand IStop
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    mainModel.PunmpStop();
                   // sStatusRun = "False";
                   // sStatusStop = "True";
                });

            }

        }
        public ICommand IVpump
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun != "True")
                    {
                        mainModel.exspReg = 2;
                        
                    }
                });

            }

        }
        public ICommand IHpump
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun != "True")
                    {
                        mainModel.exspReg = 1;
                       
                    }
                });

            }

        }
        public ICommand Ivalue
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun != "True")
                    {
                        mainModel.exspReg = 3;
                       
                    }
                });
            }
        }
        public ICommand ISet01
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat01 != "True")
                    {
                        sSetStat01 = "True";
                        mainModel.SetPoint(1);
                    }
                });
            }
        }
        public ICommand ISet02
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat02 != "True")
                    {
                        sSetStat02 = "True";
                        mainModel.SetPoint(2);

                    }
                });
                 
            }
        }
        public ICommand ISet03
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat03 != "True")
                    {
                        sSetStat03 = "True";
                        mainModel.SetPoint(3);
                    }
                });
            }
        }
        public ICommand ISet04
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat04 != "True")
                    {
                        sSetStat04 = "True";
                        mainModel.SetPoint(4);
                    }
                });
            }
        }
        public ICommand ISet05
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat05 != "True")
                    {
                        sSetStat05 = "True";
                        mainModel.SetPoint(5);
                    }
                });
            }
        }
        public ICommand ISet06
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat06 != "True")
                    {
                        sSetStat06 = "True";
                        mainModel.SetPoint(6);
                    }
                });
            }
        }
        public ICommand ISet07
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat07 != "True")
                    {
                        sSetStat07 = "True";
                        mainModel.SetPoint(7);
                    }
                });
            }
        }
        public ICommand ISet08
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat08 != "True")
                    {
                        sSetStat08 = "True";
                        mainModel.SetPoint(8);
                    }
                });
            }
        }
        public ICommand ISet09
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat09 != "True")
                    {
                        sSetStat09 = "True";
                        mainModel.SetPoint(9);
                    }
                });
            }
        }
        public ICommand ISet10
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat10 != "True")
                    {
                        sSetStat10 = "True";
                        mainModel.SetPoint(10);
                    }
                });
            }
        }
        public ICommand ISet11
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat11 != "True")
                    {
                        sSetStat11 = "True";
                        mainModel.SetPoint(11);
                    }
                });
            }
        }
        public ICommand ISet12
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat12 != "True")
                    {
                        sSetStat12 = "True";
                        mainModel.SetPoint(12);
                    }
                });
            }
        }
        public ICommand ISet13
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat13 != "True")
                    {
                        sSetStat13 = "True";
                        mainModel.SetPoint(13);
                    }
                });
            }
        }
        public ICommand ISet14
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (statusRun == "True" && sSetStat14 != "True")
                    {
                        sSetStat14 = "True";
                        mainModel.SetPoint(14);
                    }
                });
            }
        }
        public ICommand IReset
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    sSetStat01 = "False";
                    sSetStat02 = "False";
                    sSetStat03 = "False";
                    sSetStat04 = "False";
                    sSetStat05 = "False";
                    sSetStat06 = "False";
                    sSetStat07 = "False";
                    sSetStat08 = "False";
                    sSetStat09 = "False";
                    sSetStat10 = "False";
                    sSetStat11 = "False";
                    sSetStat12 = "False";
                    sSetStat13 = "False";
                    sSetStat14 = "False";
                    mainModel.PointClear();
                });
            }
        }
        public ICommand IGetProtocol
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Console.WriteLine("Get protocol");
                    mainModel.CreateProtocol();
                });

            }

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
            sMbStat =GetString( MainModel.ModbusStatusOk);
            sBlStat = GetString(MainModel.BalkanStatusOk);
            if (MainModel.Pump01StatusOn==1)
            {
                sStatusRun = "True";
                sStatusStop = "False";
                
            }
            else
            {
                sStatusRun = "False";
                sStatusStop = "True";
            }

            if (mainModel.exspReg==1)
            {
                svPump = "False";
                shPump = "True";
                sValve = "False";
            }
          
            if (mainModel.exspReg == 2)
                {
                    svPump = "True";
                    shPump = "False";
                    sValve = "False";
                }
            if (mainModel.exspReg == 3)
            {
                    svPump = "False";
                    shPump = "False";
                    sValve = "True";
                }
            
            if (mainModel.rashReg==1)
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
            sWayQ50 = GetString( GetBoll(sQ50));
            sWayQ200 = GetString( GetBoll(sQ200));
            sWayP1 = GetString( GetBoll(shPump));
            sWayP2 = GetString(GetBoll(svPump));
            sWayV = GetString( GetBoll(sValve));
            sWayPV = GetString( (GetBoll(sValve) || GetBoll(shPump)));
            if (GetBoll(sStatusRun))
            {
                if (GetBoll(shPump))
                {
                    sPm01 = String.Format("{0:0.00}", 0);
                    sPm02 = String.Format("{0:0.00}", MainModel.Pressure01);
                    sPm03 = String.Format("{0:0.00}", MainModel.Pressure02);
                    sPm04 = String.Format("{0:0.00}", 0);
                    sPm05 = String.Format("{0:0.00}", 0);
                    sPm06 = String.Format("{0:0.00}", MainModel.Pressure01);
                    sPm07 = String.Format("{0:0.00}", MainModel.Pressure02);
                    sSpeed01 = String.Format("{0:0}", MainModel.speed);
                    sSpeed02 = String.Format("{0:0}", 0);
                    sSpeedTab = String.Format("{0:0}", MainModel.speed);
                    sTm01 = String.Format("{0:0.00}", MainModel.TempH2o01);
                    sTm02 = String.Format("{0:0.00}", 0);
                    sTm03 = String.Format("{0:0.00}", MainModel.TempPodsh201);
                    sTm04 = String.Format("{0:0.00}", 0);
                    sTm05 = String.Format("{0:0.00}", MainModel.TempH2o02);
                    sTm06 = String.Format("{0:0.00}", MainModel.TempPodsh201);
                    sTm07 = String.Format("{0:0.00}", MainModel.TempPodsh101);
                    sTm08 = String.Format("{0:0.00}", 0);
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
                    sPm06 = String.Format("{0:0.00}", 0);
                    sPm07 = String.Format("{0:0.00}", MainModel.Pressure02);
                    sSpeed01 = String.Format("{0:0}", 0);
                    sSpeed02 = String.Format("{0:0}", MainModel.speed);
                    sSpeedTab = String.Format("{0:0}",MainModel.speed);
                    sTm01 = String.Format("{0:0.00}", 0);
                    sTm02 = String.Format("{0:0.00}", 0);
                    sTm03 = String.Format("{0:0.00}", 0);
                    sTm04 = String.Format("{0:0.00}", MainModel.TempPodsh202);
                    sTm05 = String.Format("{0:0.00}", MainModel.TempH2o02);
                    sTm06 = String.Format("{0:0.00}", MainModel.TempPodsh202);
                    sTm07 = String.Format("{0:0.00}", MainModel.TempPodsh102);
                    sTm08 = String.Format("{0:0.00}", MainModel.TempPodsh102);
                    sTm09 = String.Format("{0:0.00}",0);
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
                    sPm06 = String.Format("{0:0.00}", MainModel.Pressure01);
                    sPm07 = String.Format("{0:0.00}", MainModel.Pressure02);
                    sSpeed01 = String.Format("{0:0}", MainModel.speed);
                    sSpeed02 = String.Format("{0:0}", 0);
                    sSpeedTab = String.Format("{0:0}", MainModel.speed);
                    sTm01 = String.Format("{0:0.00}", MainModel.TempH2o01);
                    sTm02 = String.Format("{0:0.00}", MainModel.TempH2o02);
                    sTm03 = String.Format("{0:0.00}", MainModel.TempPodsh201);
                    sTm04 = String.Format("{0:0.00}", 0);
                    sTm05 = String.Format("{0:0.00}", MainModel.TempH2o02);
                    sTm06 = String.Format("{0:0.00}", MainModel.TempPodsh201);
                    sTm07 = String.Format("{0:0.00}", MainModel.TempPodsh101);
                    sTm08 = String.Format("{0:0.00}", 0);
                    sTm09 = String.Format("{0:0.00}", MainModel.TempPodsh101);
                    sTm10 = String.Format("{0:0.00}", 0);
                    sTm11 = String.Format("{0:0.00}", MainModel.TempH2o02);
                    sTm12 = String.Format("{0:0.00}", 0);

                }
                if (GetBoll(sQ200))
                {
                    sR200= String.Format("{0:0.00}", MainModel.Rate01);
                    sR50 = String.Format("{0:0.00}", 0);
                    sRtab= String.Format("{0:0.00}", MainModel.Rate01);
                }
                if (GetBoll(sQ50))
                {
                    sR200 = String.Format("{0:0.00}", 0);
                    sR50 = String.Format("{0:0.00}", MainModel.Rate02);
                    sRtab = String.Format("{0:0.00}", MainModel.Rate02);
                }
                sPowB = String.Format("{0:0.00}", MainModel.Power_B);
                sPowA = String.Format("{0:0.00}", MainModel.Power_A);
                sPowC = String.Format("{0:0.00}", MainModel.Power_C);
                sCurrB = String.Format("{0:0.00}",MainModel.Current_B);
                sCurrA = String.Format("{0:0.00}",MainModel.Current_A);
                sCurrC = String.Format("{0:0.00}", MainModel.Current_C);
                svoltB = String.Format("{0:0.00}", MainModel.Voltage_B);
                svoltA= String.Format("{0:0.00}", MainModel.Voltage_A);
                svoltC = String.Format("{0:0.00}", MainModel.Voltage_C);
                sVib1 = String.Format("{0:0.00}", MainModel.vibroOne);
                sVib2 = String.Format("{0:0.00}", MainModel.vibroTwo);
                sVf1= String.Format("{0:0.00}", MainModel.phaseOne);
                sVf2 = String.Format("{0:0.00}", MainModel.phaseTwo);
            }
            else
            {
                sPm01 = String.Format("{0:0.00}", 0);
                sPm02 = String.Format("{0:0.00}", 0);
                sPm03 = String.Format("{0:0.00}", 0);
                sPm04 = String.Format("{0:0.00}", 0);
                sPm05 = String.Format("{0:0.00}", 0);
                sPm06 = String.Format("{0:0.00}", 0);
                sPm07 = String.Format("{0:0.00}", 0);
                sSpeed01 = String.Format("{0:0}", 0);
                sSpeed02 = String.Format("{0:0}", 0);
                sSpeedTab = String.Format("{0:0}", 0);
                sPowA = String.Format("{0:0.00}", 0);
                sPowB = String.Format("{0:0.00}", 0);
                sPowC = String.Format("{0:0.00}", 0);
                sCurrA = String.Format("{0:0.00}", 0);
                sCurrB = String.Format("{0:0.00}", 0);
                sCurrC = String.Format("{0:0.00}", 0);
                svoltA = String.Format("{0:0.00}", 0);
                svoltB = String.Format("{0:0.00}", 0);
                svoltC = String.Format("{0:0.00}", 0);
                svoltB = String.Format("{0:0.00}", 0);
                svoltC = String.Format("{0:0.00}", 0);
                sVib1 = String.Format("{0:0.00}", 0);
                sVib2 = String.Format("{0:0.00}", 0);
                sVf1 = String.Format("{0:0.00}", 0);
                sVf2 = String.Format("{0:0.00}",0);
                sR200 = String.Format("{0:0.00}", 0);
                sR50 = String.Format("{0:0.00}", 0);
                sRtab = String.Format("{0:0.00}", 0);
                sTm01 = String.Format("{0:0.00}", 0);
                sTm02 = String.Format("{0:0.00}", 0);
                sTm03 = String.Format("{0:0.00}", 0);
                sTm04 = String.Format("{0:0.00}", 0);
                sTm05 = String.Format("{0:0.00}", 0);
                sTm06 = String.Format("{0:0.00}", 0);
                sTm07 = String.Format("{0:0.00}", 0);
                sTm08 = String.Format("{0:0.00}", 0);
                sTm09 = String.Format("{0:0.00}", 0);
                sTm10 = String.Format("{0:0.00}", 0);
                sTm11 = String.Format("{0:0.00}", 0);
                sTm12 = String.Format("{0:0.00}", 0);
            }
            if  (Convert.ToDouble(sTm03)<0 || Convert.ToDouble(sTm03) > 200)
            {
                sTm03 = "Error";
            }
            if (Convert.ToDouble(sTm04) < 0 || Convert.ToDouble(sTm04) > 200)
            {
                sTm04 = "Error";
            }
            if (Convert.ToDouble(sTm06) < 0 || Convert.ToDouble(sTm06) > 200)
            {
                sTm06 = "Error";
            }
            if (Convert.ToDouble(sTm07) < 0 || Convert.ToDouble(sTm07) > 200)
            {
                sTm07 = "Error";
            }
            if (Convert.ToDouble(sTm09) < 0 || Convert.ToDouble(sTm09) > 200)
            {
                sTm09 = "Error";
            }
        }
        public MainViewModel()
        {
            
            Deserial();
            sprocVis = "Hidden";
            sQ50 = "True";
            shPump = "True";
            aTimer = new Timer();
            aTimer.Interval = 1000;
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;
            // Start the timer
            aTimer.Enabled = true;
            viewMain = new View.Mnemoshema();
            CurrentPage = viewMain;



        }
        void Deserial()
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(MainModel));
                using (FileStream fs = new FileStream("mainModels.xml", FileMode.OpenOrCreate))
                {
                     mainModel = (MainModel)formatter.Deserialize(fs) as MainModel;

                    Console.WriteLine("Объект десериализован");

                }
            }
            catch {
                mainModel = new MainModel();
            }
        }
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
          
            sprocPrs = MainModel.procPers;
            if(MainModel.procPers>0f && MainModel.procPers < 100f) 
            {
                sprocVis = "Visible";
            }
            else
            {
                sprocVis = "Hidden";
             
            }
            Visual();
        }
       
    }
}
