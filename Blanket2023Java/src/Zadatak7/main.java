package Zadatak7;

public class main {

	public static void main(String[] args) {
		Object[] niz = new Object[12];
		for(int i = 0;i<niz.length/2;i++) {
			niz[i] = new K2();
		}for(int i = niz.length/2;i < niz.length;i++) {
			niz[i] = new K1();
		}
		
		for(Object o : niz) {
			System.out.println((o instanceof K2) ? "K2" : "K1");
		}
	}

}
