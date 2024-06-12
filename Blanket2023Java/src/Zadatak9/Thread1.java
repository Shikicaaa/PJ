package Zadatak9;

public class Thread1 implements Runnable{
	private String name;
	public long sleep_time;
	public Thread1(String name, long sleep_time) { this.name = name; this.sleep_time = sleep_time;}
	public void run() {
		for(int i = 0;i<5;i++) {
			System.out.println(name);
			try {
				Thread.sleep(sleep_time);
			} catch (Exception e) {
				System.out.println(e);
			}
		}
	}
}
