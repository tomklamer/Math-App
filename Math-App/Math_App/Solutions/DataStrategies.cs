using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Solutions
{
    public class DataStrategies
    {
        // Fuction for getting right equation list
        public List<int> ReturnStrats(int value, List<int> list)
        {
            switch (value)
            {
                case 1:
                    return GetCombination(list, ADDcombinations);
                case 2:
                    return GetCombination(list, DEVcombinations);
                case 3:
                    return GetCombination(list, MINcombinations);  
                case 4:
                    return GetCombination(list, MULcombinations);  
                case 5:
                    return GetCombination(list, FRAcombinations);  
            }
            return null;
        }

        // Function for getting the right combination list
        private List<int> GetCombination(List<int> a, List<Combination> b)
        {            
            for (int i = 0; i < b.Count; i++)
            {
                bool temp = false;
                if (a.Count == b[i].strategies.Count)
                {
                    for (int x = 0; x < b[i].strategies.Count; x++)
                    {
                        if(b[i].strategies[x] != a[x])
                        {
                            temp = false;
                            break;
                        }
                        temp = true;
                    }
                    if (temp)
                    {
                        return b[i].usedStrategies;                        
                    }            
                }
            }
            return null;
        }


        // All addition combination stored in list
        private List<Combination> ADDcombinations = new List<Combination>()
        {            
             new Combination()
            {
                strategies = new List<int>()
                {
                    2
                },
                usedStrategies = new List<int>
                {
                    2
                }
            },
              new Combination()
            {
                strategies = new List<int>()
                {
                    3
                },
                usedStrategies = new List<int>
                {
                    3
                }
            },
                  new Combination()
            {
                strategies = new List<int>()
                {
                    4
                },
                usedStrategies = new List<int>
                {
                    4
                }
            },
                  new Combination()
            {
                strategies = new List<int>()
                {
                    1,
                    2
                },
                usedStrategies = new List<int>
                {
                    1,
                    2
                }
            },
                        new Combination()
            {
                strategies = new List<int>()
                {
                    1,
                    2,
                    3,
                    5
                },
                usedStrategies = new List<int>
                {
                    1,
                    2,
                    3,
                    5
                }
            },
                  new Combination()
            {
                strategies = new List<int>()
                {
                    1,
                    2,
                    5
                },
                usedStrategies = new List<int>
                {
                    1,
                    2,
                    5
                }
            },
               new Combination()
            {
                strategies = new List<int>()
                {
                    2,
                    4
                },
                usedStrategies = new List<int>
                {
                    2,
                    4
                }
            },             
            new Combination()
            {
                strategies = new List<int>()
                {
                    1,
                    2,
                    3
                },
                usedStrategies = new List<int>
                {
                    1,
                    2,
                    3
                }
            },
             new Combination()
            {
                strategies = new List<int>()
                {                    
                    2,
                    3,
                    4
                },
                usedStrategies = new List<int>
                {                    
                    2,
                    3,
                    4
                }
            },
             new Combination()
            {
                strategies = new List<int>()
                {
                    1,
                    2
                },
                usedStrategies = new List<int>
                {
                    1,
                    2
                }
            },
              new Combination()
            {
                strategies = new List<int>()
                {
                    2,
                    3
                },
                usedStrategies = new List<int>
                {
                    2,
                    3
                }
            }
        };

        // All devition combination stored in list
        private List<Combination> DEVcombinations = new List<Combination>()
        {
            new Combination()
            {

            },
            new Combination()
            {

            }
        };

        // All minus combination stored in list
        private List<Combination> MINcombinations = new List<Combination>()
        {
            new Combination()
            {

            },
            new Combination()
            {

            }
        };

        // All muliplication combination stored in list
        private List<Combination> MULcombinations = new List<Combination>()
        {
            new Combination()
            {
                strategies = new List<int>()
                {
                    6,
                    12
                },
                usedStrategies = new List<int>()
                {
                    6,
                    12
                }
            },
            new Combination()
            {
                strategies = new List<int>()
                {
                    1,
                    12
                },
                usedStrategies = new List<int>()
                {
                    1,
                    12
                }
            },
            new Combination()
            {
                strategies = new List<int>()
                {
                    5,
                    12
                },
                usedStrategies = new List<int>()
                {
                    5,
                    12
                }
            },
            new Combination()
            {
                strategies = new List<int>()
                {
                    4,
                    12
                },
                usedStrategies = new List<int>()
                {
                    4,
                    12
                }
            },
            new Combination()
            {
                strategies = new List<int>()
                {
                    3,
                    12
                },
                usedStrategies = new List<int>()
                {
                    3,
                    12
                }
            },
            new Combination()
            {
                strategies = new List<int>()
                {
                    8,
                    12
                },
                usedStrategies = new List<int>()
                {
                    8,
                    12
                }
            },
            new Combination()
            {
                strategies = new List<int>()
                {
                    10,
                    12,
                    13
                },
                usedStrategies = new List<int>()
                {
                    10,
                    12,
                    13
                }
            },
            new Combination()
            {
                strategies = new List<int>()
                {
                    7,
                    2
                },
                usedStrategies = new List<int>()
                {
                    7,
                    2
                }
            },
            new Combination()
            {
                strategies = new List<int>()
                {
                    2,
                    14
                },
                usedStrategies = new List<int>()
                {
                    2,
                    14
                }
            },
            new Combination()
            {
                strategies = new List<int>()
                {
                    9,
                    2
                },
                usedStrategies = new List<int>()
                {
                    9,
                    2
                }
            },
            new Combination()
            {
                strategies = new List<int>()
                {
                    11,
                    2
                },
                usedStrategies = new List<int>()
                {
                    11,
                    2
                }
            }
        };

        // All fraction combination stored in list
        private List<Combination> FRAcombinations = new List<Combination>()
        {
            new Combination()
            {

            },
            new Combination()
            {

            }
        };
    }

    // DTO object 
    public class Combination
    {
        public List<int> strategies;
        public List<int> usedStrategies;
    }
}
