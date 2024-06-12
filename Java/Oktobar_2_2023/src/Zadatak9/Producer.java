package Zadatak9;
import java.util.*;
public class Producer extends Thread{
	Racun racun;
	double stanje;
	public Producer(Racun racun, double stanje) {
		this.racun = racun;
		this.stanje = stanje;
	}
	public void run() {
		Random rnd = new Random();
		for(int i = 0;i<5;i++)
			racun.promeniStanje(rnd.nextDouble()*1000);
	}
}
