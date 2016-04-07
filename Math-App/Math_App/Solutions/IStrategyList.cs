using System;
using System.Collections.Generic;
using System.Text;
using Math_App.Solutions.StrategyChain;
using Math_App.Solutions.StrategyChain.Substraction;
using Math_App.Models.Strategies;

namespace Math_App.Solutions
{
    public interface IStrategyList
    {
        List<ICheckStrategy> getSolutions();
        void chainOrder();
    }

    // Strategies for Multiplication
    public class Multiply : IStrategyList
    {


        public Multiply(string a, string b)
        {

             
        }

        public List<ICheckStrategy> getSolutions()
        {
            List<ICheckStrategy> lijst = new List<ICheckStrategy>();



            return lijst;
        }

        public void chainOrder()
        {

        }
    }

    // Strategies for Dividing
    public class Devide : IStrategyList
    {
        ICheckStrategy strat1;
        ICheckStrategy strat2;

        public Devide()
        {
        }

        public List<ICheckStrategy> getSolutions()
        {
            List<ICheckStrategy> lijst = new List<ICheckStrategy>();

            return lijst;
        }

        public void chainOrder()
        {

        }
    }

    // Strategies for Minus
    public class Minus : IStrategyList
    {
        ICheckStrategy aftrekken_door_verschil_te_bepalen;
        ICheckStrategy komols_gewijs_aftrekken;
        ICheckStrategy rekenen_met_een_rond_getal;
        ICheckStrategy splitstrategie_substraction;

        public Minus(string a, string b)
        {
            aftrekken_door_verschil_te_bepalen = new Aftrekken_door_verschil_te_bepalen();
            komols_gewijs_aftrekken = new Komols_gewijs_aftrekken();
            rekenen_met_een_rond_getal = new Rekenen_met_een_rond_getal();
            splitstrategie_substraction = new Splitstrategie_substraction();
            chainOrder();
            aftrekken_door_verschil_te_bepalen.DoAnalyze(a, b);
        }

        public List<ICheckStrategy> getSolutions()
        {
            List<ICheckStrategy> lijst = new List<ICheckStrategy>();
            lijst.Add(aftrekken_door_verschil_te_bepalen.ReturnStrat());
            lijst.Add(komols_gewijs_aftrekken.ReturnStrat());
            lijst.Add(rekenen_met_een_rond_getal.ReturnStrat());
            lijst.Add(splitstrategie_substraction.ReturnStrat());


			lijst.RemoveAll(item => item == null);


			return lijst;
        }
        public void chainOrder()
        {
            aftrekken_door_verschil_te_bepalen.setNextChain(komols_gewijs_aftrekken);
            komols_gewijs_aftrekken.setNextChain(rekenen_met_een_rond_getal);
            rekenen_met_een_rond_getal.setNextChain(splitstrategie_substraction);

        }
    }

    // Strategies for Fractures
    public class Fracture : IStrategyList
    {
        ICheckStrategy strat1;
        ICheckStrategy strat2;

        public Fracture()
        {
        }

        public List<ICheckStrategy> getSolutions()
        {
            List<ICheckStrategy> lijst = new List<ICheckStrategy>();

            return lijst;
        }

        public void chainOrder()
        {

        }
    }

    // Strategies for Addition
    public class Addition : IStrategyList
    {
        ICheckStrategy analogie;
        ICheckStrategy optellen_kolomsgewijs;
        ICheckStrategy rekenen_met_mooie_getallen;
        ICheckStrategy rekenen_met_rond_getal;
        ICheckStrategy splitstrategie;

        public Addition(string a, string b)
        {
            analogie = new Analogie();
            optellen_kolomsgewijs = new Optellen_kolomsgewijs();
            rekenen_met_mooie_getallen = new Rekenen_met_mooie_getallen();
            rekenen_met_rond_getal = new Rekenen_met_rond_getal();
            splitstrategie = new Splitstrategie();
            chainOrder();
            analogie.DoAnalyze(a, b);
            //rekenen_met_mooie_getallen.DoAnalyze(a, b);   
        }

        public List<ICheckStrategy> getSolutions()
        {
            List<ICheckStrategy> lijst = new List<ICheckStrategy>();
            lijst.Add(analogie.ReturnStrat());
            lijst.Add(splitstrategie.ReturnStrat());
            lijst.Add(rekenen_met_rond_getal.ReturnStrat());
            lijst.Add(rekenen_met_mooie_getallen.ReturnStrat());
            lijst.Add(optellen_kolomsgewijs.ReturnStrat());

            lijst.RemoveAll(item => item == null);

            return lijst;
        }

        public void chainOrder()
        {
            analogie.setNextChain(optellen_kolomsgewijs);
            optellen_kolomsgewijs.setNextChain(rekenen_met_mooie_getallen);
            rekenen_met_mooie_getallen.setNextChain(rekenen_met_rond_getal);
            rekenen_met_rond_getal.setNextChain(splitstrategie);
        }
    }
}

