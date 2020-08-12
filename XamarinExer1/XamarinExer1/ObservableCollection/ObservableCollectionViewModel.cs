using System.Collections.ObjectModel;

namespace XamarinExer1.ObservableCollection
{
    public class ObservableCollectionViewModel
    {
        public ObservableCollectionViewModel()
        {
            this.GetLetters();
        }

        public ObservableCollection<ModelList> LettersList { get; set; }

        private void GetLetters()
        {
            if (this.LettersList == null)
                this.LettersList = new ObservableCollection<ModelList>();

            this.LettersList.Add(new ModelList() { LeftLetters = "A", LeftLettersImage = "a.jpg", RightLetters = "B", RightLettersImage = "b.jpg" });
            this.LettersList.Add(new ModelList() { LeftLetters = "C", LeftLettersImage = "c.jpg", RightLetters = "D", RightLettersImage = "d.jpg" });
            this.LettersList.Add(new ModelList() { LeftLetters = "E", LeftLettersImage = "e.jpg", RightLetters = "F", RightLettersImage = "f.jpg" });
            this.LettersList.Add(new ModelList() { LeftLetters = "G", LeftLettersImage = "g.jpg", RightLetters = "H", RightLettersImage = "h.jpg" });
            this.LettersList.Add(new ModelList() { LeftLetters = "I", LeftLettersImage = "i.jpg", RightLetters = "J", RightLettersImage = "j.jpg" });
        }
    }
    public class ModelList
    {
        public string LeftLetters { get; set; }
        public string RightLetters { get; set; }
        public string LeftLettersImage { get; set; }
        public string RightLettersImage { get; set; }
    }
}
