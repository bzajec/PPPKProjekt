/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.model;

import java.io.Serializable;
import java.util.List;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

/**
 *
 * @author Bruno
 */

@Entity
@Table(name = "Vozilo")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "Vozilo.findAll", query = "SELECT v FROM Vozilo v")
    , @NamedQuery(name = "Vozilo.findByIDVozilo", query = "SELECT v FROM Vozilo v WHERE v.iDVozilo = :iDVozilo")
    , @NamedQuery(name = "Vozilo.findByTipVozila", query = "SELECT v FROM Vozilo v WHERE v.tipVozila = :tipVozila")
    , @NamedQuery(name = "Vozilo.findByMarkaVozila", query = "SELECT v FROM Vozilo v WHERE v.markaVozila = :markaVozila")
    , @NamedQuery(name = "Vozilo.findByGodinaProizvodnje", query = "SELECT v FROM Vozilo v WHERE v.godinaProizvodnje = :godinaProizvodnje")
    , @NamedQuery(name = "Vozilo.findByInicijalnoStanjeKilometara", query = "SELECT v FROM Vozilo v WHERE v.inicijalnoStanjeKilometara = :inicijalnoStanjeKilometara")})

public class Vozilo implements Serializable {
    
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "IDVozilo")
    private Integer iDVozilo;
    @Basic(optional = false)
    @Column(name = "TipVozila")
    private String tipVozila;
    @Basic(optional = false)
    @Column(name = "MarkaVozila")
    private String markaVozila;
    @Basic(optional = false)
    @Column(name = "GodinaProizvodnje")
    private int godinaProizvodnje;
    @Basic(optional = false)
    @Column(name = "InicijalnoStanjeKilometara")
    private int inicijalnoStanjeKilometara;
    @OneToMany(mappedBy = "voziloID")
    private List<PutniNalog> putniNalogList;
    @OneToMany(mappedBy = "voziloID")
    private List<Servis> servisList;
    
    public Vozilo() {
    }

    public Vozilo(Integer iDVozilo) {
        this.iDVozilo = iDVozilo;
    }

    public Vozilo(Integer iDVozilo, String tipVozila, String markaVozila, int godinaProizvodnje, int inicijalnoStanjeKilometara) {
        this.iDVozilo = iDVozilo;
        this.tipVozila = tipVozila;
        this.markaVozila = markaVozila;
        this.godinaProizvodnje = godinaProizvodnje;
        this.inicijalnoStanjeKilometara = inicijalnoStanjeKilometara;
    }

    public Integer getIDVozilo() {
        return iDVozilo;
    }

    public void setIDVozilo(Integer iDVozilo) {
        this.iDVozilo = iDVozilo;
    }

    public String getTipVozila() {
        return tipVozila;
    }

    public void setTipVozila(String tipVozila) {
        this.tipVozila = tipVozila;
    }

    public String getMarkaVozila() {
        return markaVozila;
    }

    public void setMarkaVozila(String markaVozila) {
        this.markaVozila = markaVozila;
    }

    public int getGodinaProizvodnje() {
        return godinaProizvodnje;
    }

    public void setGodProizvodnje(int godinaProizvodnje) {
        this.godinaProizvodnje = godinaProizvodnje;
    }

    public int getInicijalnoStanjeKilometara() {
        return inicijalnoStanjeKilometara;
    }

    public void setInicStanjeKilometara(int inicijalnoStanjeKilometara) {
        this.inicijalnoStanjeKilometara = inicijalnoStanjeKilometara;
    }

    @XmlTransient
    public List<PutniNalog> getPutniNalogList() {
        return putniNalogList;
    }

    public void setPutniNalogList(List<PutniNalog> putniNalogList) {
        this.putniNalogList = putniNalogList;
    }

    @XmlTransient
    public List<Servis> getServisList() {
        return servisList;
    }

    public void setServisList(List<Servis> servisList) {
        this.servisList = servisList;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (iDVozilo != null ? iDVozilo.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Vozilo)) {
            return false;
        }
        Vozilo other = (Vozilo) object;
        if ((this.iDVozilo == null && other.iDVozilo != null) || (this.iDVozilo != null && !this.iDVozilo.equals(other.iDVozilo))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Marka Auta: " + markaVozila +  " Tip Vozila: " + tipVozila + "";
    }
    
}
