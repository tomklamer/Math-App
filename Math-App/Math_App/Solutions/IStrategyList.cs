using System;
using System.Collections.Generic;
using System.Text;
using Math_App.Solutions.StrategyChain;
using Math_App.Solutions.StrategyChain.Substraction;
using Math_App.Solutions.StrategyChain.Multiplication;
using Math_App.Solutions.StrategyChain.Division;

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

        ICheckStrategy vermenigvuldigen_met_de_helft_van_10x;
        ICheckStrategy vermenigvuldigen_kolomsgewijs;
        ICheckStrategy vermenigvuldigen_door_halveren;
        ICheckStrategy vermenigvuldigen_met_1x_meer;
        ICheckStrategy vermenigvuldigen_met_1x_minder;
        ICheckStrategy vermenigvuldigen_met_1x_minder_10;
        ICheckStrategy vermenigvuldigen_met_een_handig_getal;
        ICheckStrategy vermenigvuldigen_met_omkeringsprincipe;
        ICheckStrategy vermenigvuldigen_naar_analogie_met_nullen;
        ICheckStrategy vermenigvuldigen_met_rond_getal;
        ICheckStrategy vermenigvulidgen_door_te_verdubbelen;
        ICheckStrategy vermenigvulidgen_met_sprongen_op_de_getallenlijn;
        ICheckStrategy vermenigvulidgen_met_oppervlaktemodel;
        ICheckStrategy cijferend;

        public Multiply(string a, string b)
        {
            vermenigvuldigen_met_de_helft_van_10x = new Vermenigvuldigen_met_de_helft_van_10x();
            vermenigvuldigen_kolomsgewijs = new Vermenigvuldigen_kolomsgewijs();
            vermenigvuldigen_door_halveren = new Vermenigvuldigen_door_halveren();
            vermenigvuldigen_met_1x_meer = new Vermenigvuldigen_met_1x_meer();
            vermenigvuldigen_met_1x_minder = new Vermenigvuldigen_met_1x_minder();
            vermenigvuldigen_met_1x_minder_10 = new Vermenigvuldigen_met_1x_minder_10();
            vermenigvuldigen_met_een_handig_getal = new Vermenigvuldigen_met_een_handig_getal();
            vermenigvuldigen_met_omkeringsprincipe = new Vermenigvuldigen_met_omkeringsprincipe();
            vermenigvuldigen_naar_analogie_met_nullen = new Vermenigvuldigen_naar_analogie_met_nullen();
            vermenigvuldigen_met_rond_getal = new Vermenigvuldigen_met_rond_getal();
            vermenigvulidgen_door_te_verdubbelen = new Vermenigvulidgen_door_te_verdubbelen();
            vermenigvulidgen_met_sprongen_op_de_getallenlijn = new Vermenigvuldigen_met_sprongen_op_de_getallenlijn();
            vermenigvulidgen_met_oppervlaktemodel = new Vermenigvuldigen_met_oppervlaktemodel();
            cijferend = new Cijferend();
            chainOrder();
            vermenigvuldigen_door_halveren.DoAnalyze(a, b);
        }

        public List<ICheckStrategy> getSolutions()
        {
            List<ICheckStrategy> lijst = new List<ICheckStrategy>();            
            lijst.Add(vermenigvuldigen_door_halveren.ReturnStrat());
            lijst.Add(vermenigvuldigen_kolomsgewijs.ReturnStrat());
            lijst.Add(vermenigvuldigen_met_1x_meer.ReturnStrat());
            lijst.Add(vermenigvuldigen_met_1x_minder.ReturnStrat());
            lijst.Add(vermenigvuldigen_met_1x_minder_10.ReturnStrat());
            lijst.Add(vermenigvuldigen_met_de_helft_van_10x.ReturnStrat());
            lijst.Add(vermenigvuldigen_met_een_handig_getal.ReturnStrat());
            lijst.Add(vermenigvuldigen_met_omkeringsprincipe.ReturnStrat());
            lijst.Add(vermenigvuldigen_naar_analogie_met_nullen.ReturnStrat());
            lijst.Add(vermenigvuldigen_met_rond_getal.ReturnStrat());
            lijst.Add(vermenigvulidgen_door_te_verdubbelen.ReturnStrat());
            lijst.Add(vermenigvulidgen_met_sprongen_op_de_getallenlijn.ReturnStrat());
            lijst.Add(vermenigvulidgen_met_oppervlaktemodel.ReturnStrat());
            lijst.Add(cijferend.ReturnStrat());

            lijst.RemoveAll(item => item == null);

            for (int i = 0; i < lijst.Count; i++)
            {
                Console.WriteLine(lijst[i].ReturnImportance());
            }

            return data.GetStratsToDisplay(lijst, 4);
        }

        public void chainOrder()
        {
            vermenigvuldigen_door_halveren.setNextChain(vermenigvuldigen_kolomsgewijs);
            vermenigvuldigen_kolomsgewijs.setNextChain(vermenigvuldigen_met_1x_meer);
            vermenigvuldigen_met_1x_meer.setNextChain(vermenigvuldigen_met_1x_minder_10);
            vermenigvuldigen_met_1x_minder_10.setNextChain(vermenigvuldigen_met_1x_minder);
            vermenigvuldigen_met_1x_minder.setNextChain(vermenigvuldigen_met_de_helft_van_10x);
            vermenigvuldigen_met_de_helft_van_10x.setNextChain(vermenigvuldigen_met_een_handig_getal);
            vermenigvuldigen_met_een_handig_getal.setNextChain(vermenigvuldigen_met_omkeringsprincipe);
            vermenigvuldigen_met_omkeringsprincipe.setNextChain(vermenigvuldigen_met_rond_getal);
            vermenigvuldigen_met_rond_getal.setNextChain(vermenigvuldigen_naar_analogie_met_nullen);
            vermenigvuldigen_naar_analogie_met_nullen.setNextChain(vermenigvulidgen_door_te_verdubbelen);
            vermenigvulidgen_door_te_verdubbelen.setNextChain(vermenigvulidgen_met_sprongen_op_de_getallenlijn);
            vermenigvulidgen_met_sprongen_op_de_getallenlijn.setNextChain(vermenigvulidgen_met_oppervlaktemodel);
            vermenigvulidgen_met_oppervlaktemodel.setNextChain(cijferend);
        }
    }

    // Strategies for Dividing
    public class Devide : IStrategyList
    {
        StrategiesToDisplay data = new StrategiesToDisplay();

        ICheckStrategy delen_door_gebruik_van_inverse;
        ICheckStrategy delen_door_herhaald_aftrekken_rest;
        ICheckStrategy delen_door_herhaald_aftrekken;
        ICheckStrategy delen_door_herhaald_aftrekken_met_afschatten;
        ICheckStrategy delen_naar_analogie_met_nullen;

        public Devide(string a, string b)
        {
            delen_door_gebruik_van_inverse = new Delen_door_gebruik_van_inverse_relatie();
            delen_door_herhaald_aftrekken_rest = new Delen_door_herhaald_aftrekken_rest();
            delen_door_herhaald_aftrekken = new Delen_door_herhaald_aftrekken();
            delen_door_herhaald_aftrekken_met_afschatten = new Delen_door_herhaald_aftrekken_met_afschatten();
            delen_naar_analogie_met_nullen = new Delen_naar_analogie_met_nullen();
            chainOrder();
            delen_door_gebruik_van_inverse.DoAnalyze(a, b);
        }

        public List<ICheckStrategy> getSolutions()
        {
            List<ICheckStrategy> lijst = new List<ICheckStrategy>();
            lijst.Add(delen_door_gebruik_van_inverse.ReturnStrat());
            lijst.Add(delen_door_herhaald_aftrekken_rest.ReturnStrat());
            lijst.Add(delen_door_herhaald_aftrekken.ReturnStrat());
            lijst.Add(delen_door_herhaald_aftrekken_met_afschatten.ReturnStrat());
            lijst.Add(delen_naar_analogie_met_nullen.ReturnStrat());

            lijst.RemoveAll(item => item == null);

            for (int i = 0; i < lijst.Count; i++)
            {
                Console.WriteLine(lijst[i].ReturnImportance());
            }

            return lijst;
        }

        public void chainOrder()
        {
            delen_door_gebruik_van_inverse.setNextChain(delen_door_herhaald_aftrekken_rest);
            delen_door_herhaald_aftrekken_rest.setNextChain(delen_door_herhaald_aftrekken);
            delen_door_herhaald_aftrekken.setNextChain(delen_door_herhaald_aftrekken_met_afschatten);
            delen_door_herhaald_aftrekken_met_afschatten.setNextChain(delen_naar_analogie_met_nullen);
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
        ICheckStrategy aftrekken_algoritmisch;
        ICheckStrategy aftrekken_met_reigen_met_rond_getal;

        public Minus(string a, string b)
        {
            aftrekken_door_verschil_te_bepalen = new Aftrekken_door_verschil_te_bepalen();
            komols_gewijs_aftrekken = new Komols_gewijs_aftrekken();
            rekenen_met_een_rond_getal = new Rekenen_met_een_rond_getal();
            splitstrategie_substraction = new Splitstrategie_substraction();
            aftrekken_analogie = new Aftrekken_Analogie();
            Aftrekken_met_reigen = new Aftrekken_met_reigen();
            aftrekken_algoritmisch = new Aftrekken_algoritmisch();
            aftrekken_met_reigen_met_rond_getal = new Aftrekken_met_rijgen_met_rond_getal();
            chainOrder();
            aftrekken_analogie.DoAnalyze(a, b);
        }

        public List<ICheckStrategy> getSolutions()
        {
            List<ICheckStrategy> lijst = new List<ICheckStrategy>();
            lijst.Add(aftrekken_analogie.ReturnStrat());
            lijst.Add(komols_gewijs_aftrekken.ReturnStrat());
            lijst.Add(rekenen_met_een_rond_getal.ReturnStrat());
            lijst.Add(splitstrategie_substraction.ReturnStrat());
            lijst.Add(Aftrekken_met_reigen.ReturnStrat());
            lijst.Add(aftrekken_door_verschil_te_bepalen.ReturnStrat());
            lijst.Add(aftrekken_algoritmisch.ReturnStrat());
            lijst.Add(aftrekken_met_reigen_met_rond_getal.ReturnStrat());

            lijst.RemoveAll(item => item == null);

            for (int i = 0; i < lijst.Count; i++)
            {
                Console.WriteLine(lijst[i].ReturnImportance());
            }

            return data.GetStratsToDisplay(lijst, 3);
        }
        public void chainOrder()
        {
            aftrekken_analogie.setNextChain(komols_gewijs_aftrekken);
            komols_gewijs_aftrekken.setNextChain(rekenen_met_een_rond_getal);
            rekenen_met_een_rond_getal.setNextChain(splitstrategie_substraction);
            splitstrategie_substraction.setNextChain(Aftrekken_met_reigen);
            Aftrekken_met_reigen.setNextChain(aftrekken_door_verschil_te_bepalen);
            aftrekken_door_verschil_te_bepalen.setNextChain(aftrekken_algoritmisch);
            aftrekken_algoritmisch.setNextChain(aftrekken_met_reigen_met_rond_getal);
        }
    }

    // Strategies for Fractures
    public class Fracture : IStrategyList
    {
        StrategiesToDisplay data = new StrategiesToDisplay();

        ICheckStrategy strat1;
        ICheckStrategy strat2;

        public Fracture(string a, string b)
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
        ICheckStrategy optellen_met_algoritmisch;
        ICheckStrategy optellen_met_reigen_met_rond_getal;
        ICheckStrategy optellen_splitsen_analogie;

        public Addition(string a, string b)
        {
            analogie = new Analogie();
            optellen_kolomsgewijs = new Optellen_kolomsgewijs();
            rekenen_met_mooie_getallen = new Rekenen_met_mooie_getallen();
            rekenen_met_rond_getal = new Rekenen_met_rond_getal();
            splitstrategie = new Splitstrategie();
            optellen_met_reigen = new Optellen_met_reigen();
            optellen_met_algoritmisch = new Optellen_algoritmisch();
            optellen_met_reigen_met_rond_getal = new Optellen_met_rijgen_met_rond_getal();
            optellen_splitsen_analogie = new Optellen_splitsen_analogie();
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
            lijst.Add(optellen_met_algoritmisch.ReturnStrat());
            lijst.Add(optellen_met_reigen_met_rond_getal.ReturnStrat());
            lijst.Add(optellen_splitsen_analogie.ReturnStrat());

            lijst.RemoveAll(item => item == null);

            for (int i = 0; i < lijst.Count; i++)
            {
                Console.WriteLine(lijst[i].ReturnImportance());
            }

            return data.GetStratsToDisplay(lijst, 1);
        }

        public void chainOrder()
        {
            analogie.setNextChain(splitstrategie);
            splitstrategie.setNextChain(optellen_met_reigen);
            optellen_met_reigen.setNextChain(rekenen_met_rond_getal);
            rekenen_met_rond_getal.setNextChain(optellen_kolomsgewijs);
            optellen_kolomsgewijs.setNextChain(rekenen_met_mooie_getallen);
            rekenen_met_mooie_getallen.setNextChain(optellen_met_algoritmisch);
            optellen_met_algoritmisch.setNextChain(optellen_met_reigen_met_rond_getal);
            optellen_met_reigen_met_rond_getal.setNextChain(optellen_splitsen_analogie);
        }
    }
}

