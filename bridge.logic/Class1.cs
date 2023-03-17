namespace bridge.logic
{
    public class MyBridge
    {
        private readonly string _bridge;

        public MyBridge(string bridge)
        {
            _bridge = bridge;
        }
        public bool isvalidbridge(string _bridge)
        {
            int size = _bridge.Length;
            char bas = _bridge[0];

            if (bas != '*')
            {
                throw new ArgumentException("1The bridge is NOT valid");
            }
            if (size - 1 != '*')
            {
                throw new ArgumentException("2The bridge is NOT valid");

            }
            int reinforcementcounter = 0;

            for (int i = 1; i < size - 1; i++)
            {
                char next = _bridge[i];

                if (next != '=' || next != '+')
                {
                    throw new ArgumentException(" 3The bridge is NOT valid");

                }
                if (next == '=')
                {
                    reinforcementcounter++;
                }
                else
                {
                    reinforcementcounter = 0;
                }
                if (reinforcementcounter == 4)
                {
                    throw new ArgumentException("4The bridge is NOT valid");

                }
            }
            reinforcementcounter = 0;

            for (int i = 1; i < size / 2; i++)
            {
                int leftside = _bridge[i + 1];
                int rightside = size - i - 1;

                if (leftside != rightside)
                {
                    throw new ArgumentException("5The bridge is NOT valid");

                }
                if (leftside == '+')
                {
                    reinforcementcounter++;
                }
                else
                {
                    reinforcementcounter = 0;
                }
                if (reinforcementcounter == 3)
                {
                    throw new ArgumentException("6The bridge is NOT valid");
                }
            }
            throw new ArgumentException("The bridge is valid :)");

        }


    }
}