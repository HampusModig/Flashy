using Flashy.Models;

namespace Flashy.Services;

public class FlashcardService
{
    private readonly List<Flashcard> _flashcards = new();

    public IReadOnlyList<Flashcard> Flashcards => _flashcards;

    public void AddFlashcard(string question, string answer)
    {
        _flashcards.Add(new Flashcard { Question = question, Answer = answer });
    }
}
