package animalshop;

public class AnimalTester {
	public static void main(String[] args) {
		Dog dog1 = new Dog("Ace", "Beagle", 45.6);
		Dog dog2 = new Dog("Bailey", "Boerboel", "arf-arf", 80.2);
		
		System.out.println("Dog name : " + dog1.getName());
		System.out.println("Dog breed : " + dog1.getBreed());
		System.out.print("Bark noise: ");
		dog1.bark();
		System.out.println("Dog weight: " + dog1.getWeight());
		System.out.println("Dog name : " + dog2.getName());
		System.out.println("Dog breed : " + dog2.getBreed());
		System.out.print("Bark noise: ");
		dog2.bark();
		System.out.println("Dog weight: " + dog2.getWeight());
	}
}  
