package animalshop;

public class Dog {
	//instance field declarations
	private String name;
	private String breed;
	private String barkNoise = "Woof";
	private double weight;
	
	public Dog(String name, String breed, double weight) {
		this.name = name;
		this.breed = breed;
		this.weight = weight;
	}//end constructor method
	
	public Dog(String name, String breed, String noise, double weight) {
		this.name = name;
		this.breed = breed;
		barkNoise = noise;
		this.weight = weight;
	}//end constructor method
	
	public String getName() {
		return name;
	}//end method getName
	public void setName(String name) {
		this.name = name;
	}//end method setName
	public String getBreed() {
		return breed;
	}//end method getBreed
	public void setBreed(String breed) {
		this.breed = breed;
	}//end method setBreed
	public double getWeight() {
		return weight;
	}//end method getWeight
	public void setWeight(double weight) {
		this.weight = weight;
	}//end method setWeight
	public void bark(){
		System.out.println(barkNoise);
	}//end method bark
	public void bark(String barkNoise){
		System.out.println(barkNoise);
	}//end method bark
}//end class Dog
