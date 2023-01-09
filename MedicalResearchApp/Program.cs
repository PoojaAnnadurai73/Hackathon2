using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearchApp
{
    class DiseaseCaused
    {
        public int PathogenName { get; set; }
        public string Severity { get; set; }
        public string Symptoms { get; set; }
        public string PatientName { get; set; }
        public void ShallowCopy(DiseaseCaused copy)
        {
            this.PathogenName = copy.PathogenName;
            this.Severity = copy.Severity;
            this.Symptoms = copy.Symptoms;
            this.PatientName = copy.PatientName;
        }

        public DiseaseCaused DeepCopy(DiseaseCaused copy)
        {
            DiseaseCaused disease = new DiseaseCaused();
            disease.ShallowCopy(copy);
            return disease;
        }
    }

    enum ExternalFactors { MOs, POD, CFood, ImpNou }
    class EnumExternalFactors
    {
       void EnumExternalFactors.Main(string[] args)
        {
            ExternalFactors EF = ExternalFactors.MOs;
            Console.WriteLine("The External factor that is responsible for this disease is" + EF);
            Console.WriteLine("The Other External Factors that are responsible for this disease is:");
            Array ResponsibleEF = Enum.GetValues(typeof(ExternalFactors));
            for (int e = 0; e < ResponsibleEF.Length; e++)
                Console.WriteLine(ResponsibleEF.GetValue(e));
            object inputvalue = Enum.Parse(typeof(ExternalFactors), Console.ReadLine(), true);
            ExternalFactors AccurateEF = (ExternalFactors)inputvalue;
            Console.WriteLine("The Disease Caused External Factor is" + AccurateEF);
        }
    }
    enum InternalFactors { GFs, CMFs, ImpCelldiv }
    class EnumInternalFactors
    {
        static void Main(string[] args)
        {
            {
                InternalFactors IF = InternalFactors.GFs;
                Console.WriteLine("The Internal Factors that is responsible for this disease is" + IF);
                Console.WriteLine("The Other Internal Factors that are responsible for this disease is:");
                Array ResponsibleIF = Enum.GetValues(typeof(InternalFactors));
                for (int i = 0; i < ResponsibleIF.Length; i++)
                    Console.WriteLine(ResponsibleIF.GetValue(i));
                object inputvalue = Enum.Parse(typeof(InternalFactors), Console.ReadLine(), true);
                InternalFactors AccurateIF = (InternalFactors)inputvalue;
                Console.WriteLine("The Disease Caused External Factor is" + AccurateIF);
            }
        }
    }
}
    
        

