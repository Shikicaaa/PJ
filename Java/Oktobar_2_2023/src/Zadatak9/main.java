package Zadatak9;

public class main {

	public static void main(String[] args) {
		Racun racun = new Racun(1000);
		Thread p = new Thread(new Producer(racun,2000));
		Thread c = new Thread(new Consumer(racun,2000));
		p.start();
		
		c.start();
	}

}
