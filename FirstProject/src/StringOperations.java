
public class StringOperations {
	public static void main(String[] args){
		String str1 = "Hello";
		String str2 = "Duke";
		String str3; //uninitialized string
		
		//create a new string by concatenation
		str3 = "You are " + str2;
		//display a welcome message to screen
		System.out.println("Welcome: " + str3);
		//Display the length of a string
		System.out.println("Length: "+ str1.length());
		//Display a substring of str1 beginning with character 0,
		//up to, but not including character 5
		System.out.println("Sub: "+ str3.substring(0,5));
		//display a string value in uppercase
		System.out.println("Upper: "+str2.toUpperCase());
		//Compare 2 Strings to see if they are the same or
		//identify which String value comes first
		System.out.println(str1.compareTo(str2));
		//Compare 2 Strings to see if they are the same
		System.out.println(str1.equals(str2));

	}//end method main
}//end class StringOperations
