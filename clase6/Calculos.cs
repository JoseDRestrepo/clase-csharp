public abstract class Calculos {
    double num1;
    double num2;
    public double n1 {
        get {
            return num1;
        }
        set {
            if (value < 0) {
                Console.WriteLine("Dato invalido, los calculos se realizan con numeros positivos");
            } else {
                num1 = value;
            }
        }
    }
    public double n2 {
        get {
            return num2;
        }
        set {
            if (value < 0) {
                Console.WriteLine("Dato invalido, los calculos se realizan con numeros positivos");
            } else {
                num2 = value;
            }
        }
    }

    public abstract double Calculo(double n1, double n2);
}