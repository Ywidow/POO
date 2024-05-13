using ZooApplication.Domain.Abstractions;

namespace ZooApplication.Domain.Entities;

public class Veterinario
{
    public void Examinar(Cavalo horse) => horse.MakeSound();
    public void Examinar(Cachorro dog) => dog.MakeSound();
    public void Examinar(Preguica sloth) => sloth.MakeSound();
}
