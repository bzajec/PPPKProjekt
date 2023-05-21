/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

/**
 *
 * @author Bruno
 */
public class Vozac {
    
        public int iDVozac; 
        public String name; 
        public int brojMobitela;
        public int brojVozackeDozvole;
        
        
    public Vozac(String name, int brojMobitela, int brojVozackeDozvole) {
        this.name = name;
        this.brojMobitela = brojMobitela;
        this.brojVozackeDozvole = brojVozackeDozvole;
    }
    
    public Vozac(int iDVozac, String name, int brojMobitela, int brojVozackeDozvole) {
        this(name,brojMobitela,brojVozackeDozvole);
        this.iDVozac = iDVozac;
    }

    public int getiDVozac() {
        return iDVozac;
    }

    public String getName() {
        return name;
    }

    public int getBrojMobitela() {
        return brojMobitela;
    }

    public int getBrojVozackeDozvole() {
        return brojVozackeDozvole;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setBrojMobitela(int brojMobitela) {
        this.brojMobitela = brojMobitela;
    }

    public void setVozackaDozvola(int brojVozackeDozvole) {
        this.brojVozackeDozvole = brojVozackeDozvole;
    }

    @Override
    public String toString() {
        return name + ";" + brojMobitela + ";" + brojVozackeDozvole;
    }

    public static Vozac ParseFromCSV(String line) {

        String[] details = line.split(";");

        return new Vozac(details[0], Integer.parseInt(details[1]),Integer.parseInt(details[2]));
    }
}
