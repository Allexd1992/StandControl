using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;

namespace standControl.application.GUI.ViewModel
{
    class ProtocolViewModel: INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
            
        }
        #region TagsList
        private string prodName;
        public string sProdName
        {
            get { return prodName; }
            set { if (prodName != value) { prodName = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string modeName;
        public string sModeName
        {
            get { return modeName; }
            set { if (modeName != value) { modeName = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string modeTime;
        public string sModeTime
        {
            get { return modeTime; }
            set { if (modeTime != value) { modeTime = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string expPlace;
        public string sExpPlace
        {
            get { return expPlace; }
            set { if (expPlace != value) { expPlace = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string expType;
        public string sExpType
        {
            get { return expType; }
            set { if (expType != value) { expType = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string expClass;
        public string sExpClass
        {
            get { return expClass; }
            set { if (expClass != value) { expClass = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string expDate;
        public string sExpDate
        {
            get { return expDate; }
            set { if (expDate != value) { expDate = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string protMunb;
        public string sProtMunb
        {
            get { return protMunb; }
            set { if (protMunb != value) { protMunb = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string prot;
        public string sProt
        {
            get { return prot; }
            set { if (prot != value) { prot = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string client;
        public string sClient
        {
            get { return client; }
            set { if (client != value) { client = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string pump;
        public string sPump
        {
            get { return pump; }
            set { if (pump != value) { pump = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string pumpNumb;
        public string sPumpNumb
        {
            get { return pumpNumb; }
            set { if (pumpNumb != value) { pumpNumb = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string orderNumb;
        public string sOrderNumb
        {
            get { return orderNumb; }
            set { if (orderNumb != value) { orderNumb = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string orderNum;
        public string sOrderNum
        {
            get { return orderNum; }
            set { if (orderNum != value) { orderNum = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string pumpMode;
        public string sPumpMode
        {
            get { return pumpMode; }
            set { if (pumpMode != value) { pumpMode = value; OnPropertyChanged(); GC.Collect(); } }
        }

        private string d2Out;
        public string sD2Out
        {
            get { return d2Out; }
            set { if (d2Out != value) { d2Out = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string d1In;
        public string sD1in
        {
            get { return d1In; }
            set { if (d1In != value) { d1In = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string dWork;
        public string sDWork
        {
            get { return dWork; }
            set { if (dWork != value) { dWork = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string Zm1;
        public string sZm1
        {
            get { return Zm1; }
            set { if (Zm1 != value) { Zm1 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string Zm2;
        public string sZm2
        {
            get { return Zm2; }
            set { if (Zm2 != value) { Zm2 = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string tempAir;
        public string sTempAir
        {
            get { return tempAir; }
            set { if (tempAir != value) { tempAir = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string bPress;
        public string sbPress
        {
            get { return bPress; }
            set { if (bPress != value) { bPress = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string driveMode;
        public string sDriveMode
        {
            get { return driveMode; }
            set { if (driveMode != value) { driveMode = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string drivePhase;
        public string sDrivePhase
        {
            get { return drivePhase; }
            set { if (drivePhase != value) { drivePhase = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string drivePow;
        public string sDrivePow
        {
            get { return drivePow; }
            set { if (drivePow != value) { drivePow = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string driveCurr;
        public string sDriveCurr
        {
            get { return driveCurr; }
            set { if (driveCurr != value) { driveCurr = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string driveSpeed;
        public string sDriveSpeed
        {
            get { return driveSpeed; }
            set { if (driveSpeed != value) { driveSpeed = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string driveVolt;
        public string sDriveVolt
        {
            get { return driveVolt; }
            set { if (driveVolt != value) { driveVolt = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string driveType;
        public string sDriveType
        {
            get { return driveType; }
            set { if (driveType != value) { driveType = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string qNom;
        public string sQNom
        {
            get { return qNom; }
            set { if (qNom != value) { qNom = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string hNom;
        public string sHNom
        {
            get { return hNom; }
            set { if (hNom != value) { hNom = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string speedNom;
        public string sSpedNom
        {
            get { return speedNom; }
            set { if (speedNom != value) { speedNom = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string KPDNom;
        public string sKPDNom
        {
            get { return KPDNom; }
            set { if (KPDNom != value) { KPDNom = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string powNom;
        public string sPowNom
        {
            get { return powNom; }
            set { if (powNom != value) { powNom = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string pSmog;
        public string spSmog
        {
            get { return pSmog; }
            set { if (pSmog != value) { pSmog = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string pH;
        public string spH
        {
            get { return pH; }
            set { if (pH != value) { pH = value; OnPropertyChanged(); GC.Collect(); } }
        }
        private string kVz;
        public string skVz
        {
            get { return kVz; }
            set { if (kVz != value) { kVz = value; OnPropertyChanged(); GC.Collect(); } }
        }
        #endregion
        #region Button
        public ICommand ISave
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    WriteVar();
                    Serialz();
                });

            }

        }
        #endregion
        private void ReadVar()
        {
            try
            {
                Console.WriteLine(MainViewModel.mainModel.prodName);
                sProdName = MainViewModel.mainModel.prodName;
                sModeName = MainViewModel.mainModel.modName;
                sModeTime = MainViewModel.mainModel.modTime;
                sExpPlace = MainViewModel.mainModel.expPlace;
                sExpType = MainViewModel.mainModel.expType;
                sExpClass = MainViewModel.mainModel.expClass;
                sExpDate = MainViewModel.mainModel.expDate;
                sProtMunb = MainViewModel.mainModel.protNumb;
                sProt = MainViewModel.mainModel.prot;
                sClient = MainViewModel.mainModel.client;
                sPump = MainViewModel.mainModel.pump;
                sPumpNumb = MainViewModel.mainModel.pumpNumb;
                sPumpMode = MainViewModel.mainModel.pumpMode;
                sOrderNum = MainViewModel.mainModel.orderNum;
                sOrderNumb = MainViewModel.mainModel.orderNumb;
                sD1in = String.Format("{0:0.00}", MainViewModel.mainModel.d1In);
                sSpedNom = string.Format("{0}", MainViewModel.mainModel.speedNom);
                sD2Out = string.Format("{0:0.00}", MainViewModel.mainModel.d2Out);
                sDWork = string.Format("{0:0.00}", MainViewModel.mainModel.dWork);
                sZm1 = string.Format("{0:0.00}", MainViewModel.mainModel.Zm1);
                sZm2 = string.Format("{0:0.00}", MainViewModel.mainModel.Zm2);
                sTempAir = string.Format("{0:0.00}", MainViewModel.mainModel.ZtempAir);
                sbPress = string.Format("{0:0.00}", MainViewModel.mainModel.bPress);
                sDriveMode = MainViewModel.mainModel.driveMode;
                sDrivePhase = string.Format("{0}", MainViewModel.mainModel.drivePhase);
                sDrivePow = string.Format("{0:0.00}", MainViewModel.mainModel.drivePow);
                sDriveCurr = string.Format("{0:0.00}", MainViewModel.mainModel.driveCurr);
                sDriveSpeed = string.Format("{0}", MainViewModel.mainModel.driveSpeed);
                sDriveVolt = string.Format("{0:0.00}", MainViewModel.mainModel.driveVolt);
                sDriveType = MainViewModel.mainModel.driveType;
                sQNom = string.Format("{0:0.00}", MainViewModel.mainModel.qNom);
                sHNom = string.Format("{0:0.00}", MainViewModel.mainModel.hNom);
                sKPDNom = string.Format("{0:0.00}", MainViewModel.mainModel.KPDNom);
                sQNom = string.Format("{0:0.00}", MainViewModel.mainModel.qNom);
                sPowNom = string.Format("{0:0.00}", MainViewModel.mainModel.powNom);
                spSmog = string.Format("{0:0.00}", MainViewModel.mainModel.Ksmog);
                skVz = string.Format("{0:0.00}", MainViewModel.mainModel.kVz);
                spH = string.Format("{0:0.00}", MainViewModel.mainModel.pH);
            }
            catch { }
        }
        private void WriteVar()
        {
            MainViewModel.mainModel.prodName=sProdName;
            MainViewModel.mainModel.modName=sModeName;
            MainViewModel.mainModel.modTime=sModeTime;
            
            MainViewModel.mainModel.expPlace=sExpPlace;
            MainViewModel.mainModel.expType=sExpType;
            MainViewModel.mainModel.expClass=sExpClass;
            MainViewModel.mainModel.expDate=sExpDate;
            MainViewModel.mainModel.protNumb= sProtMunb ;
            MainViewModel.mainModel.prot= sProt ;
            MainViewModel.mainModel.client = sClient ;
            MainViewModel.mainModel.pump = sPump;
            MainViewModel.mainModel.pumpNumb = sPumpNumb ;
            MainViewModel.mainModel.pumpMode = sPumpMode ;
            MainViewModel.mainModel.orderNum = sOrderNum ;
            MainViewModel.mainModel.orderNumb = sOrderNumb ;
            MainViewModel.mainModel.driveMode = sDriveMode;
            MainViewModel.mainModel.speedNom = double.Parse(sSpedNom);
            MainViewModel.mainModel.d1In = double.Parse(sD1in);
            MainViewModel.mainModel.d2Out = double.Parse(sD2Out);
            MainViewModel.mainModel.dWork= double.Parse(sDWork);
            MainViewModel.mainModel.Zm1= double.Parse(sZm1);
            MainViewModel.mainModel.Zm2= double.Parse(sZm2);
            MainViewModel.mainModel.ZtempAir = double.Parse(sTempAir);
            MainViewModel.mainModel.bPress = double.Parse(sbPress);
            MainViewModel.mainModel.drivePhase = double.Parse(sDrivePhase);
            MainViewModel.mainModel.drivePow = double.Parse(sDrivePow);
            MainViewModel.mainModel.driveCurr = double.Parse(sDriveCurr);
            MainViewModel.mainModel.driveSpeed = double.Parse(sDriveSpeed);
            MainViewModel.mainModel.driveVolt = double.Parse(sDriveVolt);
            MainViewModel.mainModel.qNom = double.Parse(sQNom);
            MainViewModel.mainModel.hNom = double.Parse(sHNom);
            MainViewModel.mainModel.KPDNom = double.Parse(sKPDNom);
            MainViewModel.mainModel.qNom = double.Parse(sQNom);
            MainViewModel.mainModel.powNom = double.Parse(sPowNom);
            MainViewModel.mainModel.Ksmog = double.Parse(spSmog);
            MainViewModel.mainModel.kVz = double.Parse(skVz);
            MainViewModel.mainModel.pH = double.Parse(spH);
            MainViewModel.mainModel.driveType= sDriveType;
           
        }
        public ProtocolViewModel()
        {
            try { ReadVar(); }
            catch { }
        }
        public void Serialz()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Model.MainModel));

            // получаем поток, куда будем записывать сериализованный объект
            File.Delete("mainModels.xml");
            using (FileStream fs = new FileStream("mainModels.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs,MainViewModel.mainModel);

                Console.WriteLine("Объект сериализован");
            }
        }
    }
}
