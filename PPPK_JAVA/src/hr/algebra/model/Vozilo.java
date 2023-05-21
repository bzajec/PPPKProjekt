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
public class Vozilo {
    public int iDVozilo;
    public String tipVozila;
    public String markaVozila;
    public int godinaProizvodnje;
    public int inicijalnoStanjeKilometara;
    
    
    public Vozilo(String tipVozila, String markaVozila, int godinaProizvodnje, int inicijalnoStanjeKilometara) {
        this.tipVozila = tipVozila;
        this.markaVozila = markaVozila;
        this.godinaProizvodnje = godinaProizvodnje;
        this.inicijalnoStanjeKilometara = inicijalnoStanjeKilometara;
    }

    public Vozilo(int iDVozilo, String tipVozila, String markaVozila, int godinaProizvodnje, int inicijalnoStanjeKilometara) {
        this(tipVozila, markaVozila, godinaProizvodnje, inicijalnoStanjeKilometara);
        this.iDVozilo = iDVozilo;
    }

    public int getiDVozilo() {
        return iDVozilo;
    }

    public String getTipVozila() {
        return tipVozila;
    }

    public String getMarkaVozila() {
        return markaVozila;
    }

    public int getGodinaProizvodnje() {
        return godinaProizvodnje;
    }

    public int getInicijalnoStanjeKilometara() {
        return inicijalnoStanjeKilometara;
    }

    public void setTipVozila(String tipVozila) {
        this.tipVozila = tipVozila;
    }

    public void setMarkaVozila(String markaVozila) {
        this.markaVozila = markaVozila;
    }

    public void setGodProizvodnje(int godinaProizvodnje) {
        this.godinaProizvodnje = godinaProizvodnje;
    }

    public void setInicijalnoStanjeKilometara(int inicijalnoStanjeKilometara) {
        this.inicijalnoStanjeKilometara = inicijalnoStanjeKilometara;
    }

    @Override
    public String toString() {
        return tipVozila + ";" + markaVozila + ";" + godinaProizvodnje + ";" + inicijalnoStanjeKilometara;
    }

    
    public static Vozilo ParseFromCSV(String line) {

        String[] details = line.split(";");

        return new Vozilo(details[0],details[1],Integer.parseInt(details[2]),Integer.parseInt(details[3]));
    }
    
}
