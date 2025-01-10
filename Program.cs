using drtdr;
static int Sokning(List<Person> list, int key){
    int high = list.Count-1;
    int low = 0;
        while(low<=high){
            int mid = (low+high)/2;
                if(key> mid){
                    low= mid + 1;
                }
                else if(key< mid){
                    low = mid - 1;
                }
                else return mid;
        }
        return -1;
}
List<Person> personlista = new List<Person>();
personlista.Add(new Person(1, "teodor"));
personlista.Add(new Person(2,"Jetmir Curry"));
personlista.Add(new Person(3,"Tore"));
personlista.Add(new Person(4,"Andis"));
personlista.Add(new Person(5,"Tore"));
personlista.Add(new Person(6,"Tore"));
personlista.Add(new Person(7,"Tore"));
personlista.Add(new Person(8,"Tore"));
personlista.Add(new Person(9,"Tore"));
personlista.Add(new Person(10,"Tore"));
personlista.Add(new Person(11,"Tore"));
personlista.Add(new Person(12,"Tore"));
personlista.Add(new Person(13,"Tore"));
personlista.Add(new Person(14,"Tore"));
personlista.Add(new Person(15,"Tore"));

Console.WriteLine("Skriv in person nummer");
int nyckel = int.Parse(Console.ReadLine());
int index = Sokning(personlista, nyckel);
Console.WriteLine(personlista[index].Namn);

