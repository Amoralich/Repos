
import java.util.Scanner;
public class AgeChecker {

    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int age;
        char holdLicence;

        System.out.println("Please enter your age: ");
        age = in.nextInt();
        System.out.println("Do you hold a current driving licence? ");
        holdLicence = in.next().charAt(0);

        if((age > 17) && (holdLicence == 'y'))
            System.out.println("You are an adult and you can hire a car");
        else
            System.out.println("You are not an adult and you cant hire a car");
        //endif
        in.close();
    }//end method main
}//end class AgeChecker
