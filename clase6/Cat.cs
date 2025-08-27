public class Cat : DomesticAnimal {
    public override string sound() {
        return "meow";
    }

    public void view_cat_sound() {
        Console.WriteLine(sound());
    }
}