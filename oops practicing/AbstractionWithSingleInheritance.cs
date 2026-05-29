using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
    abstract class Vehicle
    {
        protected string vehiclename;
        public Vehicle(string vehiclename)
        {
            this.vehiclename = vehiclename;
            Console.WriteLine("Vehicle is calling");
        }
        public void DisplayName()
        {
            Console.WriteLine($"vehicle name : {vehiclename} ");
        }
        public abstract void VehicleType();
    }
    abstract class VehicleModel : Vehicle
    {
        protected string Modelname;
        public VehicleModel(string vehiclename, string modelname) : base(vehiclename)
        {
            Modelname = modelname;
            Console.WriteLine("Vehicle model is calling");
        }
        public void displayModel()
        {
            Console.WriteLine($"Model name  : {Modelname}");
        }
        public abstract void ModelType();
    }
    class VehicleData:VehicleModel
    {
        public int vehiclenum;
        public VehicleData(string vehiclename,string modelname,int vehiclenum):base(vehiclename,modelname)
        {
            this.vehiclenum= vehiclenum;
            Console.WriteLine("VehicleData is calling");

        }
        public void numberdisplay()
        {
            Console.WriteLine($"vehicle number : {vehiclenum}");
        }
        public override void VehicleType()
        {
            Console.WriteLine("cars");
        }
        public override void ModelType()
        {
            Console.WriteLine("Electric");
        }
    }
    internal class AbstractionWithSingleInheritance
    {
        static void Main(string[] args) 
        {
            VehicleData vd = new VehicleData("Audi", "a8", 9999);
           
            vd.VehicleType();
            vd.ModelType();
            vd.DisplayName();
            vd.displayModel();
            vd.numberdisplay();
            
        }
       
        
    }
}
