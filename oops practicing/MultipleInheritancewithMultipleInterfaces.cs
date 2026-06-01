using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
    interface IPhone
    {
        void Calling();
        void Receiving();
        void SendMsg();
        void EndCall();
    }
    class iPhoneSE : IPhone
    {
        public void Calling()
        {
            Console.WriteLine("iphoneSE is calling");
        }
        public void Receiving()
        {
            Console.WriteLine("iphoneSE is calls receiving");
        }
        public void SendMsg()
        {
            Console.WriteLine("iphoneSE issending message");
        }
        public void EndCall()
        {
            Console.WriteLine("iphoneSE is End Call");
        }
    }
    interface IPhoneAdvance
    {
        void faceID();
        void VideoCalling();
        void AirDrop();
    }
    class iPhone16 : IPhone,IPhoneAdvance
    {
        public void Calling()
        {
            Console.WriteLine("iphoneSE is calling");
        }
        public void Receiving()
        {
            Console.WriteLine("iphoneSE is calls receiving");
        }
        public void SendMsg()
        {
            Console.WriteLine("iphoneSE issending message");
        }
        public void EndCall()
        {
            Console.WriteLine("iphoneSE is End Call");
        }
        public void faceID()
        {
            Console.WriteLine("iphone16 is faceID");
        }
        public void VideoCalling()
        {
            Console.WriteLine("iphone16 is VideoCalling");
        }
        public void AirDrop()
        {
            Console.WriteLine("iphone16 is AirDrop");
        }
    }
    internal class MultipleInheritancewithMultipleInterfaces
    {
        static void Main(string[] args)
        {
            IPhone ip = new iPhoneSE();
            ip.Calling();
            ip.Receiving();
            ip.SendMsg();
            ip.EndCall();
            ip=new iPhone16();
            ip.Calling();
            ip.Receiving();
            ip.SendMsg();
            ip.EndCall();
            IPhoneAdvance ipa=new iPhone16();
            ipa.faceID();
            ipa.VideoCalling();
            ipa.AirDrop();

        }
    }
}
