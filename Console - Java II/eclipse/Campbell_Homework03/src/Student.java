public class Student extends Person
{
	
	ClassLevel classStatus;
	Student(String First, String Last, int streetNumber, String streetName, String streetSuffix, long phoneNumber,
			String eMail,ClassLevel classStatus)
	{
		super(First, Last, streetNumber, streetName, streetSuffix, phoneNumber, eMail);
		this.classStatus = classStatus;
	}
	public String toString()
	{
		String output = super.toString();
		output+= String.format("\nClass status: %s", classStatus.value);
		return output;
	}
}

