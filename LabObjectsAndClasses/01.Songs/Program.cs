//class Program - използваме, за да създаваме обекти и да пишем програмна логика

public class Program
{
    public static void Main(string[] args)
    {


        int countSongs = int.Parse(Console.ReadLine());

        List<Song> songList = new List<Song>(); //списък, в който ще се съхраняват елементи от класа Song

        for (int count = 1; count <= countSongs; count++)
        {
            string data = Console.ReadLine();//favourite_DownTown_3:14
                                             //"favourite_DownTown_3:14:.Split("_") -> ["favourite", "DownTown", "3:14"]
            string typeList = data.Split("_")[0];//сплитваме по долна черта, елемнтът на 0 позиция е favourite
            string name = data.Split("_")[1];
            string time = data.Split("_")[2];

            Song song = new Song(typeList, name, time); //за всяка една песен създаваме нов обект от класа Song,
                                                        //който притежава тези характеристики горе
            songList.Add(song);//добавяме всеки един обект song към списъка songList горе 

        }

        //songList - добавили сме всички песни
        string chosenPlaylist = Console.ReadLine();//текстът, който се въвежда на последния ред от конзолата

        foreach (Song song in songList) //за всяка една песен от списъка
        {
            if (song.TypeList == chosenPlaylist || chosenPlaylist == "all")
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}