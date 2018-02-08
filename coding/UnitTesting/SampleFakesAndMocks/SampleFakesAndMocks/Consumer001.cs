namespace SampleFakesAndMocks
{
	using SomeoneElsesComponent;

	public class Consumer001
    {
	    public string UseFileContent(string fileName)
	    {
		    var component = new DamnBigComponent();
		    return component.LoadFileContent(fileName);
	    }
    }
}
