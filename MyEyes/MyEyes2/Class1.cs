namespace MyEyes2
{
    public class XTDSIsAwesome
    {
        public XTDSIsAwesome(Class2 otherClass,
            string wowHowCoolIsIt)
        {
            WowEyeMDEMRIsSoCool = wowHowCoolIsIt;
            AnotherClass = otherClass;
        }

        public void DoSomething()
        {
            AnotherClass.RunSomething();
        }

        public string WowEyeMDEMRIsSoCool { get; }
        public Class2 AnotherClass { get; }
    }
}