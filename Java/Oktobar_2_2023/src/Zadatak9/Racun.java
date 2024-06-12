package Zadatak9;
import java.util.*;
public class Racun {
	private double stanje;
	public synchronized void promeniStanje(double novoStanje) {
		System.out.println("Cekanje...");
		this.stanje = novoStanje;
		System.out.println("Stanje je uspesno promenjeno!");
		notify();
	}
	public synchronized void procitajStanje() {
		System.out.println("Cekanje...");
		try {
			wait();
		}catch(Exception e) {
			System.out.println(e.getMessage());
		}
		System.out.println(stanje + "RSD");
	}
	public Racun(double stanje) {
		
		this.stanje = stanje;
	}
}
