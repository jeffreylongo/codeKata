using System;

public class Guesser
{
    private int number;
    private int lives;

    public Guesser(int number, int lives)
    {
        this.number = number;
        this.lives = lives;
    }

    public bool Guess(int n)
    {
        //throw error if no lives
        if (lives < 1) throw new Exception("Error: No Lives");

        //return false and take a life if guess is wrong
        if (n != number)
        {
            lives--;
            return false;
        }

        //return true if guess is correct
        return true;
    }


}