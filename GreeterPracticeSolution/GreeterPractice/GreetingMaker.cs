namespace GreeterPractice;

public class GreetingMaker
{
    public GreetingMaker()
    {
    }

    public string Greet(string[]? names)
    {
        // No name?
        if(names == null)
        {
            return "Hello, Chief!";
        }
        else
        {
            // Variable Declariations
            List<string> lowerNames = new List<string>();
            List<string> upperNames = new List<string>();
            bool allShoutingNames = false;
            string message = "";

            // Split the list into whisper and SHOUTING names
            foreach (string name in names)
            {
                if(name == name.ToUpper())
                {
                    upperNames.Add(name);
                }
                else
                {
                    lowerNames.Add(name);
                }
            }

            // This will determine if the whole message should be shouted
            if (lowerNames.Count == 0)
            {
                allShoutingNames = true;
            }

            // Combine the lists
            lowerNames.AddRange(upperNames);

            // Greeting
            if(allShoutingNames)
            {
                message += "HELLO, ";
            }
            else
            {
                 message += "Hello, ";
            }

            // Name Time
            foreach (string name in lowerNames)
            {
                // Handles spacing in between each name
                if (name == lowerNames[0])
                {
                    // Do nothing
                }
                else if (name == lowerNames[lowerNames.Count-1]) {
                    // Last name, add "and "
                    if(lowerNames.Count == 2)
                    {
                        // Cases for there being only two names in the list
                        if (upperNames.Count > 0)
                        {
                            message += " AND ";
                        }
                        else
                        {
                            message += " and ";
                        }   
                    }
                    else
                    {
                        // Cases for more than two names in the list
                        if(upperNames.Count > 0)
                        {
                            message += ", AND ";
                        }
                        else
                        {
                            message += ", and ";
                        }
                    }
                }
                else
                {
                    // The list goes on, add ", "
                    message += ", ";
                }

                // Handles the name
                if (name == name.ToUpper())
                {
                    message += $"{name.ToUpper()}";
                }
                else
                {
                    message += $"{name}";
                }
            }

            // Add the punctuation and return
            message += "!";
            return message;
        }
    }
}