public abstract class DomesticAnimal {
    public string id { get; set; }
    public short age;

    public short Age {
        get {
            return age;
        }
        set {
            if (value >= 1 && value <= 5) {
                age = value;
            } else {
                Console.WriteLine("Unvalid age");
            }
        }
    }

    //methods
    public void to_run() {
        // return "is running";
        Console.WriteLine("Is running");
    }

    //structure definitions
    public abstract string sound();
}