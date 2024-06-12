package Zadatak9;
public class main {

	public static void main(String[] args) {
		Thread prva = new Thread(new Thread1("Boban", 5000));
		Thread druga = new Thread(new Thread1("Coban", 2000));
		prva.start();
		druga.start();
	}

}
