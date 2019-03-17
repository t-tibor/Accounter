using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Accounter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //UnitTests.WorkspaceTest();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }



    static class UnitTests
    {
        public static void WorkspaceTest()
        {
            List<Accounter.Transaction> tr;
            Accounter.AccounterWorkspace workspace = workspace = new AccounterWorkspace();


            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/kiadás/egyedi", filter_isIncome: false));
            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/bevétel", filter_isIncome: true));
            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/bevétel/munkabér", filter_isIncome: true, filter_partnerName: "Robert Bosch kft"));

            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/kiadás/rendszeres/élelmiszer/spar", filter_partnerName: "SPAR"));
            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/kiadás/rendszeres/élelmiszer/lidl",filter_partnerName: "LIDL"));
            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/kiadás/rendszeres/élelmiszer/bosch", filter_partnerName: "bosch", filter_type: "Vásárlás belföldi kereskedőnél"));
            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/kiadás/rendszeres/élelmiszer/egyéb", filter_partnerName: "OSMANI DO NER KEBAB"));
            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/kiadás/rendszeres/utazás/mav", filter_partnerName: "MAV"));
            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/kiadás/rendszeres/utazás/bkk", filter_partnerName: "bkk"));
            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/kiadás/rendszeres/lakás/rezsi/gáz", filter_partnerName: "FOLDGAZSZOLG"));
            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/kiadás/rendszeres/lakás/rezsi/közös_költség_víz", filter_partnerName: @"társasház"));
            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/kiadás/rendszeres/lakás/rezsi/villany", filter_partnerName: "ELMUEMASZENERGIASZOLGA"));
            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/kiadás/rendszeres/lakás/hitel", filter_type: "Hitel törlesztés"));
            workspace.DataBase.AddDetector(new CategoryDetector(targetCategory: "/kiadás/rendszeres/lakás/hitel", filter_type: "Hitelkamat törlesztés"));

            




            tr = workspace.InportBankReport(@"H:\Letöltések\szamlatortenet_20190101_20190316.csv");
            workspace.AssignCategory(tr);
            workspace.DataBase.AddTransactions(tr);

            workspace.GetFullCategoryReportTree(2019, 1);

            workspace.SaveWorkspace("./my_export.xml");
        }
    }
}
