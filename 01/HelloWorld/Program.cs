// Classe teste para o meu primeiro programa em C#

public class Dog{
    private string name;
    private int age;
    private bool isDead;

    public Dog(string name, int age){
        this.name = name;
        this.age = age;
        isDead = true;
    }

    public string toString(){
        return string.Format("My dog name is {0} and his age is {0}.", name, age);
    }

    public static void Main(string[] args){
        Dog meuCachorro = new Dog("Dougo", 2);

        Console.Write(meuCachorro.toString());
    }
}

