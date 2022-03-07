public class Person
{
	Email eMail;
	TelNumber phoneNumber; 
	Address address;
	Name name;
	Person(String First, String Last, int streetNumber, String streetName, String streetSuffix,
			long phoneNumber, String eMail)
	{
		this.name = new Name(First, Last);
		this.address = new Address(streetNumber, streetName, streetSuffix);
		this.phoneNumber = new TelNumber(phoneNumber);
		this.eMail = new Email(eMail);
	}
	public String toString()
	{
		String output;
		output = String.format("\nName: %s\nAddress: %s\nPhone Number: %s\nEmail: %s",
				name.toString(),address.toString(),phoneNumber.toString(),eMail.toString());
		return output;
	}
	
}

class Name
{
	String FirstName, LastName;
	Name(String firstName, String lastName){
		this.FirstName = firstName;
		this.LastName = lastName;
	}
	public String toString()
	{
		String output = LastName+", "+FirstName;		
		return output;
	}
}

class Address
{
	int streetNumber;
	String streetName, streetSuffix;
	
	Address(int streetNumber,String streetName,String streetSuffix)
	{
		this.streetNumber = streetNumber;
		this.streetName = streetName;
		this.streetSuffix = streetSuffix;	
	}
	public String toString()
	{
		String output = streetNumber+" "+streetName+" "+streetSuffix;
		return output;
	}
}

class TelNumber
{
	private long AreaCode, PhoneNumber;
	TelNumber(long PhoneNumberWithAreaCode)
	{
		String temp = Long.toString(PhoneNumberWithAreaCode).substring(0,3);
		AreaCode = Long.parseLong(temp);
		temp = Long.toString(PhoneNumberWithAreaCode).substring(3);
		PhoneNumber = Long.parseLong(temp);
	}
	TelNumber(long areaCode, long phoneNumber)
	{
		this.AreaCode = areaCode;
		this.PhoneNumber = phoneNumber;
	}
	
	public String toString()
	{
		String output = "";
		output = "("+Long.toString(AreaCode)+") "+Long.toString(PhoneNumber).substring(0,3)+
				"-"+Long.toString(PhoneNumber).substring(3);
		return output;
	}
}

class Email
{
	private String topLevelDomain, secondLevelDomain, address;
	Email(String EmailAddress)
	{
		int i;
		i = EmailAddress.indexOf('@');
		this.address = EmailAddress.substring(0,i);
		EmailAddress = EmailAddress.substring(i+1);
		i = EmailAddress.indexOf('.');
		this.secondLevelDomain = EmailAddress.substring(0,i);
		this.topLevelDomain = EmailAddress.substring(i+1);
	}
	public String toString()
	{
		String output = address+"@"+secondLevelDomain+"."+topLevelDomain;
		return output;
	}
}