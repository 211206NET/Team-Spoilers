namespace Models;

public class Answer{
    public Answer () {}

    public int ID { get; set; }

    public int BingoCardID { get; set; }
    public string block { get; set; }

    public bool isMarked { get; set; }
}