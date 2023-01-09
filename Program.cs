using System;
using System.Collections;
using System.Threading;
namespace MedApp.Medical_App


{
    class PathogenInfo
    {

        public string DiseaseName { get; set; }
        public string PatientName { get; set; }
        public string PathogenName { get; set; }
        public string Severity { get; set; }

        public string Symptoms { get; set; }


    }

    class Symptoms : PathogenInfo
    {
        private ArrayList Disease = new ArrayList();
        public bool AddDisease(PathogenInfo dss)
        {
            Disease.Add(dss);
            Console.WriteLine("Added Successfully...");
            return true;
        }
        public Array DisplayDis()
        {

            return Disease.ToArray();

        }
        public bool CheckSymptoms(string Sym)
        {
            for (int i = 0; i < Disease.Count; i++)
            {
                if (Disease[i] is PathogenInfo)
                {
                    var data = Disease[i] as PathogenInfo;
                    if (data.Symptoms == Sym)
                    {
                        Console.WriteLine("The patient suffers/ may suffers from {0}", data.DiseaseName);
                        return true;
                    }
                }
            }

            return false;
        }

    }

    class PatientInfo : Symptoms
    {
        public string PatName { get; set; }
        public string PatSym { get; set; }

        public ArrayList PatDet { get; set; }

        public void SetDet(PatientInfo pat)
        {
            PatDet.Add(pat);
        }



    }

    class Patient
    {
        static public void Run()
        {

            Console.WriteLine(" 1 for Add Disease for Diagnosis");
            Console.WriteLine(" 2 for Diagnosis");
        Dis:
            int choice = utilities.GetNumber("Options");
            switch (choice)
            {
                case 1:
                    HelperAdd();
                    break;
                default:
                    Console.WriteLine("Oops!! Invalid Option Try again");
                    goto Dis;
            }

        }

        static public void HelperAdd()
        {

            Symptoms spm = new Symptoms();
            void SeverityCheck(string SeverityBool)
            {
                if (SeverityBool.ToUpper() == "HIGHER" || SeverityBool.ToUpper() == "LOW" || SeverityBool.ToUpper() == "MEDIUM")
                {
                    Console.WriteLine("The Severity level checked");
                }
                else
                {
                    throw new Exception("Invalid");
                }
            }
        P:
            string DisName = utilities.Prompt("Pathogenic Name");

            string Severity = utilities.Prompt(" Severity level of Disease \n\n HIGH\n MEDIUM \n LOW");
            try
            {
                SeverityCheck(Severity);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto P;
            }
            string EnteredSymptoms = utilities.Prompt("Add Symptoms");


            PathogenInfo dis = new PathogenInfo();
            dis.DiseaseName = DisName;
            dis.Severity = Severity;
            dis.Symptoms = EnteredSymptoms;
            spm.AddDisease(dis);



            string ChoiceAdd = utilities.Prompt("Add Another disease");

            if (ChoiceAdd.ToUpper() == "YES")
            {
                goto P;
            }






            string PatName = utilities.Prompt("Patient Name");
            string PatSym = utilities.Prompt("Get To know about disease through symptoms");
            
            Console.WriteLine("");
            Thread.Sleep(16800);

            spm.CheckSymptoms(PatSpm);

            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("MedApp");
            Console.WriteLine("To Diagnose the disease we advice you to add Disease Name");

            Run();


        }


    }
}
