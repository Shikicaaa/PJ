package Zadatak7;

public class Klasa implements Interfejs{
	private int x;
	public Klasa(int x) {
		this.x = x;
	}
	public int zbir(Integer x) {
		return x.intValue() + this.x;
	}
	public double proizvod(double x) {
		return this.x * x;
	}
	public int zbir(int x) {//Ovde je potrebno da se doda ova metoda
		return x + this.x;	//jer je to metoda koju implementira ova klasa
	}						//ali nije dobro overrideovana jer ona gore ima Integer, a ova int
}
