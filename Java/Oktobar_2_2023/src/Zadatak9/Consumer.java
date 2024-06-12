package Zadatak9;
import java.util.*;
public class Consumer extends Thread{
	Racun racun;
	double stanje;
	public Consumer(Racun racun, double stanje) {
		this.racun = racun;
		this.stanje = stanje;
	}
	public void run() {try {
	sleep(1000);
	}catch(Exception e) {
		e.printStackTrace();
	}
		for(int i = 0;i<5;i++)
			racun.procitajStanje();
	}
}
