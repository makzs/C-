namespace _12_ClassesObjetos;

// classe Animal
// define um animal e o som que ele faz

class Animal
{
    // define qual vai ser os parametros da classe animal
    public string name;
    public string sound;
    static int numOfAnimals = 0;

    // retorna um nome e som padrao caso nao seja definido ao chamar a classe
    public Animal(){
        name = "No Name";
        sound = "No Sound";
        numOfAnimals++;

    }

    // construct para retornar um valor caso só o nome seja declarado
    public Animal(string name = "No Name"){
        this.name = name;
        this.sound = "No sound";
        numOfAnimals++;
    }

    // construct para retornar um valor se os dois forem declarados
    public Animal(string name = "No Name", string sound = "No Sound"){
        this.name = name;
        this.sound = sound;
        numOfAnimals++;
    }

    // cria uma funcao de fazer o som de determinado animal
    public void MakeSound(){
        Console.WriteLine("{0} diz {1}", name, sound);

    }

    // cria uma funcao para chamar quantos animais foram registrados
    public static int GetNumAnimals(){
        return numOfAnimals;
    }
}
