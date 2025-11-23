//Song - ще описваме всяка една песен
public class Song
{
    //характеристики - чрез properties
    public string TypeList { get; set; } //плейлист

    public string Name { get; set; } // име

    public string Time { get; set; } //времетраене

    //конструктор - специален метод, чрез който създаваме обекти от класа

    public Song(string typeList, string name, string time)
    {
        //нов празен обект
        TypeList = typeList;
        Name = name;
        Time = time;
    }
    //действия - чрез методи

}

