namespace Victor.Training.Cleancode
{
    public class DoStuff
    {
        int x;
        string y;

        public void DoIt(int a, string b) 
        {
            if (y == b)
            {
                x += a;
                Console.WriteLine("Noting metric with label: " + y + " - New Value is: " + x);
                MetricAPI.RecordMetric(a, b);
            }
            else
            {
                throw new ArgumentException("Wrong label for this metric! Returning.");
            }
        }

        public static void Main(string[] args)  
        {
            int order = 20;
            string metricLabelForCpuUsageInMain = "CPU_USAGE";

            new DoStuff().DoIt(order, metricLabelForCpuUsageInMain);

            int value = 20; 
            string cpuD2VUsgCntr = "CPU_USAGE";

            new DoStuff().DoIt(value, cpuD2VUsgCntr);
        }
    }

    class MetricAPI
    {
        public static void RecordMetric(int value, string label) { }
    }

}

