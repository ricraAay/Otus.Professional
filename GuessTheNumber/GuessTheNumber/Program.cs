using GuessTheNumber.Services;
using GuessTheNumber.DTO;
using System;

namespace GuessTheNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            var configurate = new GuessTheNumberConfigurate(numberAttempts: 3, range: 1..3);
            var generate = new GuessTheNumberGenerate(random: new GuessTheNumberRandom());
            var validate = new GuessTheNumberValidate();

            var guessTheNumber = new GuessTheNumberService
            (
                configurate: configurate,
                validate: validate,
                generate: generate
            );

            guessTheNumber.Execute();
        }
    }
}