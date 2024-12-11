namespace day16_2
{
    /// <summary>
    /// 상속 => 물려받다. 클래스를 만들 때 중복된 내용이 많을 경우
    /// 공통된 기능이나 필드를 뽑아내서 상속을 고려할 수 있음
    /// 여기서 공통된 기능을 가지는 필기구, 몬스터, 자동차 등등을 base클래스 또는 부모 클래스라고
    /// 부른다. 부모에서 파생된 클래스를 derived 클래스 또는 파생클래스, 자식클래스 라고
    /// 한다.
    /// 
    /// 접근 지정자 => public, private, protected => protected=> 파생클래스는 사용가능
    /// 상속관계에서의 생성자=> :base를 붙여줄것 인자 없는 상속자도 마찬가지
    /// </summary>




    class Car
    {
        protected float _maxSpeed;
        protected string _brand;
        private string _carPlate = "12가1234";
        public Car()
        {

        }
        public Car(string carPlate)
        {
            _carPlate = carPlate;
            Console.WriteLine("mamawork!");
        }
        public void PrintCarPlate()
        {
            Console.WriteLine(_carPlate);
        }
        public void Drive()
        {
            Console.WriteLine("Driving");
        }
    }
    class Sedan : Car
    {
        public int _partner;
        public Sedan(int partners, string carPlate) : base(carPlate)
        {
            _partner = partners;
            //_carPlate = carPlate;
            Console.WriteLine("work!");
        }
        public void SedanAction()
        {

            Console.WriteLine("Partner pickup");
        }

    }

    class Truck : Car
    {
        protected bool _isAddtional2;
        public Truck()
        {

        }
        public Truck(string carPlate) : base(carPlate) 
        {
            Console.WriteLine("truck");

        }
        public void TruckAction()
        {
            Console.WriteLine("Cargo pickup");
        }

    }

    class PickupTruck : Truck
    {
        bool _additional;

        public PickupTruck(bool additional,string brand, string carPlate,bool tr):base(carPlate)
        {
            _additional = true;
            this._brand = brand;
            _additional = additional;
            _isAddtional2 = tr;
        }
    }

    sealed class Bulldozer : Car //sealed 클래스 앞에 붙이는 단어로 이 클래스를 상속받게 
        //하지 못하게 만든다
    {


        public void BulldozerAction()
        {
            Console.WriteLine("Digging");
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            //Car mycar= new Car("sdfsdf");
            //Sedan mysedan = new Sedan(4, "sdfsdf");
            PickupTruck truck = new PickupTruck(true,"kia","12sk",true);

        }
    }
}
