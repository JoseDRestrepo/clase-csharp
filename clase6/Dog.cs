class Dog : DomesticAnimal {
    //implement abstract method
    public override string sound() {
        return "woof woof";
    }

    public void view_dog_sound() {
        Console.WriteLine(sound());
    }
}