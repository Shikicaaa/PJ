package Zadatak8;
import java.util.*;
import java.io.*;
public class Klasa {
	public void Metoda(String naziv){
		try {
			FileReader f = new FileReader(naziv + ".txt");
			BufferedReader br = new BufferedReader(f);
			double a;
			double b;
			String line = br.readLine();
			br.close();
			f.close();
			a = Double.parseDouble(line.split("/")[0]);
			b = Double.parseDouble(line.split("/")[1]);
			if(b == 0) {throw new NedefinisanRazlomak();}
			else {
				double razlomak = a/b;
				FileOutputStream fos = new FileOutputStream(naziv + ".bin");
				BufferedOutputStream bos = new BufferedOutputStream(fos);
				DataOutputStream dos = new DataOutputStream(bos);
				dos.writeDouble(razlomak);
				dos.close();
				bos.close();
				fos.close();
			}
		} catch (IOException e) {
			System.out.println(e);
		}catch(NedefinisanRazlomak e) {
			System.out.println(e);
		}catch(Exception e) {
			System.out.println(e);
		}
	}
}
