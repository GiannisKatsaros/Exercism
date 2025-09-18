class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int currentMinutesInOven)
    {
        return ExpectedMinutesInOven() - currentMinutesInOven;
    }
    
    public int PreparationTimeInMinutes(int layers)
    {
        return 2 * layers;
    }
    
    public int ElapsedTimeInMinutes(int layers, int elapsedMinutesInOven)
    {
        var layerMinutes = PreparationTimeInMinutes(layers);
        return layerMinutes + elapsedMinutesInOven;
    }
}
