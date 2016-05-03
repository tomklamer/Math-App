using System;
using System.Collections.Generic;
using System.Text;
using Math_App.Solutions.StrategyChain;
using Math_App.Solutions.StrategyChain.Substraction;

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
        StrategiesToDisplay data = new StrategiesToDisplay();

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
        StrategiesToDisplay data = new StrategiesToDisplay();

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
        StrategiesToDisplay data = new StrategiesToDisplay();

        ICheckStrategy aftrekken_door_verschil_te_bepalen;
        ICheckStrategy komols_gewijs_aftrekken;
        ICheckStrategy rekenen_met_een_rond_getal;
        ICheckStrategy splitstrategie_substraction;
        ICheckStrategy aftrekken_analogie;
        ICheckStrategy Aftrekken_met_reigen;

        public Minus(string a, string b)
        {
            aftrekken_door_verschil_te_bepalen = new Aftrekken_door_verschil_te_bepalen();
            komols_gewijs_aftrekken = new Komols_gewijs_aftrekken();
            rekenen_met_een_rond_getal = new Rekenen_met_een_rond_getal();
            splitstrategie_substraction = new Splitstrategie_substraction();
            aftrekken_analogie = new Aftrekken_Analogie();
            Aftrekken_met_reigen = new Aftrekken_met_reigen();
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
            lijst.Add(aftrekken_analogie.ReturnStrat());
            lijst.Add(Aftrekken_met_reigen.ReturnStrat());

            lijst.RemoveAll(item => item == null);

            return data.GetStratsToDisplay(lijst);
        }
        public void chainOrder()
        {
            aftrekken_door_verschil_te_bepalen.setNextChain(komols_gewijs_aftrekken);
            komols_gewijs_aftrekken.setNextChain(rekenen_met_een_rond_getal);
            rekenen_met_een_rond_getal.setNextChain(splitstrategie_substraction);
            splitstrategie_substraction.setNextChain(aftrekken_analogie);
            aftrekken_analogie.setNextChain(Aftrekken_met_reigen);
        }
    }

    // Strategies for Fractures
    public class Fracture : IStrategyList
    {
        StrategiesToDisplay data = new StrategiesToDisplay();

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
        StrategiesToDisplay data = new StrategiesToDisplay();

        ICheckStrategy analogie;
        ICheckStrategy optellen_kolomsgewijs;
        ICheckStrategy rekenen_met_mooie_getallen;
        ICheckStrategy rekenen_met_rond_getal;
        ICheckStrategy splitstrategie;
        ICheckStrategy optellen_met_reigen;

        public Addition(string a, string b)
        {
            analogie = new Analogie();
            optellen_kolomsgewijs = new Optellen_kolomsgewijs();
            rekenen_met_mooie_getallen = new Rekenen_met_mooie_getallen();
            rekenen_met_rond_getal = new Rekenen_met_rond_getal();
            splitstrategie = new Splitstrategie();
            optellen_met_reigen = new Optellen_met_reigen();
            chainOrder();
            analogie.DoAnalyze(a, b);
        }

        public List<ICheckStrategy> getSolutions()
        {
            List<ICheckStrategy> lijst = new List<ICheckStrategy>();
            lijst.Add(analogie.ReturnStrat());
            lijst.Add(splitstrategie.ReturnStrat());
            lijst.Add(optellen_met_reigen.ReturnStrat());
            lijst.Add(rekenen_met_rond_getal.ReturnStrat());
            lijst.Add(optellen_kolomsgewijs.ReturnStrat());
            lijst.Add(rekenen_met_mooie_getallen.ReturnStrat());                     

            lijst.RemoveAll(item => item == null);

            return data.GetStratsToDisplay(lijst);
        }

        public void chainOrder()
        {
            analogie.setNextChain(splitstrategie);
            splitstrategie.setNextChain(optellen_met_reigen);
            optellen_met_reigen.setNextChain(rekenen_met_rond_getal);
            rekenen_met_rond_getal.setNextChain(optellen_kolomsgewijs);
            optellen_kolomsgewijs.setNextChain(rekenen_met_mooie_getallen);
        }
    }
}

