public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    public Feature[] Features {get; set;}
}
public class Feature {
    public Properties Properties { get; set; }
}

public class Properties{
    public decimal Mag { get; set; }
    public string Place { get; set; }
}